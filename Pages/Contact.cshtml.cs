using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;


namespace AzureCertsSite.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty] public string Name { get; set; }
        [BindProperty] public string Email { get; set; }
        [BindProperty] public string Message { get; set; }

        public string Result { get; set; }

        public void OnPost()
        {
            // TODO: Save message to database or send email
            Result = "Thanks! Your message has been sent.";
        }
    }
}