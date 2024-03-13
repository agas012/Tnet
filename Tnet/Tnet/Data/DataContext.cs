using Microsoft.EntityFrameworkCore;
using Tnet.Entities;

namespace Tnet.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) 
            : base(options) 
        { 
        
        }
        public DbSet<Tnet.Entities.Patient> Patients { get; set; }
        public DbSet<Tnet.Entities.ResilenciaQuestion> ResilenciaQuestions { get; set;}
        public DbSet<Tnet.Entities.AfrontamientoQuestion> AfrontamientoQuestions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>()
                .HasMany(p => p.ResilenciaQuestions) // Patient has many ResilenciaQuestions
                .WithOne(q => q.Patient) // Each ResilenciaQuestion is associated with one Patient
                .HasForeignKey(q => q.PatientId) // The foreign key in ResilenciaQuestion pointing back to Patient
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Patient>()
                .HasMany(p => p.AfrontamientoQuestions) // Patient has many AfrontamientoQuestions
                .WithOne(q => q.Patient) // Each AfrontamientoQuestion is associated with one Patient
                .HasForeignKey(q => q.PatientId) // The foreign key in AfrontamientoQuestion pointing back to Patient
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}


