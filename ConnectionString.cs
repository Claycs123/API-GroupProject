namespace API_GroupProject
{
    public class ConnectionString
    {
        public string cs {get; set;}

        public ConnectionString(){
            string server = "ohunm00fjsjs1uzy.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
            string database = "y10pgaw8vs54byq1";
            string port = "3306";
            string userName = "h6kkcqezm2miglhx";
            string password = "l39o2cpxicr0671d";

            cs = $@"server = {server};userName={userName};database={database};port={port};password = {password};";
        }
    }
}