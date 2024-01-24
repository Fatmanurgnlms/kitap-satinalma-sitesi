using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace kütüphane.Pages
{
    public class CartModel : PageModel
    {
        public List<CartItem> CartItems { get; set; }

        public void OnGet()
        {
            // Bu metot, sayfa yüklendiğinde çalışır. Sepet içeriğini almak için kullanılabilir.
            // Örneğin, veritabanından sepet içeriğini çekebilirsiniz.
            // Bu örnekte, önceki örnekte sepete eklenen kitapları kullanıyoruz.
            CartItems = new List<CartItem>();
        }
    }

    public class CartItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        // Diğer özellikleri ekleyebilirsiniz.
    }
}
