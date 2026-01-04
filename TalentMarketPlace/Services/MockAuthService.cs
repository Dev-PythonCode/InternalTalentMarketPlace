using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using TalentMarketPlace.Data;
using TalentMarketPlace.Services.Interfaces;

namespace TalentMarketPlace.Services;

/// <summary>
/// Mock Authentication Service for Testing on Mac (without SQL Server)
/// This bypasses database authentication and returns a hardcoded test user
/// </summary>
public class MockAuthService : IAuthService
{
    private readonly ProtectedSessionStorage _sessionStorage;
    private Employee? _currentEmployee;
    private User? _currentUser;

    public MockAuthService(ProtectedSessionStorage sessionStorage)
    {
        _sessionStorage = sessionStorage;
        InitializeMockUser();
    }

    private void InitializeMockUser()
    {
        // Create a mock user for testing
        _currentUser = new User
        {
            UserId = 1,
            Email = "test@example.com",
            Role = "Manager",
            IsActive = true,
            CreatedDate = DateTime.UtcNow
        };

        // Create a mock employee for testing
        _currentEmployee = new Employee
        {
            EmployeeId = 1,
            UserId = 1,
            FullName = "Test Manager",
            Email = "test@example.com",
            Designation = "Senior Manager",
            Location = "Bangalore",
            AvailabilityStatus = "Available",
            YearsOfExperience = 10.0m,
            PhoneNumber = "9876543210",
            TeamId = 1,
            Team = new Team
            {
                TeamId = 1,
                TeamName = "Engineering"
            }
        };

        Console.WriteLine("🔧 MockAuthService initialized with test user:");
        Console.WriteLine($"   User: {_currentEmployee.FullName} ({_currentEmployee.Email})");
        Console.WriteLine($"   Role: {_currentUser.Role}");
        Console.WriteLine($"   Designation: {_currentEmployee.Designation}");
    }

    public Task<LoginResult> LoginAsync(string email, string password)
    {
        // Auto-login with mock user
        return Task.FromResult(new LoginResult
        {
            Success = true,
            User = _currentUser,
            Employee = _currentEmployee
        });
    }

    public Task LogoutAsync()
    {
        // No-op for mock
        return Task.CompletedTask;
    }

    public Task<User?> GetCurrentUserAsync()
    {
        return Task.FromResult(_currentUser);
    }

    public Task<Employee?> GetCurrentEmployeeAsync()
    {
        return Task.FromResult(_currentEmployee);
    }

    public Task<bool> IsAuthenticatedAsync()
    {
        // Always authenticated in mock mode
        return Task.FromResult(true);
    }

    public Task<string?> GetCurrentRoleAsync()
    {
        return Task.FromResult<string?>(_currentUser?.Role);
    }
}

/// <summary>
/// Mock Auth State Provider for testing
/// </summary>
public class MockAuthStateProvider
{
    private readonly IAuthService _authService;

    public MockAuthStateProvider(IAuthService authService)
    {
        _authService = authService;
    }

    public async Task<bool> IsAuthenticatedAsync() => await _authService.IsAuthenticatedAsync();
    public async Task<User?> GetCurrentUserAsync() => await _authService.GetCurrentUserAsync();
    public async Task<Employee?> GetCurrentEmployeeAsync() => await _authService.GetCurrentEmployeeAsync();
    public async Task<string?> GetRoleAsync() => await _authService.GetCurrentRoleAsync();
}
