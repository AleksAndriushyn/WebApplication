using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Bl.Abstract;
using Library.Entities;
using Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookService _bookService;
        private readonly IPurchasedBookService _purchasedBookService;

        public BooksController(IBookService bookService, IPurchasedBookService purchasedBookService)
        {
            _bookService = bookService;
            _purchasedBookService = purchasedBookService;
        }

        public IActionResult Index(string searchTitle)
        {
            if (!String.IsNullOrEmpty(searchTitle))
            {
                return View(_bookService.FindByTitle(searchTitle).ToList());
            }

            List<DTOBook> books = _bookService.List();
            
            return View(books);
        }

        public IActionResult GetBookInfo(Book book)
        {
            return View(_bookService.GetBookInfo(book));
        }
        
        public IActionResult BuyBook(Book book)
        {
            return View(_purchasedBookService.Buy(book).ToList());
        }
    }
}