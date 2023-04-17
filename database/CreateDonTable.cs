using MySql.Data.MySqlClient; 
using API_GroupProject.Interface;
using API_GroupProject.Models;

namespace API_GroupProject.database
{
    public class CreateDonTable : ICreateDonation
    {
        public static void CreateDonationTable()
        {
            ConnectionString2 myConnection = new ConnectionString2();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"CREATE TABLE donations(email VARCHAR(40) PRIMARY KEY, donorname TEXT, moneydonated INT, date TEXT)";

            using var cmd = new MySqlCommand(stm, con);

            cmd.ExecuteNonQuery(); 
        }

        public void CreateDonation(Donation myDonations)
        {
            ConnectionString2 myConnection = new ConnectionString2();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO donations(email, donorname, moneydonated, date) VALUES(@email, @donorname, @moneydonated, @date)";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@email", myDonations.Email);
            cmd.Parameters.AddWithValue("@donorname", myDonations.DonorName);
            cmd.Parameters.AddWithValue("@money", myDonations.MoneyDonated);
            cmd.Parameters.AddWithValue("@date", myDonations.Date);

            cmd.Prepare();

            cmd.ExecuteNonQuery();
        }
    }
}