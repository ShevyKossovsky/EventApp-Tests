using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MyFirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IDataContext _context;

        public EventController(IDataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.EventList);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var eve= _context.EventList.Find(x => x.Id == id);

            if(eve is null)
                return NotFound();
            return Ok(eve);

        }
        // POST api/<EventController>
        [HttpPost]
        
        public void Post([FromBody] Event eve)
        {
            _context.EventList.Add(eve);
        }

        // PUT api/<EventController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Event eve)
        {
            var e = _context.EventList.Find(x => x.Id == id);
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
            var e = _context.EventList.Find(x => x.Id == id);
            if (e is null)
                return NotFound();

            _context.EventList.Remove(e);
            return Ok() ;
        }
    }
}