﻿using CubeGame.BL.DTO;
using CubeGame.BL.Manager;
using CubeGame.DAL.Data.Models;
using CubeGame.DAL.Repo.product;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;
using System.IO;

namespace CubeGame.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductManager repo;
        private IWebHostEnvironment env;
        private IHttpContextAccessor httpContextAccessor;
        public ProductController( IProductManager _repo , IWebHostEnvironment _env, IHttpContextAccessor _httpContextAccessor)
        {
            repo = _repo;
            env = _env;
            httpContextAccessor = _httpContextAccessor;
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
        public IActionResult AddProduct([FromForm] ProductDTO c )
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
        public IActionResult AddImage(int id, IFormFile file)
        {
            Image I = new Image();
            if (ModelState.IsValid)
            {
                try
                {
                    var path = Path.Combine(env.WebRootPath, "uploads", file.FileName);

                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(fileStream);

                    }
                    var baseURL = httpContextAccessor.HttpContext.Request.Scheme + "://" +
                        httpContextAccessor.HttpContext.Request.Host +
                        httpContextAccessor.HttpContext.Request.PathBase;

                    var im = baseURL + "/uploads/" + file.FileName;

                    I.ImageURL = im;

                    repo.AddProductImages(id, I);

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
