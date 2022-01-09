using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestApi.Models;

namespace RestApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private static List<Book> BookList = new List<Book>()
        {
            new Book
            {
                id = 1,
                Ad = "Kitap 1",
                Yazar = "Yazar 1",
                SayfaSayisi = 100
            },
            new Book
            {
                id = 2,
                Ad = "Kitap 2",
                Yazar = "Yazar 2",
                SayfaSayisi = 150
            },
            new Book
            {
                id = 3,
                Ad = "Kitap 3",
                Yazar = "Yazar 3",
                SayfaSayisi = 200
            }
        };

        /*
         * Get Kitap Listesi
         */

        [HttpGet("/Books")]
        public List<Book> books()
        {
            var bookList = BookList.OrderBy(x => x.id).ToList<Book>();
            return bookList;
        }

        /*
         * Kitap Getirme
         */
        [HttpGet("{id}")]
        public Book kitap(int id)
        {
            var book = BookList.Where(x => x.id == id).SingleOrDefault();
            return book;
        }

        [HttpPost]
        public IActionResult AddBook([FromBody] Book newBook)
        {
            var book = BookList.SingleOrDefault(x=>x.Ad == newBook.Ad);

            if (book != null)
                return BadRequest();

            BookList.Add(newBook);

            return Ok();
        }
    }
}
