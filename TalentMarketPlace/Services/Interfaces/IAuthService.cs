namespace TalentMarketPlace.Services.Interfaces;

public interface IAuthService
{
    Task<LoginResult> LoginAsync(string email, string password);
    Task LogoutAsync();
    Task<User?> GetCurrentUserAsync();
    Task<Employee?> GetCurrentEmployeeAsync();
    Task<bool> IsAuthenticatedAsync();
    Task<string?> GetCurrentRoleAsync();
}

public class LoginResult
{
    public bool Success { get; set; }
    public string? Error { get; set; }
    public User? User { get; set; }
    public Employee? Employee { get; set; }
}