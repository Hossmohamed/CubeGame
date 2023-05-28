using CubeGame.BL.Manager;
using CubeGame.Data.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CubeGame.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecentlyupdatedController : ControllerBase
    {
        IRecentlyupdatedManager repo;
        ApplicationDBContext Context;
        public RecentlyupdatedController(IRecentlyupdatedManager _repo, ApplicationDBContext _Context)
        {
            repo = _repo;
            Context = _Context;
        }
        [HttpGet]
        public IActionResult GetAllRecentlyupdated()
        {
            if (repo.GetAll().Count() > 0)
            {
                return Ok(repo.GetAll());
            }
            return NotFound();
        }
    }
}
