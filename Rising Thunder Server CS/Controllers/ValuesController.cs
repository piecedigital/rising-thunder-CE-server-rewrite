using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Rising_Thunder_Server_CS.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RyzthnController : ControllerBase
    {
        // GET ryzthn
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET ryzthn/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST ryzthn
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT ryzthn/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE ryzthn/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
