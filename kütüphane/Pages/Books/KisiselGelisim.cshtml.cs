using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace WebApplication6.Pages.Books
{
    public class KisiselGelisim : PageModel
    {
        public string CategoryName { get; } = "Kişisel Gelişim";
        public List<BookModel> Books { get; set; } = GetPersonalDevelopmentBooks();

        private static List<BookModel> GetPersonalDevelopmentBooks()
        {
            return new List<BookModel>
            {
                new BookModel
                {
                    Title = "Zihinsel Karmaşayı Temizlemek",
                    Author = "Dr. Caroline Leaf",
                    Price = 29.99,
                    ImageUrl = "https://img.kitapyurdu.com/v1/getImage/fn:11678986/wh:true/wi:800"
                },
                new BookModel
                {
                    Title = "Kendini Keşfet",
                    Author = "Herman Hesse",
                    Price = 34.99,
                    ImageUrl = "https://img.kitapyurdu.com/v1/getImage/fn:11531278/wh:true/wi:500"
                },
                new BookModel
                {
                    Title = "İnsanın Değeri",
                    Author = "Marco Malvaldi",
                    Price = 27.99,
                    ImageUrl = "https://i.dr.com.tr/cache/600x600-0/originals/0001924932001-1.jpg"
                },
                new BookModel
                {
                    Title = "Başarının Anahtarları",
                    Author = "Napoleon Hill",
                    Price = 25.99,
                    ImageUrl = "https://m.media-amazon.com/images/I/61EzcQjLLsL._AC_UF894,1000_QL80_.jpg"
                },
                new BookModel
                {
                    Title = "Atomik Alışkanlıklar",
                    Author = "James Clear",
                    Price = 22.99,
                    ImageUrl = "https://m.media-amazon.com/images/I/61vZr+Uy--L._AC_UL640_FMwebp_QL65_.jpg"
                },
                new BookModel
                {
                    Title = "Çürümenin Kitabı",
                    Author = "Emil Michel Cioran",
                    Price = 19.99,
                    ImageUrl = "https://m.media-amazon.com/images/I/51RJ-bnDCGL._AC_UL640_FMwebp_QL65_.jpg"
                },
                
                new BookModel
                {
                    Title = "Zihinsel Şifa",
                    Author = "Muhammed Bozdağ",
                    Price = 31.99,
                    ImageUrl = "https://i.dr.com.tr/cache/500x400-0/originals/0001893330001-1.jpg"
                },
                new BookModel
                {
                    Title = "İçsel İyileşme",
                    Author = "Victor Flame",
                    Price = 26.99,
                    ImageUrl = "https://www.kitapambari.com/u/kitapambari/img/c/i/c/icsel-iyilesme18222398161ed949fad504715ea167a5.jpg"
                },
               
                
            };
        }
    }
}
