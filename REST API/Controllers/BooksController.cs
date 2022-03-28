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
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        // GET: api/Authors
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_bookService.List());
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            return Ok(_bookService.Get(id));
        }

        // POST: api/Authors
        [HttpPost]
        public IActionResult Post([FromBody] DTOBook book)
        {
            _bookService.Insert(book);
            return Ok();
        }

        // PUT: api/Authors
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] DTOBook book)
        {
            book.Id = id;
            _bookService.Update(book);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _bookService.DeleteEntity(id);
            return Ok();
        }
    }
}
