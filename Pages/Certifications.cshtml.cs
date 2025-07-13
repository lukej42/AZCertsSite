using Microsoft.AspNetCore.Mvc.RazorPages;
using AzureCertsSite.Models;
using AzureCertsSite.Services;

public class CertificationsModel : PageModel
{
    private readonly CertificationService _certService;
    public CertificationsModel(CertificationService certService)
    {
        _certService = certService;
    }
    public List<Certification> Certifications { get; set; }
    public void OnGet()
    {
        Certifications = _certService.GetCertifications();
    }
}