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

        public Donation CreateDonation(Donation myDonation)
        {
            ConnectionString2 myConnection = new ConnectionString2();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO donations(email, donorname, moneydonated, date) VALUES(@email, @donorname, @moneydonated, @date)";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@email", myDonation.Email);
            cmd.Parameters.AddWithValue("@donorname", myDonation.DonorName);
            cmd.Parameters.AddWithValue("@moneydonated", myDonation.MoneyDonated);
            cmd.Parameters.AddWithValue("@date", myDonation.Date);

            cmd.Prepare();

            cmd.ExecuteNonQuery();

            return myDonation; 
        }
    }
}