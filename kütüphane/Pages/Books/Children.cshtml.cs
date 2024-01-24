using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace WebApplication6.Pages.Books
{
    public class ChildrenModel : PageModel
    {
        public string CategoryName { get; } = "Çocuk Kitapları";
        public List<BookModel> Books { get; set; } = GetChildrenBooks();

        private static List<BookModel> GetChildrenBooks()
        {
            return new List<BookModel>
            {
                new BookModel
                {
                    Title = "Keloğlan Masalları",
                    Author = "Necati Cumalı",
                    Price = 14.99,
                    ImageUrl = "https://www.bilgiyayinevi.com.tr/u/bilgiyayinevi/img/b/k/e/keloglan-masallari290c0f80c99278091da1c72b65cfe046.jpg"
                },
                new BookModel
                {
                    Title = "Pamuk Prenses",
                    Author = "Grimm Kardeşler",
                    Price = 12.99,
                    ImageUrl = "https://img.kitapyurdu.com/v1/getImage/fn:2258652/wh:true/miw:200/mih:200"
                },
                new BookModel
                {
                    Title = "Ali Baba ve Kırk Haramiler",
                    Author = "Binbir Gece Masalları",
                    Price = 16.99,
                    ImageUrl = "https://img.kitapyurdu.com/v1/getImage/fn:158351/wh:true/miw:200/mih:200"
                },
                new BookModel
                {
                    Title = "Sevimli Ayıcık",
                    Author = "Sam McBratney",
                    Price = 13.99,
                    ImageUrl = "https://ideacdn.net/idea/ms/87/myassets/products/407/sevimli-ayicik-oykuleri-124237.jpg?revision=1697143329"
                },
                new BookModel
                {
                    Title = "Mavi Balina",
                    Author = "Meltem Kılıç",
                    Price = 19.99,
                    ImageUrl = "https://i.dr.com.tr/cache/500x400-0/originals/0001742801001-1.jpg"
                },
                new BookModel
                {
                    Title = "Küçük Prens",
                    Author = "Antoine de Saint-Exupéry",
                    Price = 11.99,
                    ImageUrl = "https://i.dr.com.tr/cache/500x400-0/originals/0000000628979-1.jpg"
                },
                
                new BookModel
                {
                    Title = "Uçan Ayakkabı",
                    Author = "Cemal Süreya",
                    Price = 15.99,
                    ImageUrl = "https://img.kitapyurdu.com/v1/getImage/fn:171876/wh:true/wi:800"
                },
                
                new BookModel
                {
                    Title = "Alice Harikalar Diyarında",
                    Author = "Lewis Carroll",
                    Price = 18.99,
                    ImageUrl = "https://i.dr.com.tr/cache/600x600-0/originals/0001703856001-1.jpg"
                },
              
                new BookModel
                {
                    Title = "Peter Pan",
                    Author = "J.M. Barrie",
                    Price = 16.99,
                    ImageUrl = "https://m.media-amazon.com/images/I/81jByLWw6aL._AC_UF894,1000_QL80_.jpg"
                },
                new BookModel
                {
                    Title = "Kayıp Şehir Z",
                    Author = "Ahmet Ümit",
                    Price = 21.99,
                    ImageUrl = "https://i.dr.com.tr/cache/500x400-0/originals/0001704991001-1.jpg"
                },
                new BookModel
                {
                    Title = "Küçük Deniz Kızı Ariel",
                    Author = "Hans Christian Andersen",
                    Price = 14.99,
                    ImageUrl = "https://m.media-amazon.com/images/I/61h3StAUC6L._AC_UF1000,1000_QL80_.jpg"
                },
                new BookModel
                {
                    Title = "Harry Potter ve Felsefe Taşı",
                    Author = "J.K. Rowling",
                    Price = 26.99,
                    ImageUrl = "https://i.dr.com.tr/cache/600x600-0/originals/0000000105599-1.jpg"
                },
              
            };
        }
    }
}
