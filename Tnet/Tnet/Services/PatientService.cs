using Microsoft.EntityFrameworkCore;
using Tnet.Entities;

namespace Tnet.Services
{
    public class PatientService : IPatientService
    {
        private readonly Data.DataContext _context;
        public PatientService(Data.DataContext context)
        {
            _context = context;
        }

        public async Task<Patient> AddPatient(Patient patient)
        {
            _context.Patients.Add(patient);
            await _context.SaveChangesAsync();
            return patient;
        }

        public async Task<Patient> GetPatientbyId(int id)
        {
            var patient = await _context.Patients
                                        .Include(x => x.ResilenciaQuestions)
                                        .Include(x => x.AfrontamientoQuestions)
                                        .FirstOrDefaultAsync(x => x.Id == id);
            if (patient == null) 
            {
                throw new Exception("Patient not found");
            }
            else
            {
                return patient;
            }
        }

        public async Task<List<Entities.Patient>> GetPatients()
        {
            var patient = await _context.Patients
                .ToListAsync();
            return patient;
        }

        public async Task<Patient> UpdatePatient(Patient patient)
        {
            _context.Patients.Update(patient);
            await _context.SaveChangesAsync();
            return patient;
        }

        public async Task<Patient> DeletePatient(int id)
        {
            var patient = await _context.Patients
                                        //.Include(p => p.ResilenciaQuestions) // This include is not necessary for the delete but shown for completeness
                                        //.Include(x => x.AfrontamientoQuestions)
                                        .FirstOrDefaultAsync(x => x.Id == id);
            if (patient == null)
            {
                throw new Exception("Patient not found");
            }
            else
            {
                _context.Patients.Remove(patient);
                await _context.SaveChangesAsync();
                return patient;
            }
        }
    }
}
