namespace API_GroupProject
{
    public class ConnectionString2
    {
        public string cs {get; set;}

        public ConnectionString2(){
            string server = "exbodcemtop76rnz.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
            string database = "ziiqi5v0wyllsyma";
            string port = "3306";
            string userName = "b2adum5i0onyjgsh";
            string password = "o1tdphbseqsynkkb";

            cs = $@"server = {server};userName={userName};database={database};port={port};password = {password};";
        }
    }
}