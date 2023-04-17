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
    public class DonationsController : ControllerBase
    {

        // GET: api/Donations/5
        [HttpGet(Name="GetDonations")]
        // [EnableCors("")]
        public List<Donation> Get()
        {
            GetDonations myDonations = new GetDonations();
            return myDonations.GetAllDonations();
        }

        // POST: api/Donations/5
        [HttpPost]
        public void Post([FromBody] Donation value)
        {
            CreateDonTable myDonations = new CreateDonTable();
            myDonations.CreateDonation(value);
        }

        // PUT: api/Donations/5
        // [HttpPut("{id}/edit")]
        // public void Put(int PatientID, [FromBody] patients myPatient)
        // {
        // }

        // DELETE: api/Donations/5
        // [HttpDelete("{patientid}")]
        // public void Delete(int id)
        // {
        // }
    }
}