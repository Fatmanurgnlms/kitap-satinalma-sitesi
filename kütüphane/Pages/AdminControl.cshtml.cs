using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kütüphane.Pages
{
    public class AdminControlModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public bool ShowInvalidLoginMessage { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            // Kullanıcı adı ve şifreyi kontrol et
            if (Username == "admin" && Password == "admin123")
            {
                // Başarılı giriş durumu
                return RedirectToPage("/Index");
            }

            // Başarısız giriş durumu
            ShowInvalidLoginMessage = true;
            return Page();
        }
    }
}
