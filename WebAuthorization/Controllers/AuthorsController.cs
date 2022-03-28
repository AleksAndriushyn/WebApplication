using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Bl.Abstract;
using Library.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly IAuthorService _authorService;
        private readonly ILibraryService _LibraryService;
        public AuthorsController(IAuthorService authorService, ILibraryService LibraryService)
        {
            _authorService = authorService;
            _LibraryService = LibraryService;
        }
        public IActionResult Index(string searchString, string searchDate, int SearchAmountOfBooks)
        {
            DateTime dateofbirth = new DateTime();
            dateofbirth = Convert.ToDateTime(searchDate);

            var authors = _authorService.List();
            if (!String.IsNullOrEmpty(searchString))
            {
                authors = _authorService.FindByFirstName(searchString).ToList();
            }
            if (!String.IsNullOrEmpty(searchDate))
            {
                authors = _authorService.FindByDate(dateofbirth).ToList();
            }
            if (SearchAmountOfBooks != 0)
            {
                return View(_LibraryService.FindByAmountOfBooks(SearchAmountOfBooks));
            }
            return View(authors);
        }
    }
}