using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_GroupProject.database
{
    public class GetDonations
    {
        public List<Donation> GetAllDonations()
        {
            List<Donation> MyDonations = new List<Donation>();

            ConnectionString2 myConnection = new ConnectionString2();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"SELECT * FROM donations";
            
            using var cmd = new MySqlCommand(stm, con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read()) {
                Donation readDonations = new Donation() {Email = rdr.GetString(0), DonorName = rdr.GetString(1), MoneyDonated = rdr.GetInt(2), Date = rdr.GetString(3)};
                MyDonations.Add(readDonations);
            }

            return MyDonations;
        }
    }
}