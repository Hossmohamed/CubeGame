using CubeGame.BL.Manager;
using CubeGame.Data.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CubeGame.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MostplayedController : ControllerBase
    {
        IMostplayedManager repo;
        ApplicationDBContext Context;
        public MostplayedController(IMostplayedManager _repo, ApplicationDBContext _Context)
        {
            repo = _repo;
            Context = _Context;
        }
        [HttpGet]
        public IActionResult GetAllMostplayed()
        {
            if (repo.GetAll().Count() > 0)
            {
                return Ok(repo.GetAll());
            }
            return NotFound();
        }
    }
}
