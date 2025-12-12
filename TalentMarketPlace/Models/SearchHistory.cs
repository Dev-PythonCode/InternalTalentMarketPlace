using System.ComponentModel.DataAnnotations;

public class SearchHistory
{
    [Key]
    public int SearchId { get; set; }

    public int SearchedById { get; set; }

    [MaxLength(500)]
    public string SearchQuery { get; set; }

    [MaxLength(2000)]
    public string Filters { get; set; } // JSON string

    public int ResultCount { get; set; }

    public DateTime SearchDate { get; set; } = DateTime.UtcNow;

    public bool IsSaved { get; set; } = false;

    [MaxLength(100)]
    public string SavedSearchName { get; set; }

    // Navigation
    public Employee SearchedBy { get; set; }
}
