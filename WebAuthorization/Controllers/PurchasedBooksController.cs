using Library.Bl.Abstract;
using Library.Entities;
using Library.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAuthorization.Controllers
{
    public class PurchasedBooksController : Controller
    {
        private readonly IPurchasedBookService _purchasedBookService;
        public PurchasedBooksController(IPurchasedBookService purchasedBookService)
        {
            _purchasedBookService = purchasedBookService;
        }
        public IActionResult Index()
        {
            List<DTOPurchasedBook> purchasedBooks = _purchasedBookService.List();
            return View(purchasedBooks);
        }
    }
}
