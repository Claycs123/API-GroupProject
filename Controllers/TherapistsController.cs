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
    public class TherapistsController : ControllerBase
    {
        // GET: api/Therapists
        // [HttpGet]
        // public IEnumerable<string> Get()
        // {
        //     return new string[] { "value1", "value2" };
        // }

        // GET: api/Therapists/5
        [HttpGet("{therapistid}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Therapists
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Therapists/5
        [HttpPut("{therapistid}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Therapists/5
        [HttpDelete("{therapistid}")]
        public void Delete(int id)
        {
        }
    }
}
