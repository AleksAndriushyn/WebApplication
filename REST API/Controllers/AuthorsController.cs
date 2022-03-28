using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Bl.Abstract;
using Library.DAL.Impl;
using Library.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace REST_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces ("application/json")]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorService _authorService;
        public AuthorsController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        // GET: api/Authors
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_authorService.List());
        }

        // POST: api/Authors
        [HttpPost]
        public IActionResult Post([FromBody] DTOAuthor author)
        {
            _authorService.Insert(author);
            return Ok();
        }

        // PUT: api/Authors
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] DTOAuthor author)
        {
            author.Id = id;
            _authorService.Update(author);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _authorService.DeleteEntity(id);
            return Ok();
        }
    }
}
