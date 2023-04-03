namespace API_GroupProject.database
{
    public class createtables
    {
        public static void CreatePatiTable()
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"CREATE TABLE patients(PatientID INTEGER PRIMARY KEY AUTO_INCREMENT, Email TEXT, Name TEXT, PhoneNumber TEXT, MedicalInfo Text, Address Text)";

            using var cmd = new MySqlCommand(stm, con);

            cmd.ExecuteNonQuery(); 
        }
    }
}