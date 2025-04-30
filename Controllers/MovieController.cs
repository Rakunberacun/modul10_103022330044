using Microsoft.AspNetCore.Mvc;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace modul10_103022330044.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private static List<MovieModel> movieList = new List<MovieModel>
        {
            new MovieModel ("The Shawshank Redemption", "Frank Darabont", new List<string> {"Morgan Freeman", "Tim Robbins"}, "A banker convicted of uxoricide forms a friendship over a quarter century with a hardened convict, while maintaining his innocence and trying to remain hopeful through simple compassion." ),
            new MovieModel ("The Godfather", "Francis Ford Coppola", new List<string> {"Al Pacino", "Marlon Brando"}, "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."),
            new MovieModel ("The Dark Knight", "Christopher Nolan", new List<string> {"Christian Bale", "Heath Ledger"}, "When a menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness.")
        };
       // GET: api/<ValuesController>
       [HttpGet]
        public IEnumerable<MovieModel> Get()
        {
            return movieList;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public MovieModel Get(int id)
        {
            return movieList[id];
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] MovieModel value)
        {
            movieList.Add(value);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            movieList.RemoveAt(id);
        }
    }
}
