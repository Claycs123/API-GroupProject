using MySql.Data.MySqlClient; 
using API_GroupProject.Interface;
using API_GroupProject.Models; 
namespace API_GroupProject.database
{
    public class GetAll : IGetAll
    {
        public List<patients> GetPatients()
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();
            var myPatients = new List<patients>();
            MySqlCommand command = new MySqlCommand("SELECT * FROM patients;", con);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                
                while (reader.Read())
                {
                    patients newPatient = new patients();
                    newPatient.PatientID = int.Parse(reader["PatientID"].ToString()); 
                    newPatient.Email = reader["Email"].ToString();
                    newPatient.Name = reader["Name"].ToString();
                    newPatient.PhoneNumber = reader["PhoneNumber"].ToString();
                    newPatient.MedicalInfo = reader["MedicalInfo"].ToString();
                    newPatient.Address = reader["Address"].ToString(); 

                    myPatients.Add(newPatient);

                }
                reader.Close();
            }
            con.Close();
            return myPatients; 
        }
    }
}