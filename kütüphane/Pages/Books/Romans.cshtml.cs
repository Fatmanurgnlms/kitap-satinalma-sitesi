using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication6.Pages.Books
{
    public class RomansModel : PageModel
    {
        public string CategoryName { get; } = "Roman";
        public List<BookModel> Books { get; set; } = GetRomansBooks();

        private static List<BookModel> GetRomansBooks()
        {
            return new List<BookModel>
            {
                new BookModel
                {
                    Title = "Suç ve Ceza",
                    Author = "Fyodor Dostoyevsky",
                    Price = 29.99,
                    ImageUrl = "https://i.dr.com.tr/cache/500x400-0/originals/0001788076001-1.jpg"
                },
                new BookModel
                {
                    Title = "Savaş ve Barış",
                    Author = "Leo Tolstoy",
                    Price = 34.99,
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1621690369i/58120097.jpg"
                },
                new BookModel
                {
                    Title = "Anna Karenina",
                    Author = "Leo Tolstoy",
                    Price = 27.99,
                    ImageUrl = "https://www.canyayinlari.com/productimages/119447/original/9789750739651_front_cover.jpg"
                },
                new BookModel
                {
                    Title = "Gurur ve Önyargı",
                    Author = "Jane Austen",
                    Price = 25.99,
                    ImageUrl = "https://m.media-amazon.com/images/I/51aNMIJuT6L._AC_UF894,1000_QL80_.jpg"
                },
                new BookModel
                {
                    Title = "1984",
                    Author = "George Orwell",
                    Price = 22.99,
                    ImageUrl = "https://i.dr.com.tr/cache/600x600-0/originals/0000000064038-1.jpg"
                },
                new BookModel
                {
                    Title = "Simyacı",
                    Author = "Paulo Coelho",
                    Price = 19.99,
                    ImageUrl = "https://img.kitapyurdu.com/v1/getImage/fn:11819904/wh:true/wi:500"
                },
                new BookModel
                {
                    Title = "Crime and Punishment",
                    Author = "Fyodor Dostoyevsky",
                    Price = 29.99,
                    ImageUrl = "https://img.kitapyurdu.com/v1/getImage/fn:11380092/wh:true/miw:200/mih:200"
                },
                new BookModel
                {
                    Title = "War and Peace",
                    Author = "Leo Tolstoy",
                    Price = 34.99,
                    ImageUrl = "https://m.media-amazon.com/images/I/71wXZB-VtBL._AC_UF1000,1000_QL80_.jpg"
                },
                
                new BookModel
                {
                    Title = "Dune",
                    Author = "Frank Herbert",
                    Price = 31.99,
                    ImageUrl = "https://img.kitapyurdu.com/v1/getImage/fn:11494736/wh:true/wi:800"
                },
                new BookModel
                {
                    Title = "To Kill a Mockingbird",
                    Author = "Harper Lee",
                    Price = 26.99,
                    ImageUrl = "https://img.kitapyurdu.com/v1/getImage/fn:94738/wh:true/wi:500"
                },
                new BookModel
                {
                    Title = "The Great Gatsby",
                    Author = "F. Scott Fitzgerald",
                    Price = 23.99,
                    ImageUrl = "https://m.media-amazon.com/images/I/81QuEGw8VPL._AC_UF1000,1000_QL80_.jpg"
                },
                new BookModel
                {
                    Title = "One Hundred Years of Solitude",
                    Author = "Gabriel Garcia Marquez",
                    Price = 28.99,
                    ImageUrl = "https://m.media-amazon.com/images/I/71IWwBoDNsL._AC_UF1000,1000_QL80_.jpg"
                },
               
            };
        }
    }
}

