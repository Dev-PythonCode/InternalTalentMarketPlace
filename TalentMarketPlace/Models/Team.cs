using System.ComponentModel.DataAnnotations;

public class Team
{
    public int TeamId { get; set; }

    [Required]
    [MaxLength(100)]
    public string TeamName { get; set; }

    [MaxLength(100)]
    public string Department { get; set; }

    public int? ManagerId { get; set; }

    [MaxLength(100)]
    public string Location { get; set; }

    public bool IsActive { get; set; } = true;

    // Navigation
    public Employee Manager { get; set; }
    public ICollection<Employee> Employees { get; set; }
    public ICollection<Requirement> Requirements { get; set; }
}