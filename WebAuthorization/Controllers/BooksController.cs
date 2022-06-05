using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Bl.Abstract;
using Library.Entities;
using Library.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookService _bookService;
        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id, Title, Text, Price, Pages")] DTOBook book)
        {
            if (ModelState.IsValid)
            {
                _bookService.Insert(book);
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }
        public IActionResult Delete(int id)
        {
            return View(_bookService.Get(id));
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmDelete(int id)
        {
            _bookService.DeleteEntity(id);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int id)
        {
            return View(_bookService.Get(id));
        }
        [HttpPost, ActionName("Update")]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmUpdate([Bind("Id, Title, Text, Price, Pages")] DTOBook book)
        {
            _bookService.Update(book);
            return RedirectToAction(nameof(Index));
        }
    }
}