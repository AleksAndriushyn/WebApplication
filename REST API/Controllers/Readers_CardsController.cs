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
    public class Readers_CardsController : ControllerBase
    {
        private readonly IReaders_CardService _readers_cardService;
        public Readers_CardsController(IReaders_CardService readers_cardService)
        {
            _readers_cardService = readers_cardService;
        }

        // GET: api/Authors
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_readers_cardService.List());
        }

        // POST: api/Authors
        [HttpPost]
        public IActionResult Post([FromBody] DTOReaders_Card readers_card)
        {
            _readers_cardService.Insert(readers_card);
            return Ok();
        }

        // PUT: api/Authors
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] DTOReaders_Card readers_card)
        {
            readers_card.Id = id;
            _readers_cardService.Update(readers_card);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _readers_cardService.DeleteEntity(id);
            return Ok();
        }
    }
}
