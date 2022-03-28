using Library.Bl.Abstract;
using Library.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAuthorization.Controllers
{
    public class RecommendedBooksController : Controller
    {
        private readonly ILibraryService _libraryService;
        public RecommendedBooksController(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }
        public IActionResult Index()
        {
            List<DTOBook> recommendedBooks = _libraryService.GetRecommendedBook().ToList();

            return View(recommendedBooks);
        }
    }
}
