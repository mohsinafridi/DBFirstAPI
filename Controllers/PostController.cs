using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBFirstAPI.Models;
using Microsoft.AspNetCore.Mvc;



namespace DBFirstAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostController : ControllerBase
    {
        private readonly CoreDbContext _context;
        public PostController(CoreDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Posts> Get()
        {
            return _context.Posts.ToList();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
