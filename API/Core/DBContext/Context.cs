using Microsoft.EntityFrameworkCore;
using API.HR.Models;
using API.Payroll.Models;
using API.Business.Models;

namespace API.Core.DBContext {
    public class Context : DbContext {
        public Context(DbContextOptions<Context> options) : base(options) {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<User>().HasData(SeedBusiness.GetDummyUsers());
            modelBuilder.Entity<ConfigurationPage>().HasData(SeedBusiness.GetConfigurationPages());

            modelBuilder.Entity<Employee>().HasData(SeedHR.GetDummyEmployees());
            modelBuilder.Entity<Location>().HasData(SeedHR.GetDummyLocation());
            modelBuilder.Entity<Foreman>().HasData(SeedHR.GetDummyForemen());
            modelBuilder.Entity<EmployeeHistory>().HasData(SeedHR.GetDummyEmployeeHistories());
            modelBuilder.Entity<MedicalCheckup>().HasData(SeedHR.GetDummyMedicalCheckups());
            modelBuilder.Entity<SafetyTraining>().HasData(SeedHR.GetDummySafetyTrainings());
            modelBuilder.Entity<Certificate>().HasData(SeedHR.GetDummyCertificates());
            modelBuilder.Entity<Passport>().HasData(SeedHR.GetDummyPassports());
            modelBuilder.Entity<Visa>().HasData(SeedHR.GetDummyVisas());
            modelBuilder.Entity<Permit>().HasData(SeedHR.GetDummyPermits());
            modelBuilder.Entity<Leave>().HasData(SeedHR.GetDummyLeaves());

            modelBuilder.Entity<Contract>().HasData(SeedPayroll.GetDummyContracts());
            modelBuilder.Entity<Advance>().HasData(SeedPayroll.GetDummyAdvances());
            modelBuilder.Entity<Payment>().HasData(SeedPayroll.GetDummyPayment());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<ConfigurationPage> ConfigurationPage { get; set; }


        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeHistory> EmployeesHistory { get; set; }

        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Foreman> Foremen { get; set; }
        public DbSet<Leave> Leaves { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<MedicalCheckup> MedicalCheckups { get; set; }
        public DbSet<SafetyTraining> SafetyTrainings { get; set; }

        public DbSet<Passport> Passports { get; set; }
        public DbSet<Permit> Permits { get; set; }
        public DbSet<Visa> Visas { get; set; }


        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Advance> Advances { get; set; }

    }
}
