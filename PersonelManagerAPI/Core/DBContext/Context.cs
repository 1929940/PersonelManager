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
            modelBuilder.Entity<Credential>().HasData(SeedBusiness.GetDummyCredentials());
            modelBuilder.Entity<ConfigurationPage>().HasData(SeedBusiness.GetConfigurationPages());

            modelBuilder.Entity<Employee>().HasData(SeedHR.GetDummyEmployees());
            modelBuilder.Entity<Location>().HasData(SeedHR.GetDummyLocation());
            modelBuilder.Entity<Foreman>().HasData(SeedHR.GetDummyForemen());
            modelBuilder.Entity<EmployeeAddress>().HasData(SeedHR.GetDummyEmployeeAddresses());
            modelBuilder.Entity<EmployeeHistory>().HasData(SeedHR.GetDummyEmployeeHistories());
            modelBuilder.Entity<MedicalCheckup>().HasData(SeedHR.GetDummyMedicalCheckups());
            modelBuilder.Entity<SafetyTraining>().HasData(SeedHR.GetDummySafetyTrainings());




            //base.OnModelCreating(modelBuilder);

        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Contract> Contract { get; set; }
        public DbSet<Credential> Credential { get; set; }
        public DbSet<ConfigurationPage> ConfigurationPage { get; set; }



    }
}
