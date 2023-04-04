using MySql.Data.MySqlClient; 
using API_GroupProject.Interface;
namespace API_GroupProject.database
{
    public class createtables : Icreatetables
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

        public static void CreateAppointTable()
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"CREATE TABLE appointment(ApptID INTEGER PRIMARY KEY AUTO_INCREMENT, PatientID INTEGER FOREIGN KEY AUTO_INCREMENT, TherapistID INTEGER FOREIGN KEY AUTO_INCREMENT, Name TEXT FOREIGN KEY, Date TEXT, TimeSlot Text)";

            using var cmd = new MySqlCommand(stm, con);

            cmd.ExecuteNonQuery(); 
        }

        public static void CreateServTable()
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"CREATE TABLE service(ServiceID INTEGER PRIMARY KEY AUTO_INCREMENT, Name TEXT, Description TEXT, Price TEXT)";

            using var cmd = new MySqlCommand(stm, con);

            cmd.ExecuteNonQuery(); 
        }

        public static void CreateTheraTable()
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"CREATE TABLE therapist(TherapistID INTEGER PRIMARY KEY AUTO_INCREMENT, Email TEXT, Name TEXT, PhoneNumber TEXT)";

            using var cmd = new MySqlCommand(stm, con);

            cmd.ExecuteNonQuery(); 
        }


    }
}