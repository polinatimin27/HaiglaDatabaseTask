
using HaiglaDatabaseTask.Models;
using Microsoft.EntityFrameworkCore;

namespace HaiglaDatabaseTask.Data
{
    public class HaiglaDbContext : DbContext
    {
        public HaiglaDbContext(DbContextOptions<HaiglaDbContext> options)
            : base(options)
        {
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<Examination> Examinations { get; set; }
        public DbSet<VisitExamination> VisitExaminations { get; set; }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Hospitalization> Hospitalizations { get; set; }
        public DbSet<RoomAssignment> RoomAssignments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Examination>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Doctor>()
                .HasOne<Department>()
                .WithMany()
                .HasForeignKey(d => d.DepartmentId);

            modelBuilder.Entity<Visit>()
                .HasOne<Patient>()
                .WithMany()
                .HasForeignKey(v => v.PatientId);

            modelBuilder.Entity<Visit>()
                .HasOne<Doctor>()
                .WithMany()
                .HasForeignKey(v => v.DoctorId);

            modelBuilder.Entity<VisitExamination>()
                .HasOne<Visit>()
                .WithMany()
                .HasForeignKey(e => e.VisitId);

            modelBuilder.Entity<VisitExamination>()
                .HasOne<Examination>()
                .WithMany()
                .HasForeignKey(e => e.ExaminationId);

            modelBuilder.Entity<Prescription>()
                .HasOne<Patient>()
                .WithMany()
                .HasForeignKey(p => p.PatientId);

            modelBuilder.Entity<Prescription>()
                .HasOne<Medication>()
                .WithMany()
                .HasForeignKey(p => p.MedicationId);

            modelBuilder.Entity<Hospitalization>()
                .HasOne<Patient>()
                .WithMany()
                .HasForeignKey(h => h.PatientId);

            modelBuilder.Entity<RoomAssignment>()
                .HasOne<Hospitalization>()
                .WithMany()
                .HasForeignKey(r => r.HospitalizationId);

            modelBuilder.Entity<RoomAssignment>()
                .HasOne<Room>()
                .WithMany()
                .HasForeignKey(r => r.RoomId);
        }
    }
}
