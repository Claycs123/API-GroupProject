using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_GroupProject.Models;

namespace API_GroupProject.Interface
{
    public interface IGetDonations
    {
        public List<Donation> GetAllDonations();
    }
}