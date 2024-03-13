namespace Tnet.Services
{
    public interface IPatientService
    {
        Task<List<Entities.Patient>> GetPatients();
        Task<Entities.Patient> GetPatientbyId(int id);
        Task<Entities.Patient> AddPatient(Entities.Patient patient);
        Task<Entities.Patient> UpdatePatient(Entities.Patient patient);
        Task<Entities.Patient> DeletePatient(int id);
    }
}
