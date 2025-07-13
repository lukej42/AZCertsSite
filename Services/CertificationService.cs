using AzureCertsSite.Models;
namespace AzureCertsSite.Services
{
    public class CertificationService
    {
        public List<Certification> GetCertifications()
        {
            return new List<Certification>
            {
                new Certification
                {
                    Title = "Microsoft Certified: Azure Fundamentals",
                    Code = "AZ-900",
                    DateAchieved = new DateTime(2024, 10, 6),
                    BadgeUrl = "/images/az-900.svg",
                    Link = "https://learn.microsoft.com/api/credentials/share/en-us/LukeJames-3094/C1B0FB7913204203?sharingId=75C0596BA88001B9"
                },
                new Certification
                {
                    Title = "Microsoft Certified: Azure Administrator Associate",
                    Code = "AZ-104",
                    DateAchieved = new DateTime(2025, 4, 4),
                    BadgeUrl = "/images/az-104.svg",
                    Link = "https://learn.microsoft.com/api/credentials/share/en-us/LukeJames-3094/FEEDA40736F30EA?sharingId=75C0596BA88001B9"
                },
                new Certification
                {
                    Title = "Microsoft Certified: DevOps Engineer Expert",
                    Code = "AZ-400",
                    DateAchieved = new DateTime(2025, 6, 27),
                    BadgeUrl = "/images/az-400.svg",
                    Link = "https://learn.microsoft.com/api/credentials/share/en-us/LukeJames-3094/5DEFC9B51B3784C4?sharingId=75C0596BA88001B9"
                },
            };
        }
    }
}