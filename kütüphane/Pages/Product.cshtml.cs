using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.OleDb;

namespace kütüphane.Pages
{
    public class ProductModel : PageModel
    {
        [BindProperty]
        public string Id { get; set; }

        [BindProperty]
        public string Title { get; set; }

        [BindProperty]
        public string Author { get; set; }

        [BindProperty]
        public decimal Price { get; set; }

        [BindProperty]
        public string Category { get; set; } // Yeni eklenen kategori alanı

        public IActionResult OnPost()
        {
            // Access veritabanı bağlantı dizgisi
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\fatma\\Documents\\products.accdb";

            // SQL sorgusu
            string sql = "INSERT INTO Products (Id, Title, Author, Price, Category) VALUES (?, ?, ?, ?, ?)";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    // Parametrelerin eklenmesi
                    command.Parameters.AddWithValue("Id", Id);
                    command.Parameters.AddWithValue("Title", Title);
                    command.Parameters.AddWithValue("Author", Author);
                    command.Parameters.AddWithValue("Price", Price);
                    command.Parameters.AddWithValue("Category", Category); // Yeni eklenen kategori parametresi

                    // Bağlantı açılır ve sorgu çalıştırılır
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            // Ürün eklendikten sonra başka bir sayfaya yönlendirme yapabilirsiniz
            return RedirectToPage("/Product");
        }
    }
}