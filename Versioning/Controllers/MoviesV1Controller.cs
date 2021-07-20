using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Versioning.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Versioning.Controllers
{
    [Produces("application/json")]
    [Route("api/movies")]
    [ApiVersion("1.0")]
    public class MoviesV1Controller : Controller
    {

        static List<MoviesV1> _movies = new List<MoviesV1>()
        {
            new MoviesV1(){Id = 0, MovieName = "Mission Impossible"},
            new MoviesV1(){Id = 1, MovieName = "JumanJi"}

        };
        // GET: api/<MovieV1Controller>
        [HttpGet]
        public IEnumerable<MoviesV1> Get()
        {
            return _movies;
        }

        // GET api/<MovieV1Controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MovieV1Controller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MovieV1Controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MovieV1Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
