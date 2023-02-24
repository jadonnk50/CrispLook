using CrispLook.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CrispLook.Controllers;

[ApiController]
[Route("[controller]")]
public class ClothesController : ControllerBase
{
    [HttpPost()]
    public IActionResult CreateClothe(CreateClotheRequest request)
    {
        return Ok(request);
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetClothe(Guid id)
    {
        return Ok(id);
    }
    
    [HttpPut("{id:guid}")]
    public IActionResult UpsertClothe(Guid id, UpsertClotheRequest request)
    {
        return Ok(request);
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteClothe(Guid id)
    {
        return Ok(id);
    }

}
