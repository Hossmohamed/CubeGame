using CubeGame.BL.Manager;
using CubeGame.Data.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CubeGame.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewreleaseController : ControllerBase
    {
        INewreleaseManager repo;
        ApplicationDBContext Context;
        public NewreleaseController(INewreleaseManager _repo, ApplicationDBContext _Context)
        {
            repo = _repo;
            Context = _Context;
        }
        [HttpGet]
        public IActionResult GetAllNewrelease()
        {
            if (repo.GetAll().Count() > 0)
            {
                return Ok(repo.GetAll());
            }
            return NotFound();
        }
    }
}
