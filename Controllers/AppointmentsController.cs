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
    public class AppointmentsController : ControllerBase
    {
        // GET: api/Appointments
        // [HttpGet]
        // public IEnumerable<string> Get()
        // {
        //     return new string[] { "value1", "value2" };
        // }

        // GET: api/Appointments/5
        [HttpGet(Name="GetAppointments")]
        public List<appointment> Get()
        {
            List<appointment> myAppointments = new GetAll().GetAppointments();
            return myAppointments; 
        }

        // POST: api/Appointments
        [HttpPost]
        public patientappointment Post([FromBody] patientappointment myAppointment)
        {
            patients newPatient = new patients{PatientID=myAppointment.PatientID,Email=myAppointment.Email,Name=myAppointment.Name,Address=myAppointment.Address,MedicalInfo=myAppointment.MedicalInfo,PhoneNumber=myAppointment.PhoneNumber};
            ICreateModels addPatient = new CreateModels();
            addPatient.CreatePatient(newPatient);
            patients tempPatient = new GetAll().GetPatient();
            System.Console.WriteLine("hey");
            appointment newAppt = new appointment{ApptID=myAppointment.ApptID,PatientID=tempPatient.PatientID,TheraName=myAppointment.TheraName,ServName=myAppointment.ServName,Dates=myAppointment.Dates,TimeSlot=myAppointment.TimeSlot};

            ICreateModels addAppointment = new CreateModels();
            addAppointment.CreateAppointment(newAppt);
            return myAppointment; 
        }

        // PUT: api/Appointments/5
        [HttpPut("{appointmentId}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Appointments/5
        [HttpDelete("{appointmentId}")]
        public void Delete(int id)
        {
        }
    }
}
