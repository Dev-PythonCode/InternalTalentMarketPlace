using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TalentMarketPlace.Models
{
    public class EmailHistory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime SentDate { get; set; }

        [Required]
        public int RecipientCount { get; set; }

        [Required]
        [MaxLength(500)]
        public string Subject { get; set; }

        [MaxLength(100)]
        public string SentBy { get; set; }

        [MaxLength(50)]
        public string RecipientType { get; set; }

        public string RecipientList { get; set; } // Semicolon-separated emails

        [MaxLength(500)]
        public string CcAddress { get; set; }

        public int SuccessCount { get; set; }
        public int FailedCount { get; set; }
    }

    // NOTE: The EmailHistoryDto class is in IEmailService.cs
    // This DTO is used to transfer data between service and UI layers

   

    // Add to your DbContext
   

    /* 
    MIGRATION COMMANDS:

    1. Add Migration:
       dotnet ef migrations add AddEmailHistoryAndScheduledEmails

    2. Update Database:
       dotnet ef database update

    3. SQL Script (if needed):
       dotnet ef migrations script

    MIGRATION SQL (Alternative - Manual):

    CREATE TABLE EmailHistory (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    SentDate TEXT NOT NULL,
    RecipientCount INTEGER NOT NULL,
    Subject TEXT NOT NULL,
    SentBy TEXT,
    RecipientType TEXT,
    RecipientList TEXT,
    CcAddress TEXT,
    SuccessCount INTEGER NOT NULL DEFAULT 0,
    FailedCount INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IX_EmailHistory_SentDate 
ON EmailHistory(SentDate);

CREATE TABLE ScheduledEmails (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Recipients TEXT NOT NULL,
    Subject TEXT NOT NULL,
    Body TEXT NOT NULL,
    CcAddress TEXT,
    ScheduledTime TEXT NOT NULL,
    Status TEXT NOT NULL,
    CreatedDate TEXT NOT NULL,
    SentDate TEXT,
    CreatedBy TEXT,
    ErrorMessage TEXT
);

CREATE INDEX IX_ScheduledEmails_ScheduledTime_Status
ON ScheduledEmails(ScheduledTime, Status);

    */
}
