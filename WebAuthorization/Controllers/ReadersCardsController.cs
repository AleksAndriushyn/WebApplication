using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Bl.Abstract;
using Library.Entities;
using Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication1.Controllers
{
    public class ReadersCardsController : Controller
    {
        private readonly IReaders_CardService _readersCardService;
        private readonly IBookService _bookService;
        public ReadersCardsController(IReaders_CardService readersCardService, IBookService bookService)
        {
            _readersCardService = readersCardService;
            _bookService = bookService;
        }
        public IActionResult Index()
        {
            var a = _readersCardService.List();
            return View(a);
        }
        public IActionResult Create()
        {
            ViewData["BookId"] = new SelectList(_bookService.List(), "Id", "Id");
            ViewData["ReaderId"] = new SelectList(_readersCardService.List(), "Id", "Id");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id, FirstName, LastName, Date, BookId, Book, ReaderId")] DTOReaders_Card readers_Card)
        {
            if (ModelState.IsValid)
            {
                _readersCardService.Insert(readers_Card);
                return RedirectToAction(nameof(Index));
            }
            return View(readers_Card);
        }
        public IActionResult Delete(int id)
        {
            return View(_readersCardService.Get(id));
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmDelete(int id)
        {
            _readersCardService.DeleteEntity(id);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int id)
        {
            return View(_readersCardService.Get(id));
        }
        [HttpPost, ActionName("Update")]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmUpdate([Bind("Id, FirstName, LastName, Date, BookId, ReaderId")] DTOReaders_Card readers_Card)
        {
            _readersCardService.Update(readers_Card);
            return RedirectToAction(nameof(Index));
        }
    }
}