using System.Collections.Generic;
using bricks.Models;
using bricks.Services;
using Microsoft.AspNetCore.Mvc;

namespace bricks.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class BricksController : ControllerBase
  {

    private readonly BricksService _service;

    public BricksController(BricksService service)
    {
      _service = service;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Brick>> Get()
    {
      try
      {
        return Ok(_service.Get());
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}")]

    public ActionResult<Brick> Get(int id)
    {
      try
      {
        return Ok(_service.Get(id));
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPost]
    public ActionResult<Brick> Create([FromBody] Brick newBrick)
    {
      try
      {
        return Ok(_service.Create(newBrick));
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPut("{id}")]
    public ActionResult<Brick> Edit([FromBody] Brick editBrick, int id)
    {
      try
      {
        editBrick.Id = id;
        return Ok(_service.Edit(editBrick));
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpDelete("{id}")]
    public ActionResult<Brick> Delete(int id)
    {
      try
      {
        return Ok(_service.Delete(id));
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }


  }
}