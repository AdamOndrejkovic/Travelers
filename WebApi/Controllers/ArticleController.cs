using System.Collections.Generic;
using System.IO;
using Core.IServices;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleService _service;

        public ArticleController(IArticleService service)
        {
            _service = service ?? throw new InvalidDataException("Article service can not be null");
        }

        [HttpPost]
        public ActionResult<Article> CreateArticle([FromBody] Article article)
        {
            if (string.IsNullOrEmpty(article.Title))
            {
                return BadRequest("Name is required");
            }
            var createProduct = _service.CreateArticle(article);
            if (createProduct)
            {
                return Ok("Article was created");
            }

            return BadRequest("Article was not created");
        }

        [HttpGet]
        public ActionResult<List<Article>> GetAll()
        {
            return _service.GetAllArticles();
        }

        [HttpPut]
        public ActionResult<Article> UpdateArticle([FromBody] Article article)
        {
            var updateProduct = _service.UpdateArticle(article);
            if (updateProduct)
            {
                return Ok("Article was updated");
            }

            return BadRequest("Article couldn't be updated");
        }

        [HttpDelete("{id}")]
        public ActionResult<Article> DeleteArticle(int id)
        {
            var deletedProduct = _service.DeleteArticle(id);
            if (deletedProduct)
            {
                return Ok("Article was deleted");
            }
            return BadRequest("Article couldn't be deleted");
        }
        
        [HttpGet("{id}")]
        public ActionResult<Article> GetArticleById(int id)
        {
            var productById = _service.GetArticleById(id);
            if (productById != null)
            {
                return productById;
            }

            return BadRequest("Article was not found");
        }
    }
}