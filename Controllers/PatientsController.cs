using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API_GroupProject.Models;

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
        public List<patients> Get()
        {
            List<patients> myPatients = new List<patients>();
            patients patient = new patients(){PatientID = 1, Email = "hey", Name = "McLean", PhoneNumber = "205-232-2321", MedicalInfo = "no", Address = "325ElmsStreet"};
            myPatients.Add(patient);
            return myPatients;

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
