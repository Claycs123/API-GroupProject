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
    public class PatientsController : ControllerBase
    {
        // GET: api/Patients
        // [HttpGet]
        // public IEnumerable<string> Get()
        // {
        //     return new string[] { "value1", "value2" };
        // }

        // GET: api/Patients/5
        [HttpGet("{patientid}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Patients
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Patients/5
        [HttpPut("{patientid}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Patients/5
        [HttpDelete("{patientid}")]
        public void Delete(int id)
        {
        }
    }
}
