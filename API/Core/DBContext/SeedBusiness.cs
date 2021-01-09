using API.Business.Models;
using API.Business.Resx;
using System;
using System.Collections.Generic;

namespace API.Core.DBContext {
    public static class SeedBusiness {
        public static IEnumerable<User> GetDummyUsers() => new User[] {
            new User() {
                Id = 1,
                FirstName = "Jan",
                LastName = "Kowalski",
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now,
                Email = "Jan.Kowalski@PersonelManager.pl",
                Hash = "ECC1DD30FAE7C0D8A891953B0DCF883ECAE21ECD0576BF9E00B3A279AB351BA3",
                Role = Roles.MANAGER,
                IsActive = true,
                RequestedPasswordReset = true
            },
            new User() {
                Id = 2,
                FirstName = "Jan",
                LastName = "Nowak",
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now,
                Email = "Jan.Nowak@PersonelManager.pl",
                Hash = "ECC1DD30FAE7C0D8A891953B0DCF883ECAE21ECD0576BF9E00B3A279AB351BA3",
                Role = Roles.EMPLOYEE,
                IsActive = true,
                RequestedPasswordReset = false
            },
            new User() {
                Id = 3,
                FirstName = "Maria",
                LastName = "Niziolek",
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now,
                Email = "Maria.Niziolek@PersonelManager.pl",
                Hash = "ECC1DD30FAE7C0D8A891953B0DCF883ECAE21ECD0576BF9E00B3A279AB351BA3",
                Role = Roles.EMPLOYEE,
                IsActive = false,
                RequestedPasswordReset = true
            },
            new User() {
                Id = 4,
                FirstName = "Administrator",
                LastName = string.Empty,
                Email = "1929940@gmail.com",
                Hash = "ECC1DD30FAE7C0D8A891953B0DCF883ECAE21ECD0576BF9E00B3A279AB351BA3",
                Role = Roles.ADMIN,
                IsActive = true
            },
                
            new User() {
                Id = 5,
                FirstName = "Tester1",
                LastName = "Admin",
                Email = "admin@pm-tester.pl",
                Hash = "ECC1DD30FAE7C0D8A891953B0DCF883ECAE21ECD0576BF9E00B3A279AB351BA3",
                Role = Roles.ADMIN,
                IsActive = true
            }, 
            new User() {
                Id = 6,
                FirstName = "Tester2",
                LastName = "Manager",
                Email = "manager@pm-tester.pl",
                Hash = "ECC1DD30FAE7C0D8A891953B0DCF883ECAE21ECD0576BF9E00B3A279AB351BA3",
                Role = Roles.MANAGER,
                IsActive = true
            },    
            new User() {
                Id = 7,
                FirstName = "Tester3",
                LastName = "Employee",
                Email = "employee@pm-tester.pl",
                Hash = "ECC1DD30FAE7C0D8A891953B0DCF883ECAE21ECD0576BF9E00B3A279AB351BA3",
                Role = Roles.EMPLOYEE,
                IsActive = true
            },
                new User() {
                Id = 8,
                FirstName = "Tester4",
                LastName = "Employee",
                Email = "inactive@pm-tester.pl",
                Hash = "ECC1DD30FAE7C0D8A891953B0DCF883ECAE21ECD0576BF9E00B3A279AB351BA3",
                Role = Roles.EMPLOYEE,
                IsActive = false
            }

        };
        public static IEnumerable<ConfigurationPage> GetConfigurationPages() => new ConfigurationPage[] {
            new ConfigurationPage() {
                Id = 1,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now,
                BillingMonthStart = 26,
                BillingMonthEnd = 25,
                PercentOfAdvancesAllowed = 75,
                WarningBeforeCertificateExpires = 30,
                WarningBeforeMedicalCheckupExpires = 30,
                WarningBeforeSafetyTrainingExpires = 30,
            }
        };
    }
}

