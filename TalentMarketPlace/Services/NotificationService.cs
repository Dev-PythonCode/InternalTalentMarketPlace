using Microsoft.EntityFrameworkCore;
using TalentMarketPlace.Data;
using TalentMarketPlace.Services.Interfaces;

namespace TalentMarketPlace.Services;

public class NotificationService : INotificationService
{
    private readonly TalentMarketplaceDbContext _context;

    public NotificationService(TalentMarketplaceDbContext context)
    {
        _context = context;
    }

    public async Task<List<Notification>> GetByEmployeeAsync(int employeeId, bool unreadOnly = false)
    {
        var query = _context.Notifications
            .Include(n => n.Requirement)
            .Where(n => n.EmployeeId == employeeId);

        if (unreadOnly)
        {
            query = query.Where(n => !n.IsRead);
        }

        return await query
            .OrderByDescending(n => n.CreatedDate)
            .ToListAsync();
    }

    public async Task<int> GetUnreadCountAsync(int employeeId)
    {
        return await _context.Notifications
            .CountAsync(n => n.EmployeeId == employeeId && !n.IsRead);
    }

    public async Task<bool> MarkAsReadAsync(int notificationId)
    {
        var notification = await _context.Notifications.FindAsync(notificationId);
        if (notification == null) return false;

        notification.IsRead = true;
        notification.ReadDate = DateTime.UtcNow;
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> MarkAllAsReadAsync(int employeeId)
    {
        var notifications = await _context.Notifications
            .Where(n => n.EmployeeId == employeeId && !n.IsRead)
            .ToListAsync();

        foreach (var notification in notifications)
        {
            notification.IsRead = true;
            notification.ReadDate = DateTime.UtcNow;
        }

        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<Notification> CreateAsync(Notification notification)
    {
        notification.CreatedDate = DateTime.UtcNow;
        _context.Notifications.Add(notification);
        await _context.SaveChangesAsync();
        return notification;
    }

    public async Task<bool> DeleteAsync(int notificationId)
    {
        var notification = await _context.Notifications.FindAsync(notificationId);
        if (notification == null) return false;

        _context.Notifications.Remove(notification);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task NotifyMatchingEmployeesAsync(int requirementId)
    {
        var requirement = await _context.Requirements
            .Include(r => r.RequirementSkills)
            .FirstOrDefaultAsync(r => r.RequirementId == requirementId);

        if (requirement == null) return;

        var skillIds = requirement.RequirementSkills.Select(rs => rs.SkillId).ToList();

        // Find employees with matching skills
        var matchingEmployees = await _context.Employees
            .Include(e => e.EmployeeSkills)
            .Where(e => e.EmployeeSkills.Any(es => skillIds.Contains(es.SkillId)))
            .Where(e => e.AvailabilityStatus != "Not Available")
            .ToListAsync();

        foreach (var employee in matchingEmployees)
        {
            // Calculate match percentage
            var matchedSkillCount = employee.EmployeeSkills
                .Count(es => skillIds.Contains(es.SkillId));
            var matchPercentage = skillIds.Count > 0
                ? (decimal)matchedSkillCount / skillIds.Count * 100
                : 0;

            // Only notify if match is >= 50%
            if (matchPercentage >= 50)
            {
                var notification = new Notification
                {
                    EmployeeId = employee.EmployeeId,
                    RequirementId = requirementId,
                    Title = $"New opportunity: {requirement.Title}",
                    Message = $"A new requirement matches {Math.Round(matchPercentage)}% of your skills. Location: {requirement.Location ?? "Any"}",
                    Type = "NewRequirement",
                    CreatedDate = DateTime.UtcNow
                };

                _context.Notifications.Add(notification);
            }
        }

        await _context.SaveChangesAsync();
    }

    public async Task NotifyApplicationStatusAsync(int applicationId)
    {
        var application = await _context.Applications
            .Include(a => a.Requirement)
            .FirstOrDefaultAsync(a => a.ApplicationId == applicationId);

        if (application == null) return;

        var statusMessage = application.Status switch
        {
            "Accepted" => "Congratulations! Your application has been accepted.",
            "Rejected" => "Your application was not selected. Keep trying!",
            "Shortlisted" => "Great news! You've been shortlisted for the next round.",
            _ => $"Your application status has been updated to: {application.Status}"
        };

        var notification = new Notification
        {
            EmployeeId = application.EmployeeId,
            RequirementId = application.RequirementId,
            Title = $"Application Update: {application.Requirement.Title}",
            Message = statusMessage,
            Type = "ApplicationUpdate",
            CreatedDate = DateTime.UtcNow
        };

        _context.Notifications.Add(notification);
        await _context.SaveChangesAsync();
    }
}