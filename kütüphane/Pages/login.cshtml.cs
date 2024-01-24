using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.OleDb;

namespace kütüphane.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Ad { get; set; }

        [BindProperty]
        public string Sifre { get; set; }

        public IActionResult OnPost()
        {
            // Access veritabanı bağlantı dizgisi
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\fatma\\Documents\\veriler.accdb";

            // SQL sorgusu (admin girişi kontrolü eklenmiştir)
            string sql = "SELECT COUNT(*) FROM veriler WHERE (Ad = ? AND Sifre = ?) OR (Ad = 'admin' AND Sifre = 'admin123')";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    // Parametrelerin eklenmesi
                    command.Parameters.AddWithValue("Ad", Ad);
                    command.Parameters.AddWithValue("Sifre", Sifre);
                    // Bağlantı açılır
                    connection.Open();

                    int userCount = (int)command.ExecuteScalar();

                    if (userCount > 0)
                    {
                        if (Ad == "admin" && Sifre == "admin")
                        {
                            // Admin girişi yapıldıysa product sayfasına yönlendir
                            return RedirectToPage("/Product");
                        }
                        else
                        {
                            // Kullanıcı girişi yapıldıysa anasayfaya yönlendir
                            return RedirectToPage("/Index");
                        }
                    }
                    else
                    {
                        // Kullanıcı doğrulanamadıysa hata mesajını göster
                        ModelState.AddModelError(string.Empty, "Kullanıcı adı veya şifre hatalı!");
                        return Page();
                    }
                }
            }
        }
    }
}