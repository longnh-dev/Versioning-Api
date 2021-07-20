using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Versioning.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Versioning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesV2Controller : Controller
    {

        static List<MoviesV2> _movies = new List<MoviesV2>()
        {
            new MoviesV2(){Id = 0, MovieName = "Mission Impossible"},
            new MoviesV2(){Id = 1, MovieName = "JumanJi"}

        };
        // GET: api/<MoviesV2Controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MoviesV2Controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MoviesV2Controller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MoviesV2Controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MoviesV2Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
