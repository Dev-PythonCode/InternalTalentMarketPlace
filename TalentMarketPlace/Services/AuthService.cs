using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using TalentMarketPlace.Data;
using TalentMarketPlace.Services.Interfaces;

namespace TalentMarketPlace.Services;

public class AuthService : IAuthService
{
    private readonly TalentMarketplaceDbContext _context;
    private readonly ProtectedSessionStorage _sessionStorage;
    private User? _currentUser;
    private Employee? _currentEmployee;

    public AuthService(TalentMarketplaceDbContext context, ProtectedSessionStorage sessionStorage)
    {
        _context = context;
        _sessionStorage = sessionStorage;
    }

    public async Task<LoginResult> LoginAsync(string email, string password)
    {
        var user = await _context.Users
            .FirstOrDefaultAsync(u => u.Email == email && u.IsActive);

        if (user == null)
        {
            return new LoginResult
            {
                Success = false,
                Error = "Invalid email or password"
            };
        }

        // For hackathon, simple password check
        // In production, use proper password hashing (BCrypt, etc.)
        if (user.PasswordHash != password && user.PasswordHash != $"hashedpassword{user.UserId}")
        {
            return new LoginResult
            {
                Success = false,
                Error = "Invalid email or password"
            };
        }

        var employee = await _context.Employees
            .Include(e => e.Team)
            .FirstOrDefaultAsync(e => e.UserId == user.UserId);

        // Store in session
        await _sessionStorage.SetAsync("UserId", user.UserId);
        await _sessionStorage.SetAsync("UserRole", user.Role);

        _currentUser = user;
        _currentEmployee = employee;

        return new LoginResult
        {
            Success = true,
            User = user,
            Employee = employee
        };
    }

    public async Task LogoutAsync()
    {
        await _sessionStorage.DeleteAsync("UserId");
        await _sessionStorage.DeleteAsync("UserRole");
        _currentUser = null;
        _currentEmployee = null;
    }

    public async Task<User?> GetCurrentUserAsync()
    {
        if (_currentUser != null) return _currentUser;

        try
        {
            var result = await _sessionStorage.GetAsync<int>("UserId");
            if (result.Success)
            {
                _currentUser = await _context.Users.FindAsync(result.Value);
            }
        }
        catch
        {
            // Session not available (e.g., during prerender)
        }

        return _currentUser;
    }

    public async Task<Employee?> GetCurrentEmployeeAsync()
    {
        if (_currentEmployee != null) return _currentEmployee;

        var user = await GetCurrentUserAsync();
        if (user == null) return null;

        _currentEmployee = await _context.Employees
            .Include(e => e.Team)
            .FirstOrDefaultAsync(e => e.UserId == user.UserId);

        return _currentEmployee;
    }

    public async Task<bool> IsAuthenticatedAsync()
    {
        var user = await GetCurrentUserAsync();
        return user != null;
    }

    public async Task<string?> GetCurrentRoleAsync()
    {
        try
        {
            var result = await _sessionStorage.GetAsync<string>("UserRole");
            return result.Success ? result.Value : null;
        }
        catch
        {
            return null;
        }
    }
}

// Simple AuthStateProvider for Blazor
public class AuthStateProvider
{
    private readonly IAuthService _authService;

    public AuthStateProvider(IAuthService authService)
    {
        _authService = authService;
    }

    public async Task<bool> IsAuthenticatedAsync() => await _authService.IsAuthenticatedAsync();
    public async Task<User?> GetCurrentUserAsync() => await _authService.GetCurrentUserAsync();
    public async Task<Employee?> GetCurrentEmployeeAsync() => await _authService.GetCurrentEmployeeAsync();
    public async Task<string?> GetRoleAsync() => await _authService.GetCurrentRoleAsync();
}