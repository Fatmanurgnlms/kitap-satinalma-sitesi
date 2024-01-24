using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace WebApplication6.Pages.Books
{
    public class TurkEdebiyati : PageModel
    {
        public string CategoryName { get; } = "Türk Edebiyatı";
        public List<BookModel> Books { get; set; } = GetTurkishLiteratureBooks();

        private static List<BookModel> GetTurkishLiteratureBooks()
        {
            return new List<BookModel>
            {
                new BookModel
                {
                    Title = "İnce Mehmed",
                    Author = "Yaşar Kemal",
                    Price = 29.99,
                    ImageUrl = "https://img.kitapyurdu.com/v1/getImage/fn:6663013/wh:true/wi:500"
                },
                new BookModel
                {
                    Title = "İçimizdeki Şeytan",
                    Author = "Sabahattin Ali",
                    Price = 34.99,
                    ImageUrl = "https://i.dr.com.tr/cache/600x600-0/originals/0001792260001-1.jpg"
                },
                new BookModel
                {
                    Title = "Aşk-ı Memnu",
                    Author = "Halit Ziya Uşaklıgil",
                    Price = 27.99,
                    ImageUrl = "https://img.kitapyurdu.com/v1/getImage/fn:96319/wh:true/miw:200/mih:200"
                },
                new BookModel
                {
                    Title = "İstanbul Hatırası",
                    Author = "Ahmet Ümit",
                    Price = 25.99,
                    ImageUrl = "https://img.kitapyurdu.com/v1/getImage/fn:33514/wh:true/wi:800"
                },
                new BookModel
                {
                    Title = "Kürk Mantolu Madonna",
                    Author = "Sabahattin Ali",
                    Price = 22.99,
                    ImageUrl = "https://i.dr.com.tr/cache/600x600-0/originals/0001791745001-1.jpg"
                },
                new BookModel
                {
                    Title = "Çalıkuşu",
                    Author = "Reşat Nuri Güntekin",
                    Price = 19.99,
                    ImageUrl = "https://i.dr.com.tr/cache/500x400-0/originals/0000000052566-1.jpg"
                },
                
                new BookModel
                {
                    Title = "Kuyucaklı Yusuf",
                    Author = "Sabahattin Ali",
                    Price = 31.99,
                    ImageUrl = "https://i.dr.com.tr/cache/500x400-0/originals/0001851635001-1.jpg"
                },
                new BookModel
                {
                    Title = "Ağrı Dağı Efsanesi",
                    Author = "Yaşar Kemal",
                    Price = 26.99,
                    ImageUrl = "https://i.dr.com.tr/cache/600x600-0/originals/0000000147950-1.jpg"
                },
                new BookModel
                {
                    Title = "Saatleri Ayarlama Enstitüsü",
                    Author = "Ahmet Hamdi Tanpınar",
                    Price = 23.99,
                    ImageUrl = "https://img.kitapyurdu.com/v1/getImage/fn:4542435/wh:true/wi:800"
                },
                new BookModel
                {
                    Title = "Tutunamayanlar",
                    Author = "Oğuz Atay",
                    Price = 28.99,
                    ImageUrl = "https://cdn.akakce.com/-/tutunamayanlar-oguz-atay-z.jpg"
                },
                new BookModel
                {
                    Title = "Hanımın Çiftliği",
                    Author = "Orhan Kemal",
                    Price = 24.99,
                    ImageUrl = "https://www.alfayayinlari.com/upload/9789752897038.jpg"
                },
                
                new BookModel
                {
                    Title = "Kardeşimin Hikayesi",
                    Author = "Zülfü Livaneli",
                    Price = 29.99,
                    ImageUrl = "https://i.dr.com.tr/cache/500x400-0/originals/0001939202001-1.jpg"
                },
              
                
            };
        }
    }
}
