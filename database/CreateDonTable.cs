using API_GroupProject.Interface;
using API_GroupProject.Models;

namespace API_GroupProject.database
{
    public class CreateDonTable
    {
        public static void CreateDonationTable()
        {
            ConnectionString2 myConnection = new ConnectionString2();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"CREATE TABLE service(email VARCHAR(40) PRIMARY KEY, donorname TEXT, moneydonated DOUBLE, date TEXT)";

            using var cmd = new MySqlCommand(stm, con);

            cmd.ExecuteNonQuery(); 
        }
    }
}