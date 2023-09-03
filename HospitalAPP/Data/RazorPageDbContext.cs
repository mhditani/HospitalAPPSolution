using HospitalAPP.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalAPP.Data
{
    public class RazorPageDbContext : DbContext
    {
        public RazorPageDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Physician> Physicians { get; set; }
        public DbSet<AffiliatedWith> AffiliatedWiths { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Prescribes> Prescribess { get; set;}
        public DbSet<Procedure> Procedures { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Procedure>()
                .Property(p => p.Cost)
                .HasColumnType("decimal(18, 2)"); // Specify the SQL column type here

            // Other entity configurations can go here

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Room> Rooms { get; set; }
        public  DbSet<Stay> Stays { get; set; }
    }
}
