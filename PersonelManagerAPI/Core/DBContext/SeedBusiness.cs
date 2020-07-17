﻿using API.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Core.DBContext {
    public static class SeedBusiness {
        public static IEnumerable<Credential> GetDummyCredentials() => new Credential[] {
            new Credential() {
                Id = 1,
                FirstName = "Jan",
                LastName = "Kowalski",
                CreatedBy = "Administrator",
                CreatedOn = DateTime.Now,
                Email = "Jan.Kowalski@PersonelManager.pl",
                Hash = "WWW",
                Role = 6,
                IsActive = true,
                RequestedPasswordReset = false
            },
            new Credential() {
                Id = 2,
                FirstName = "Jan",
                LastName = "Nowak",
                CreatedBy = "Administrator",
                CreatedOn = DateTime.Now,
                Email = "Jan.Nowak@PersonelManager.pl",
                Hash = "YYY",
                Role = 2,
                IsActive = true,
                RequestedPasswordReset = true
            },
            new Credential() {
                Id = 3,
                FirstName = "Maria",
                LastName = "Niziolek",
                CreatedBy = "Administrator",
                CreatedOn = DateTime.Now,
                Email = "Maria.Niziolek@PersonelManager.pl",
                Hash = "ZZZ",
                Role = 2,
                IsActive = false,
                RequestedPasswordReset = false
            },
            new Credential() {
                Id = 4, 
                FirstName = "Administrator",
                LastName = string.Empty,
                Email = string.Empty,
                Hash = "pol<>",
                Role = 14,
                IsActive = true
            }

        };
        public static IEnumerable<ConfigurationPage> GetConfigurationPages() => new ConfigurationPage[] {
            new ConfigurationPage() {
                Id = 1,
                CreatedBy = "Administrator",
                CreatedOn = DateTime.Now,
                BillingMonthStart = 26,
                BillingMonthEnd = 25,
                PercentOfAdvancesAllowed = 75,
                MaximumLeaveTimeInDays = 90,
                WarningBeforeLeaveReachesLimit = 60,
                WarningBeforeCertificateExpires = 30,
                WarningBeforeMedicalCheckupExpires = 30,
                WarningBeforePassportExpires = 30,
                WarningBeforePermitExpires = 30,
                WarningBeforeSafetyTrainingExpires = 30,
                WarningBeforeVisaExpires = 30
            }
        };
    }
}

