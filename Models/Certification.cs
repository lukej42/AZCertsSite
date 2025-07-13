namespace AzureCertsSite.Models
{
    public class Certification
    {
        public string Title { get; set; }
        public string Code { get; set; }
        public DateTime DateAchieved {get; set; }
        public string BadgeUrl {get; set; }
        public string Link { get; set; }
    }
}