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
        private readonly ILibraryService _libraryService;
        public AuthorsController(IAuthorService authorService, ILibraryService libraryService)
        {
            _authorService = authorService;
            _libraryService = libraryService;
        }
        public IActionResult Index(string searchString, string searchDate, int searchAmountOfBooks)
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
            if (searchAmountOfBooks != 0)
            {
                return View(_libraryService.FindByAmountOfBooks(searchAmountOfBooks));
            }
            return View(authors);
        }
    }
}