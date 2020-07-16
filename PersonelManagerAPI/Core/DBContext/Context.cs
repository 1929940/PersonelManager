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
            modelBuilder.Entity<Credential>().HasData(
                    new Credential() {
                        Id = 1,
                        CreatedBy = "Administrator",
                        CreatedOn = DateTime.Now,
                        Email = "Kowalski@wp.pl",
                        FirstName = "Jan",
                        LastName = "Kowalski",
                        Hash = "WzX2#",
                        IsActive = true
                    }
                );


            //base.OnModelCreating(modelBuilder);

        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Contract> Contract { get; set; }
        public DbSet<Credential> Credential { get; set; }
        public DbSet<ConfigurationPage> ConfigurationPage { get; set; }



    }
}
