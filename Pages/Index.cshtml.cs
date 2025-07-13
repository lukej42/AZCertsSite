using Microsoft.AspNetCore.Mvc.RazorPages;
using AzureCertsSite.Models;
using AzureCertsSite.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    private readonly CertificationService _certService;
    public IndexModel(CertificationService certService)
    {
        _certService = certService;
    }
    public List<Certification> Certifications { get; set; }
    public void OnGet()
    {
        Certifications = _certService.GetCertifications();
    }
}