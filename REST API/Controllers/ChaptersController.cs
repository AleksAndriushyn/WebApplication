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
    public class ChaptersController : ControllerBase
    {
        private readonly IChapterService _chapterService;
        public ChaptersController(IChapterService chapterService)
        {
            _chapterService = chapterService;
        }

        // GET: api/Authors
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_chapterService.List());
        }

        // POST: api/Authors
        [HttpPost]
        public IActionResult Post([FromBody] DTOChapter book)
        {
            _chapterService.Insert(book);
            return Ok();
        }

        // PUT: api/Authors
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] DTOChapter book)
        {
            book.Id = id;
            _chapterService.Update(book);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _chapterService.DeleteEntity(id);
            return Ok();
        }
    }
}
