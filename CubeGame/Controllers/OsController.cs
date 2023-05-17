using CubeGame.BL.DTO;
using CubeGame.BL.Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CubeGame.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OsController : ControllerBase
    {
        IOsManager repo;
        public OsController(IOsManager _repo)
        {
            repo = _repo;
        }

        [HttpGet]
        public IActionResult GetAllOs()
        {
            if (repo.GetAll().Count() > 0)
            {
                return Ok(repo.GetAll());
            }
            return NotFound();
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            return Ok(repo.getOsByID(id));
        }

        [HttpPost]
        public IActionResult AddPlatform(OsDTO c)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    repo.AddOs(c);
                    return Created("url", c);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            return BadRequest();
        }

        [HttpPut]
        public IActionResult UpdateOs(int id, OsDTO c)
        {
            var uOs = repo.getOsByID(id);
            if (uOs == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    repo.EditOs(id, c);
                    return NoContent();
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            return BadRequest();
        }
        [HttpDelete("{id:int}")]
        public IActionResult DeleteOs(int id)
        {
            var c = repo.getOsByID(id);
            if (c == null)
            {
                return NotFound();
            }
            else
            {
                repo.DeleteOs(id);
                return Ok(c);
            }
        }
    }
}
