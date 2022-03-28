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
    public class ReadersController : ControllerBase
    {
        private readonly IReaderService _readerService;
        public ReadersController(IReaderService readerService)
        {
            _readerService = readerService;
        }

        // GET: api/Authors
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_readerService.List());
        }

        // POST: api/Authors
        [HttpPost]
        public IActionResult Post([FromBody] DTOReader reader)
        {
            _readerService.Insert(reader);
            return Ok();
        }

        // PUT: api/Authors
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] DTOReader reader)
        {
            reader.Id = id;
            _readerService.Update(reader);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _readerService.DeleteEntity(id);
            return Ok();
        }
    }
}
