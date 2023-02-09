using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APITutorial1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FriendController : ControllerBase
    {
        // GET: api/<FriendController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<FriendController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FriendController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FriendController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FriendController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpGet]
        public List<Friend> get()
        {
            List<Friend> friends = new List<Friend>();
            friends.Add(new Friend("Kindson", "Munonye", "Budapest", DateTime.Today));
            friends.Add(new Friend("Oleander", "Yuba", "Nigeria", DateTime.Today));
            friends.Add(new Friend("Saffron", "Lawrence", "Lagos", DateTime.Today));
            friends.Add(new Friend("Jadon", "Munonye", "Asaba", DateTime.Today));
            friends.Add(new Friend("Solace", "Okeke", "Oko", DateTime.Today));

            return friends;
        }

    }
}
