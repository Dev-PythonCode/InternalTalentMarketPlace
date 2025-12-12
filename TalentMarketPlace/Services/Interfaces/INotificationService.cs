namespace TalentMarketPlace.Services.Interfaces;

public interface INotificationService
{
    Task<List<Notification>> GetByEmployeeAsync(int employeeId, bool unreadOnly = false);
    Task<int> GetUnreadCountAsync(int employeeId);
    Task<bool> MarkAsReadAsync(int notificationId);
    Task<bool> MarkAllAsReadAsync(int employeeId);
    Task<Notification> CreateAsync(Notification notification);
    Task<bool> DeleteAsync(int notificationId);
    Task NotifyMatchingEmployeesAsync(int requirementId);
    Task NotifyApplicationStatusAsync(int applicationId);
}