namespace TalentMarketPlace.Models
{
    public class MailMessageModel
    {
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }      // comma-separated
        public string? CCAddress { get; set; }     // comma-separated
        public string Subject { get; set; }
        public string Body { get; set; }
     
    }
}
