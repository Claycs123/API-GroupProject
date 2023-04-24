using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using API_GroupProject.Models;
using API_GroupProject.Interface;
using API_GroupProject.database; 

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
        [HttpGet(Name="GetPatients")]
        // [EnableCors("")]
        public List<patients> Get()
        {
            List<patients> myPatients = new GetAll().GetPatients();
            return myPatients; 
            // List<patients> myPatients = new List<patients>();
            // patients patient = new patients(){PatientID = 1, Email = "hey", Name = "McLean", PhoneNumber = "205-232-2321", MedicalInfo = "no", Address = "325ElmsStreet"};
            // myPatients.Add(patient);
            // return myPatients;

        }

        // POST: api/Patients/5
        [HttpPost]
        public patients Post([FromBody] patients myPatient)
        {
            ICreateModels addPatient = new CreateModels();
            addPatient.CreatePatient(myPatient);
            return myPatient;
        }

        // PUT: api/Patients
        [HttpPut("{PatientID}")]
        public void Put(int PatientID, [FromBody] patients myPatient)
        {
            System.Console.WriteLine(PatientID);
            ICreateModels editinpatient = new CreateModels();
            editinpatient.EditsPatient(PatientID, myPatient);
            System.Console.WriteLine(PatientID);
        }

        // DELETE: api/Patients/5
        [HttpDelete("{patientid}")]
        public void Delete(int id)
        {
        }
    }
}
