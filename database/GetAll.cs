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


        public patients GetPatient()
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();
            var myPatient = new patients();
            MySqlCommand command = new MySqlCommand("SELECT * FROM patients ORDER BY PatientID DESC LIMIT 1;", con);
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

                    myPatient = newPatient;

                }
                reader.Close();
            }
            con.Close();
            return myPatient; 
        }    



        public List<appointment> GetAppointments()
        {
            ConnectionString myConnection = new ConnectionString();
                string cs = myConnection.cs;
                using var con = new MySqlConnection(cs);
                con.Open();
                var myAppointments = new List<appointment>();
                MySqlCommand command = new MySqlCommand("SELECT * FROM appointment ORDER BY Dates ASC;", con);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    
                    while (reader.Read())
                    {
                        appointment newAppointment = new appointment();
                        newAppointment.ApptID = int.Parse(reader["ApptID"].ToString()); 
                        newAppointment.PatientID = int.Parse(reader["PatientID"].ToString());
                        newAppointment.TheraName = reader["TheraName"].ToString();
                        newAppointment.ServName = reader["ServName"].ToString();
                        newAppointment.Dates = reader["Dates"].ToString();
                        newAppointment.TimeSlot = reader["TimeSlot"].ToString(); 

                        myAppointments.Add(newAppointment);

                    }
                    reader.Close();
                }
                con.Close();
                return myAppointments; 
        }
    }
    

}