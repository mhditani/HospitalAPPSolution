using HospitalAPP.Migrations;
using HospitalAPP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.VisualBasic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Net.Mime.MediaTypeNames;

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
        public DbSet<Prescribes> Prescribess { get; set; }
        public DbSet<Procedure> Procedures { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Stay> Stays { get; set; }
        public DbSet<Fee> Fees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Procedure>()
                .Property(p => p.Cost)
                .HasColumnType("decimal(18, 2)"); // Specify the SQL column type here

            modelBuilder.Entity<Fee>(entity =>
            {
                // Specify the SQL data types for decimal properties
                entity.Property(e => e.RoomPricePerDay).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.MedicinePrice).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.ProcedurePrice).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 2)");
            });

            // Other entity configurations can go here

            base.OnModelCreating(modelBuilder);
        }
    }
}
