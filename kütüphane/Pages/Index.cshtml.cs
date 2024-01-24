using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;
using System.Collections.Generic;  // List tipini kullanabilmek için gerekli using bildirimi

public class BookModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }
    public string ImageFileName { get; set; }

    public string ImageUrl { get; set; }
}

public class HighlightedBookModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }
    public string ImageFileName { get; set; }
}

public class IndexModel : PageModel
{
    public List<BookModel> RecommendedBooks { get; set; }
    public List<HighlightedBookModel> HighlightedBooks { get; set; }
    public List<BookModel> WeeklyDeals { get; set; }

    public void OnGet()
    {
        RecommendedBooks = new List<BookModel>
        {
            new BookModel { Id = 1, Title = "Kürk Mantolu Madonna", Author = "Sabahattin Ali", Price = 65.99, ImageFileName = "ki1.jpg" },
            new BookModel { Id = 2, Title = "Martın Eden", Author = "Jack London", Price = 24.99, ImageFileName = "ki2.jpg" },
            new BookModel { Id = 3, Title = "Söyleme Bilmesinler", Author = "Şermin Yaşar", Price = 55.99, ImageFileName = "ki4.jpg" },
            new BookModel { Id = 4, Title = "Gurur Ve Önyargı", Author = "<3Jane Austen<3", Price = 89.99, ImageFileName = "ki5.jpg" }
        };

        HighlightedBooks = new List<HighlightedBookModel>
        {
            new HighlightedBookModel { Id = 5, Title = "Gittiğin Her Yere Kendinide Götür", Author = "Jon Kabat", Price = 39.99, ImageFileName = "ki6.jpg" },
            new HighlightedBookModel { Id = 6, Title = "Yıkım Günleri", Author = "Nedim Gürsel", Price = 68.99, ImageFileName = "ki7.jpg" },
            new HighlightedBookModel { Id = 7, Title = "Savaşçı", Author = "Edoaro Albert", Price = 59.99, ImageFileName = "ki8.jpg" },
            new HighlightedBookModel { Id = 8, Title = "İyileşmek Üzerine", Author = "Adam Phillips", Price = 34.99, ImageFileName = "ki9.jpg" },
            new HighlightedBookModel { Id = 9, Title = "Üçüncü Kapı", Author = "Alex Banayan", Price = 34.99, ImageFileName = "ki10.jpg" },
            new HighlightedBookModel { Id = 10, Title = "Sınırsız Ülke", Author = "Patricia Engel", Price = 34.99, ImageFileName = "ki11.jpg" },
            new HighlightedBookModel { Id = 11, Title = "Peri Masalı", Author = "Stephen Kıng", Price = 104.99, ImageFileName = "ki13.jpg" },
            new HighlightedBookModel { Id = 12, Title = "Balonla Beş Hafta", Author = "Junes Verne", Price = 34.99, ImageFileName = "ki14.jpg" },
            // İstediğiniz kadar öne çıkan kitap ekleyebilirsiniz
        };

        WeeklyDeals = new List<BookModel>
        {
            new BookModel { Id = 13, Title = "Otomatik Portakal", Author = "Anthony Burgess", Price = 14.99, ImageFileName = "h1.jpg" },
            new BookModel { Id = 14, Title = "Veronikya Ölmek İstiyor", Author = "Paulo Coelho", Price = 19.99, ImageFileName = "h2.jpg" },
            new BookModel { Id = 15, Title = "Simyacı", Author = "Paulo Coelho", Price = 14.99, ImageFileName = "h3.jpg" },
            new BookModel { Id = 16, Title = "Blinmeyen Bir Kadının Mektubu", Author = "Stefan Zweıng", Price = 19.99, ImageFileName = "h4.jpg" },
            new BookModel { Id = 17, Title = "İntihar Mektubu", Author = "Jean Teule", Price = 14.99, ImageFileName = "h5.jpg" },
        };
    }

    public IActionResult OnPostAddToCart(int bookId)
    {
        // Sepete ekleme işlemlerini gerçekleştirin, örneğin Session kullanabilirsiniz.
        // Bu örnekte basit bir örnek olarak TempData kullanılmıştır.
        TempData["AddedBookId"] = bookId;

        return RedirectToPage("/Cart/Index");
    }
}
