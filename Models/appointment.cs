namespace API_GroupProject.Models
{
    public class appointment
    {
        public int ApptID {get; set;}
        public int PatientID {get; set;}
        public int TherapistID {get; set;}
        public string Date {get; set;}
        public string TimeSlot {get; set;}
    }
}