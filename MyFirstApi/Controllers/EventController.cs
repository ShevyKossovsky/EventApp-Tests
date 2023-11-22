using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyFirstApi;

namespace MyFirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        static DataContext context = new DataContext();

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(context.EventsList);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var eve= context.EventsList.Find(x => x.Id == id);

            if(eve is null)
                return NotFound();
            return Ok(eve);

        }
        // POST api/<EventController>
        [HttpPost]
        
        public void Post([FromBody] Event eve)
        {
            context.EventsList.Add(eve);
        }

        // PUT api/<EventController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Event eve)
        {
            var e = context.EventsList.Find(x => x.Id == id);
            if(e is  null)
                return NotFound();
                    e.Title = eve.Title;
                    e.Start = eve.Start;
                    e.End = eve.End;
                    return Ok() ;                       
        }

        // DELETE api/<EventController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var e = context.EventsList.Find(x => x.Id == id);
            if (e is null)
                return NotFound();
            
            context.EventsList.Remove(e);
            return Ok() ;
        }
    }
}