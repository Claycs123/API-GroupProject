using API_GroupProject.Models;
namespace API_GroupProject.Interface
{
    public interface ICreateModels
    {
       public patients CreatePatient(patients myPatient); 
       public void EditsPatient(int PatientID, patients myPatient);

        public appointment CreateAppointment(appointment myAppointment); 
    }
}