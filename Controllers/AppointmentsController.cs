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
        public appointment Post([FromBody] appointment myAppointment)
        {
            ICreateModels addAppointment = new CreateModels();
            addAppointment.CreateAppointment(myAppointment);
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
