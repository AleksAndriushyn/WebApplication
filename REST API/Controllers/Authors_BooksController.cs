using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Bl.Abstract;
using Library.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace REST_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class Authors_BooksController : ControllerBase
    {
        private readonly IAuthors_BookService _authors_bookService;
        public Authors_BooksController(IAuthors_BookService authors_bookService)
        {
            _authors_bookService = authors_bookService;
        }

        // GET: api/Authors
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_authors_bookService.List());
        }

        // POST: api/Authors
        [HttpPost]
        public IActionResult Post([FromBody] DTOAuthors_Book authors_book)
        {
            _authors_bookService.Insert(authors_book);
            return Ok();
        }

        // PUT: api/Authors
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] DTOAuthors_Book authors_book)
        {
            authors_book.Id = id;
            _authors_bookService.Update(authors_book);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _authors_bookService.DeleteEntity(id);
            return Ok();
        }
    }
}
