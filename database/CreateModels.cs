using MySql.Data.MySqlClient; 
using API_GroupProject.Interface;
using API_GroupProject.Models;
namespace API_GroupProject.database
{
    public class CreateModels : ICreateModels
    {
        public patients CreatePatient(patients myPatient)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO patients(Email, Name, PhoneNumber, MedicalInfo, Address) VALUES(@Email, @Name, @PhoneNumber, @MedicalInfo, @Address)";

            using var cmd = new MySqlCommand(stm,con);

            cmd.Parameters.AddWithValue("@Email", myPatient.Email); 
            cmd.Parameters.AddWithValue("@Name", myPatient.Name);
            cmd.Parameters.AddWithValue("@PhoneNumber", myPatient.PhoneNumber);
            cmd.Parameters.AddWithValue("@MedicalInfo", myPatient.MedicalInfo);
            cmd.Parameters.AddWithValue("@Address", myPatient.Address); 

            cmd.Prepare();

            cmd.ExecuteNonQuery(); 

            return myPatient;
        }

        public void EditPatient(int PatientID, patients myPatient)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = $@"UPDATE patients SET Email = @Email, Name = @Name, PhoneNumber = @PhoneNumber, MedicalInfo = @MedicalInfo, Address = @Address WHERE PatientID = @PatientID";
            using var cmd = new MySqlCommand(stm,con);
            cmd.Parameters.AddWithValue("@PatientID", PatientID);
            cmd.Parameters.AddWithValue("@Email", myPatient.Email); 
            cmd.Parameters.AddWithValue("@Name", myPatient.Name);
            cmd.Parameters.AddWithValue("@PhoneNumber", myPatient.PhoneNumber);
            cmd.Parameters.AddWithValue("@MedicalInfo", myPatient.MedicalInfo); 
            cmd.Parameters.AddWithValue("@Address", myPatient.Address);

            cmd.Prepare();

            cmd.ExecuteNonQuery(); 
        }
    }
}