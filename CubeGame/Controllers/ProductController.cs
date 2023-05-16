using CubeGame.BL.DTO;
using CubeGame.BL.Manager;
using CubeGame.DAL.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CubeGame.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductManager repo;
        public ProductController(IProductManager _repo)
        {
            repo = _repo;
        }

        [HttpGet]
        public IActionResult GetAllProduct()
        {
            if (repo.GetAll().Count() > 0)
            {
                return Ok(repo.GetAll());
            }
            return NotFound();
        }

        [HttpGet("ImagesProduct")]
        public IActionResult GetImageProduct(int Productid)
        {
            if (repo.GetProductImages(Productid).Count() > 0)
            {
                return Ok(repo.GetProductImages(Productid));
            }
            return NotFound();
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            return Ok(repo.getProductByID(id));
        }

        [HttpPost]
        public IActionResult AddProduct([FromForm] ProductDTO c)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    repo.AddProduct(c);
                    return Created("url", c);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, [FromForm] ProductDTO c)
        {
            var uCategory = repo.getProductByID(id);
            if (uCategory == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    repo.EditProduct(id, c);
                    return NoContent();
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            return BadRequest();
        }
        [HttpDelete("DeleteProduct/{id:int}")]
        public IActionResult DeleteProduct(int id)
        {
            var c = repo.getProductByID(id);
            if (c == null)
            {
                return NotFound();
            }
            else
            {
                repo.DeleteProduct(id);
                return Ok(c);
            }
        }

        [HttpPost("AddImage/{id:int}")]
        public IActionResult AddImage(int id , [FromForm] ImageDTO i)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    repo.AddProductImages(id , i);
                    return Created("url", id);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            return BadRequest();
        }
    }
}
