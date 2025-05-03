using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace mod10_103022330152.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieControll : ControllerBase
    {
        private static List<Movie> movies = new List<Movie>
        {
            new Movie ("The Shawshank Redemption", "Frank Darabont", new List<string> {"Bob Gunton", "Morgan Freeman", "Tim Robbins"}, "A banker convicted of uxoricide forms a friendship over a quarter century with a hardened convict, while maintaining his innocence and trying to remain hopeful through simple compassion."),
            new Movie ("The Godfather", "Francis Ford Coppola", new List<string> {"Marlon Brando", "Al Pacino", "James Caan"}, "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son." ),
            new Movie ("The Dark Knight", "Christopher Nolan", new List<string> {"Christian Bale", "Heath Ledger", "Aaron Eckhart"}, "When a menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness." )
        };

        // GET: api/<MovieControll>
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return movies;
        }

        // GET api/<MovieControll>/5
        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            return movies[id];
        }

        // POST api/<MovieControll>
        [HttpPost]
        public void Post([FromBody] Movie value)
        {
            movies.Add(value);
        }

        // DELETE api/<MovieControll>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            movies.RemoveAt(id);
        }
    }
}
