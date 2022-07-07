using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RencontreContemporainesAPI.Models;
using RencontreContemporainesAPI.Services.Interfaces;

namespace RencontreContemporainesAPI.Controllers;

[ApiController]
[Authorize]
[Route("api/[controller]")]
[ProducesResponseType(401)]
public class AtelierController : ControllerBase
{
    private readonly ICrudService<Atelier> service;

    public AtelierController(ICrudService<Atelier> service)
    {
        this.service = service;
    }
        
    [HttpGet]
    [AllowAnonymous]
    [ProducesResponseType(typeof(List<Atelier>), StatusCodes.Status200OK)]
    public IActionResult GetAteliers() => Ok(service.GetAll().OrderBy(a => a.Date).ToList());
        

    [HttpPost]
    [ProducesResponseType(typeof(Atelier), StatusCodes.Status201Created)]
    public IActionResult CreateAtelier([FromBody] Atelier atelier)
    {
        service.Insert(atelier);
        return Ok(atelier);
    }

    [HttpDelete("{atelierId:Guid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult DeleteAtelier(Guid atelierId)
    {
        service.Delete(atelierId);
        return Ok();
    }

    [HttpPut("{atelierId:Guid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult UpdateAtelier(Guid atelierId, [FromBody] Atelier atelier)
    {
        service.Update(atelier);
        return Ok();
    }
}