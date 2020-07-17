using System;
using Microsoft.EntityFrameworkCore;
using API.HR.Models;
using API.Payroll.Models;
using API.Business.Models;

namespace API.Core.DBContext {
    public class Context : DbContext {
        public Context(DbContextOptions<Context> options) : base(options) {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<User>().HasData(SeedBusiness.GetDummyUsers());
            modelBuilder.Entity<ConfigurationPage>().HasData(SeedBusiness.GetConfigurationPages());

            modelBuilder.Entity<Employee>().HasData(SeedHR.GetDummyEmployees());
            modelBuilder.Entity<Location>().HasData(SeedHR.GetDummyLocation());
            modelBuilder.Entity<Foreman>().HasData(SeedHR.GetDummyForemen());
            modelBuilder.Entity<EmployeeAddress>().HasData(SeedHR.GetDummyEmployeeAddresses());
            modelBuilder.Entity<EmployeeHistory>().HasData(SeedHR.GetDummyEmployeeHistories());
            modelBuilder.Entity<MedicalCheckup>().HasData(SeedHR.GetDummyMedicalCheckups());
            modelBuilder.Entity<SafetyTraining>().HasData(SeedHR.GetDummySafetyTrainings());
            modelBuilder.Entity<Certificate>().HasData(SeedHR.GetDummyCertificates());
            modelBuilder.Entity<Passport>().HasData(SeedHR.GetDummyPassports());
            modelBuilder.Entity<Visa>().HasData(SeedHR.GetDummyVisas());
            modelBuilder.Entity<Permit>().HasData(SeedHR.GetDummyPermits());
            modelBuilder.Entity<Leave>().HasData(SeedHR.GetDummyLeaves());

            modelBuilder.Entity<Contract>().HasData(SeedPayroll.GetDummyContracts());
            modelBuilder.Entity<Advances>().HasData(SeedPayroll.GetDummyAdvances());
            modelBuilder.Entity<Payment>().HasData(SeedPayroll.GetDummyPayment());
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ConfigurationPage> ConfigurationPage { get; set; }

    }
}
