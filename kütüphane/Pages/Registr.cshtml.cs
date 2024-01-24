using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.OleDb;

namespace kütüphane.Pages
{
    public class RegistrModel : PageModel
    {
        [BindProperty]
        public string ad { get; set; }

        [BindProperty]
        public string sifre { get; set; }

        public string ErrorMessage { get; set; }

        public IActionResult OnPost()
        {
            // Access veritabanı bağlantı dizgisi
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\fatma\\Documents\\veriler.accdb";

            // Var olan kullanıcının kontrolü
            if (IsUserRegistered(ad))
            {
                ErrorMessage = "Bu kullanıcı zaten kayıtlı!";
                return Page();
            }

            // SQL sorgusu
            string sql = "INSERT INTO veriler (ad, sifre) VALUES (?, ?)";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    // Parametrelerin eklenmesi
                    command.Parameters.AddWithValue("ad", ad);
                    command.Parameters.AddWithValue("sifre", sifre);
                    // Bağlantı açılır ve sorgu çalıştırılır
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            // Ürün eklendikten sonra başka bir sayfaya yönlendirme yapabilirsiniz
            return RedirectToPage("/Index");
        }

        private bool IsUserRegistered(string ad)
        {
            // Kullanıcının veritabanında kayıtlı olup olmadığını kontrol etmek için kullanılacak sorgu
            // Bu sorguyu, kullanılan veritabanı şemasına ve yapılandırmasına uygun şekilde güncellemeniz gerekebilir
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\fatma\\Documents\\veriler.accdb";
            string sql = "SELECT COUNT(*) FROM veriler WHERE ad = ?";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("ad", ad);
                    connection.Open();

                    int userCount = (int)command.ExecuteScalar();
                    return userCount > 0;
                }
            }
        }
    }
}
