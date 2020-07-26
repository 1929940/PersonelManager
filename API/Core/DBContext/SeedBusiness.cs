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
                Hash = "1111",
                Role = Roles.MANAGER,
                IsActive = true,
                RequestedPasswordReset = false
            },
            new User() {
                Id = 2,
                FirstName = "Jan",
                LastName = "Nowak",
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now,
                Email = "Jan.Nowak@PersonelManager.pl",
                Hash = "YYY",
                Role = Roles.EMPLOYEE,
                IsActive = true,
                RequestedPasswordReset = true
            },
            new User() {
                Id = 3,
                FirstName = "Maria",
                LastName = "Niziolek",
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now,
                Email = "Maria.Niziolek@PersonelManager.pl",
                Hash = "ZZZ",
                Role = Roles.EMPLOYEE,
                IsActive = false,
                RequestedPasswordReset = false
            },
            new User() {
                Id = 4, 
                FirstName = "Administrator",
                LastName = string.Empty,
                Email = "Administrator",
                Hash = "QWER",
                Role = Roles.ADMIN,
                IsActive = true
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
                MaximumLeaveTimeInDays = 90,
                WarningBeforeLeaveReachesLimit = 60,
                WarningBeforeCertificateExpires = 30,
                WarningBeforeMedicalCheckupExpires = 30,
                WarningBeforeSafetyTrainingExpires = 30,
            }
        };
    }
}

