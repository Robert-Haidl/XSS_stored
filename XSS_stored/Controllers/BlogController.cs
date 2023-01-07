using Microsoft.AspNetCore.Authorization;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using XSS_stored.Data;
using XSS_stored.Models;
using System.Web;

namespace XSS_stored.Controllers
{

    public class BlogController : Controller
    {
        private readonly IBlogRepository _repository;

        public BlogController(IBlogRepository repository)
        {
            //_blogService = blogService;
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet("blogs")]
        public ActionResult<IEnumerable<BlogItem>> Blogs()
        {
            try
            {
                var results = _repository.getAllBlogItems();
                if (results.Count() > 0)
                {
                    return Ok(results);
                }
                else
                {
                    return BadRequest("no blog entries found");
                }
            }
            catch (Exception e)
            {
                throw new Exception("error occured: " + e);
            }

        }

        [HttpGet("blogs/{id:int}")]
        public ActionResult<IEnumerable<BlogItem>> BlogByID(int id)
        {
            try
            {
                var results = _repository.getBlogItemByID(id);
                if (results.Count() > 0)
                {
                    return Ok(results);
                }
                else
                {
                    return BadRequest("no blog entries found");
                }
            }
            catch (Exception e)
            {
                throw new Exception("error occured: " + e);
            }

        }


        [HttpPost("blogs")]
        public IActionResult addBlog([FromBody] BlogItem blog)
        {
            //prevent cross site-scripting using sanitizeBlogItem function, which HTML encodes the model
            //blog = sanitizeBlogItem(blog);
            _repository.addBlog(blog);
            return Ok(blog);
        }

        public BlogItem sanitizeBlogItem(BlogItem blog)
        {
            BlogItem b = new BlogItem {
                author = HttpUtility.HtmlEncode(blog.author),
                description = HttpUtility.HtmlEncode(blog.description),
                title = HttpUtility.HtmlEncode(blog.title)
            };
            return b;
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            throw new Exception("An error occured");
        }
    }
}


