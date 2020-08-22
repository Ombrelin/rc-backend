using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RencontreContemporainesAPI.Models;
using RencontreContemporainesAPI.Services.Interfaces;

namespace RencontreContemporainesAPI.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    [ProducesResponseType(401)]
    public class ConcertController : ControllerBase
    {
        private readonly ICrudService<Concert> service;

        public ConcertController(ICrudService<Concert> service)
        {
            this.service = service;
        }

        [HttpGet]
        [AllowAnonymous]
        [ProducesResponseType(typeof(List<Concert>), StatusCodes.Status200OK)]
        public IActionResult GetConcerts() => Ok(service.GetAll());

        [HttpPost]
        [ProducesResponseType(typeof(Concert), StatusCodes.Status201Created)]
        public IActionResult CreateConcert([FromBody] Concert concert)
        {
            service.Insert(concert);
            return Created($"api/Concerts/{concert.Id}",concert);
        }

        [HttpDelete("{concertId:Guid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DeleteConcert(Guid concertId)
        {
            service.Delete(concertId);
            return Ok();
        }

        [HttpPut("{concertId:Guid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult UpdateConcert(Guid concertId, [FromBody] Concert concert)
        {
            service.Update(concert);
            return Ok();
        }
    }
}