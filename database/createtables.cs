using MySql.Data.MySqlClient; 
using API_GroupProject.Interface;
using API_GroupProject.Models;
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

            string stm = @"CREATE TABLE appointment(ApptID INTEGER PRIMARY KEY AUTO_INCREMENT, Dates TEXT, TimeSlot TEXT, ServName VARCHAR(255), PatientID INTEGER, TheraName VARCHAR(255),

                            FOREIGN KEY (ServName)
                            REFERENCES service (ServName),
                            
                            FOREIGN KEY (PatientID)
                            REFERENCES patients (PatientID),
                            
                            FOREIGN KEY (TheraName)
                            REFERENCES therapist (TheraName)
                        );";

            using var cmd = new MySqlCommand(stm, con);

            cmd.ExecuteNonQuery(); 
        }

        public static void CreateServTable()
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"CREATE TABLE service(ServName VARCHAR(255) PRIMARY KEY, description TEXT, price DOUBLE)";

            using var cmd = new MySqlCommand(stm, con);

            cmd.ExecuteNonQuery(); 
        }

        public static void CreateTheraTable()
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"CREATE TABLE therapist(TheraName VARCHAR(255) PRIMARY KEY, email TEXT, phonenumber TEXT)";

            using var cmd = new MySqlCommand(stm, con);

            cmd.ExecuteNonQuery(); 
        }

        // public patients CreatePatient(patients myPatient)
        // {
        //     ConnectionString myConnection = new ConnectionString();
        //     string cs = myConnection.cs;
        //     using var con = new MySqlConnection(cs);
        //     con.Open();

        //     string stm = @"INSERT INTO patients(Email, Name, PhoneNumber, MedicalInfo, Address) VALUES(@Email, @Name, @PhoneNumber, @MedicalInfo, @Address)";

        //     using var cmd = new MySqlCommand(stm,con);

        //     cmd.Parameters.AddWithValue("@Email", myPatient.Email); 
        //     cmd.Parameters.AddWithValue("@Name", myPatient.Name);
        //     cmd.Parameters.AddWithValue("@PhoneNumber", myPatient.PhoneNumber);
        //     cmd.Parameters.AddWithValue("@MedicalInfo", myPatient.MedicalInfo);
        //     cmd.Parameters.AddWithValue("@Address", myPatient.Address); 

        //     cmd.Prepare();

        //     cmd.ExecuteNonQuery(); 

        //     return myPatient;
        // }


    }
}