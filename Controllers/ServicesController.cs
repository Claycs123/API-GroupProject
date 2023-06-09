using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_GroupProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        // GET: api/Services
        // [HttpGet]
        // public IEnumerable<string> Get()
        // {
        //     return new string[] { "value1", "value2" };
        // }

        // GET: api/Services/5
        [HttpGet("{serviceid}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Services
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Services/5
        [HttpPut("{serviceid}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Services/5
        [HttpDelete("{serviceid}")]
        public void Delete(int id)
        {
        }
    }
}
