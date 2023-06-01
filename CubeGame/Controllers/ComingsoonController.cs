using CubeGame.BL.Manager;
using CubeGame.Data.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CubeGame.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComingsoonController : ControllerBase
    {
        IComingsoonManager repo;
        ApplicationDBContext Context;
        public ComingsoonController(IComingsoonManager _repo, ApplicationDBContext _Context)
        {
            repo = _repo;
            Context = _Context;
        }
        [HttpGet]
        public IActionResult GetAllComingsoon()
        {
            if (repo.GetAll().Count() > 0)
            {
                return Ok(repo.GetAll());
            }
            return NotFound();
        }
    }
}
