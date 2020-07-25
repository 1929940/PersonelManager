﻿using API.Core.Logic;
using API.Payroll.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace API.Core.DBContext {
    public static class SeedPayroll {

        public static IEnumerable<Contract> GetDummyContracts() => new Contract[] {
            new Contract() {
                Id = 1,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddMonths(-6).FirstDayOfTheMonth().AddDays(-10),
                EmployeeId = 1,
                ContractSubject = "Montaż obarierowania ochronnego na jednostce NB230",
                HourlySalary = 20,
                Value = 4000,
                TaxPercent = 14.0m,
                Number = $"1/{DateTime.Now.AddMonths(-6).ToString("MM")}/2020",
                Title = $"Umowa za {DateTime.Now.AddMonths(-6).GetMonthNamePL()}",
                ValidFrom = DateTime.Now.AddMonths(-6).FirstDayOfTheMonth(),
                ValidTo = DateTime.Now.AddMonths(-6).LastDayOfTheMonth(),
                IsRealized = true,
            },
            //Month -5
            new Contract() {
                Id = 2,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddMonths(-5).FirstDayOfTheMonth().AddDays(-10),
                EmployeeId = 1,
                ContractSubject = "Przyspawanie wręgów 11-201 na jednostce WZ211",
                HourlySalary = 25,
                Value = 5000,
                TaxPercent = 14.0m,
                Number = $"1/{DateTime.Now.AddMonths(-5).ToString("MM")}/2020",
                Title = $"Umowa za {DateTime.Now.AddMonths(-5).GetMonthNamePL()}",
                ValidFrom = DateTime.Now.AddMonths(-5).FirstDayOfTheMonth(),
                ValidTo = DateTime.Now.AddMonths(-5).LastDayOfTheMonth(),
                IsRealized = true,
            },
            new Contract() {
                Id = 3,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddMonths(-5).FirstDayOfTheMonth().AddDays(-10),
                EmployeeId = 2,
                ContractSubject = "Oszlifowanie trapa na jednostce NB230",
                HourlySalary = 15,
                Value = 3000,
                TaxPercent = 14.0m,
                Number = $"2/{DateTime.Now.AddMonths(-5).ToString("MM")}/2020",
                Title = $"Umowa za {DateTime.Now.AddMonths(-5).GetMonthNamePL()}",
                ValidFrom = DateTime.Now.AddMonths(-5).FirstDayOfTheMonth(),
                ValidTo = DateTime.Now.AddMonths(-5).LastDayOfTheMonth(),
                IsRealized = true,
            },
            new Contract() {
                Id = 4,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddMonths(-5).FirstDayOfTheMonth().AddDays(-10),
                EmployeeId = 3,
                ContractSubject = "Oszlifowanie zbiornika ZL15",
                HourlySalary = 15,
                Value = 3000,
                TaxPercent = 14.0m,
                Number = $"3/{DateTime.Now.AddMonths(-5).ToString("MM")}/2020",
                Title = $"Umowa za {DateTime.Now.AddMonths(-5).GetMonthNamePL()}",
                ValidFrom = DateTime.Now.AddMonths(-5).FirstDayOfTheMonth(),
                ValidTo = DateTime.Now.AddMonths(-5).LastDayOfTheMonth(),
                IsRealized = true,
            },
            // Month -4
            new Contract() {
                Id = 5,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddMonths(-4).FirstDayOfTheMonth().AddDays(-10),
                EmployeeId = 1,
                ContractSubject = "Przyspawanie wręgów 201-421 na jednostce WZ211",
                HourlySalary = 25,
                Value = 5000,
                TaxPercent = 14.0m,
                Number = $"1/{DateTime.Now.AddMonths(-4).ToString("MM")}/2020",
                Title = $"Umowa za {DateTime.Now.AddMonths(-4).GetMonthNamePL()}",
                ValidFrom = DateTime.Now.AddMonths(-4).FirstDayOfTheMonth(),
                ValidTo = DateTime.Now.AddMonths(-4).LastDayOfTheMonth(),
                IsRealized = true,
            },
            new Contract() {
                Id = 6,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddMonths(-4).FirstDayOfTheMonth().AddDays(-10),
                EmployeeId = 3,
                ContractSubject = "Oszlifowanie schodów na jednostce NB230",
                HourlySalary = 15,
                Value = 3000,
                TaxPercent = 14.0m,
                Number = $"2/{DateTime.Now.AddMonths(-4).ToString("MM")}/2020",
                Title = $"Umowa za {DateTime.Now.AddMonths(-4).GetMonthNamePL()}",
                ValidFrom = DateTime.Now.AddMonths(-4).FirstDayOfTheMonth(),
                ValidTo = DateTime.Now.AddMonths(-4).LastDayOfTheMonth(),
                IsRealized = true,
            },
            new Contract() {
                Id = 7,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddMonths(-4).FirstDayOfTheMonth().AddDays(-10),
                EmployeeId = 4,
                ContractSubject = "Wypalenie otworu technicznego 23 na jednostce NB230",
                HourlySalary = 20,
                Value = 4000,
                TaxPercent = 14.0m,
                Number = $"3/{DateTime.Now.AddMonths(-4).ToString("MM")}/2020",
                Title = $"Umowa za {DateTime.Now.AddMonths(-4).GetMonthNamePL()}",
                ValidFrom = DateTime.Now.AddMonths(-4).FirstDayOfTheMonth(),
                ValidTo = DateTime.Now.AddMonths(-4).LastDayOfTheMonth(),
                IsRealized = true,
            },
            //month 3
                new Contract() {
                Id = 8,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddMonths(-3).FirstDayOfTheMonth().AddDays(-10),
                EmployeeId = 1,
                ContractSubject = "Przyspawanie haków technocznych do płatu P11",
                HourlySalary = 25,
                Value = 5000,
                TaxPercent = 14.0m,
                Number = $"1/{DateTime.Now.AddMonths(-3).ToString("MM")}/2020",
                Title = $"Umowa za {DateTime.Now.AddMonths(-3).GetMonthNamePL()}",
                ValidFrom = DateTime.Now.AddMonths(-3).FirstDayOfTheMonth(),
                ValidTo = DateTime.Now.AddMonths(-3).LastDayOfTheMonth(),
                IsRealized = true,
            },
            new Contract() {
                Id = 9,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddMonths(-3).FirstDayOfTheMonth().AddDays(-10),
                EmployeeId = 3,
                ContractSubject = "Oszlifowanie wręgów 11-201 na jednostce NB230",
                HourlySalary = 15,
                Value = 3000,
                TaxPercent = 14.0m,
                Number = $"2/{DateTime.Now.AddMonths(-3).ToString("MM")}/2020",
                Title = $"Umowa za {DateTime.Now.AddMonths(-3).GetMonthNamePL()}",
                ValidFrom = DateTime.Now.AddMonths(-3).FirstDayOfTheMonth(),
                ValidTo = DateTime.Now.AddMonths(-3).LastDayOfTheMonth(),
                IsRealized = true,
            },
            new Contract() {
                Id = 10,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddMonths(-3).FirstDayOfTheMonth().AddDays(-10),
                EmployeeId = 4,
                ContractSubject = "Montaż trapu na jednostce NB230",
                HourlySalary = 20,
                Value = 4000,
                TaxPercent = 14.0m,
                Number = $"3/{DateTime.Now.AddMonths(-3).ToString("MM")}/2020",
                Title = $"Umowa za {DateTime.Now.AddMonths(-3).GetMonthNamePL()}",
                ValidFrom = DateTime.Now.AddMonths(-3).FirstDayOfTheMonth(),
                ValidTo = DateTime.Now.AddMonths(-3).LastDayOfTheMonth(),
                IsRealized = true,
            },
            //Month 2
            new Contract() {
                Id = 11,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddMonths(-2).FirstDayOfTheMonth().AddDays(-10),
                EmployeeId = 1,
                //PaymentId = 1,
                ContractSubject = "Przyspawanie haków technocznych do płatu P12",
                HourlySalary = 25,
                Value = 5000,
                TaxPercent = 14.0m,
                Number = $"1/{DateTime.Now.AddMonths(-2).ToString("MM")}/2020",
                Title = $"Umowa za {DateTime.Now.AddMonths(-2).GetMonthNamePL()}",
                ValidFrom = DateTime.Now.AddMonths(-2).FirstDayOfTheMonth(),
                ValidTo = DateTime.Now.AddMonths(-2).LastDayOfTheMonth(),
                IsRealized = true,
            },
            new Contract() {
                Id = 12,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddMonths(-2).FirstDayOfTheMonth().AddDays(-10),
                EmployeeId = 2,
                //PaymentId = 2,
                ContractSubject = "Oszlifowanie wręgów 11-201 na jednostce NB231",
                HourlySalary = 15,
                Value = 3000,
                TaxPercent = 14.0m,
                Number = $"2/{DateTime.Now.AddMonths(-2).ToString("MM")}/2020",
                Title = $"Umowa za {DateTime.Now.AddMonths(-2).GetMonthNamePL()}",
                ValidFrom = DateTime.Now.AddMonths(-2).FirstDayOfTheMonth(),
                ValidTo = DateTime.Now.AddMonths(-2).LastDayOfTheMonth(),
                IsRealized = true,
            },
            new Contract() {
                Id = 13,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddMonths(-2).FirstDayOfTheMonth().AddDays(-10),
                EmployeeId = 4,
                //PaymentId = 3,
                ContractSubject = "Montaż trapu na jednostce NB231",
                HourlySalary = 20,
                Value = 4000,
                TaxPercent = 14.0m,
                Number = $"3/{DateTime.Now.AddMonths(-2).ToString("MM")}/2020",
                Title = $"Umowa za {DateTime.Now.AddMonths(-2).GetMonthNamePL()}",
                ValidFrom = DateTime.Now.AddMonths(-2).FirstDayOfTheMonth(),
                ValidTo = DateTime.Now.AddMonths(-2).LastDayOfTheMonth(),
                IsRealized = true,
            },
            //Month 1
            new Contract() {
                Id = 14,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddMonths(-1).FirstDayOfTheMonth().AddDays(-10),
                EmployeeId = 1,
                //PaymentId = 4,
                ContractSubject = "Przyspawanie sekcji okętowych NW23-NW24",
                HourlySalary = 25,
                Value = 5000,
                TaxPercent = 14.0m,
                Number = $"1/{DateTime.Now.AddMonths(-1).ToString("MM")}/2020",
                Title = $"Umowa za {DateTime.Now.AddMonths(-1).GetMonthNamePL()}",
                ValidFrom = DateTime.Now.AddMonths(-1).FirstDayOfTheMonth(),
                ValidTo = DateTime.Now.AddMonths(-1).LastDayOfTheMonth(),
                IsRealized = true,
            },
            new Contract() {
                Id = 15,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddMonths(-1).FirstDayOfTheMonth().AddDays(-10),
                EmployeeId = 2,
                //PaymentId = 5,
                ContractSubject = "Oszlifowanie wręgów zbiorników wody pitnej P12-P32",
                HourlySalary = 15,
                Value = 3000,
                TaxPercent = 14.0m,
                Number = $"2/{DateTime.Now.AddMonths(-1).ToString("MM")}/2020",
                Title = $"Umowa za {DateTime.Now.AddMonths(-1).GetMonthNamePL()}",
                ValidFrom = DateTime.Now.AddMonths(-1).FirstDayOfTheMonth(),
                ValidTo = DateTime.Now.AddMonths(-1).LastDayOfTheMonth(),
                IsRealized = true,
            },
            new Contract() {
                Id = 16,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddMonths(-1).FirstDayOfTheMonth().AddDays(-10),
                EmployeeId = 4,
                //PaymentId = 6,
                ContractSubject = "Montaż barierek ochronnych na jednostce NB231",
                HourlySalary = 20,
                Value = 4000,
                TaxPercent = 14.0m,
                Number = $"3/{DateTime.Now.AddMonths(-1).ToString("MM")}/2020",
                Title = $"Umowa za {DateTime.Now.AddMonths(-1).GetMonthNamePL()}",
                ValidFrom = DateTime.Now.AddMonths(-1).FirstDayOfTheMonth(),
                ValidTo = DateTime.Now.AddMonths(-1).LastDayOfTheMonth(),
                IsRealized = true,
            },
            //NOW
            new Contract() {
                Id = 17,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddMonths(-1).FirstDayOfTheMonth().AddDays(-10),
                EmployeeId = 1,
                ContractSubject = "Przyspawanie sekcji okętowych NW23-NW24",
                HourlySalary = 25,
                Value = 5000,
                TaxPercent = 14.0m,
                Number = $"1/{DateTime.Now.ToString("MM")}/2020",
                Title = $"Umowa za {DateTime.Now.GetMonthNamePL()}",
                ValidFrom = DateTime.Now.FirstDayOfTheMonth(),
                ValidTo = DateTime.Now.LastDayOfTheMonth(),
                IsRealized = false,
            },
            new Contract() {
                Id = 18,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddMonths(-1).FirstDayOfTheMonth().AddDays(-10),
                EmployeeId = 2,
                ContractSubject = "Oszlifowanie wręgów zbiorników wody pitnej P12-P32",
                HourlySalary = 15,
                Value = 3000,
                TaxPercent = 14.0m,
                Number = $"2/{DateTime.Now.ToString("MM")}/2020",
                Title = $"Umowa za {DateTime.Now.GetMonthNamePL()}",
                ValidFrom = DateTime.Now.FirstDayOfTheMonth(),
                ValidTo = DateTime.Now.LastDayOfTheMonth(),
                IsRealized = false,
            },
            new Contract() {
                Id = 19,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddMonths(-1).FirstDayOfTheMonth().AddDays(-10),
                EmployeeId = 4,
                ContractSubject = "Montaż barierek ochronnych na jednostce NB231",
                HourlySalary = 20,
                Value = 4000,
                TaxPercent = 14.0m,
                Number = $"3/{DateTime.Now.ToString("MM")}/2020",
                Title = $"Umowa za {DateTime.Now.GetMonthNamePL()}",
                ValidFrom = DateTime.Now.FirstDayOfTheMonth(),
                ValidTo = DateTime.Now.LastDayOfTheMonth(),
                IsRealized = false,
            },


        };
        public static IEnumerable<Advance> GetDummyAdvances() => new Advance[] {
            //month 1
            new Advance() {
                Id = 1,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddMonths(-1).FirstDayOfTheMonth().AddDays(12),
                ContractId = 14,
                Amount = 1100,
                WorkedHours = 70,
                PaidOn = DateTime.Now.AddMonths(-1).FirstDayOfTheMonth().AddDays(15),
            },
            new Advance() {
                Id = 2,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddMonths(-1).FirstDayOfTheMonth().AddDays(13),
                ContractId = 15,
                Amount = 900,
                WorkedHours = 80,
                PaidOn = DateTime.Now.AddMonths(-1).FirstDayOfTheMonth().AddDays(15),
            },
            new Advance() {
                Id = 3,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddMonths(-1).FirstDayOfTheMonth().AddDays(14),
                ContractId = 16,
                Amount = 1000,
                WorkedHours = 86,
                PaidOn = DateTime.Now.AddMonths(-1).FirstDayOfTheMonth().AddDays(18),
            },
            //month 0 
            new Advance() {
                Id = 4,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now,
                ContractId = 17,
                Amount = 2000,
                WorkedHours = 10,
                PaidOn = null,
            },
            new Advance() {
                Id = 5,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now,
                ContractId = 18,
                Amount = 2500,
                WorkedHours = 10,
                PaidOn = null,
            },
            new Advance() {
                Id = 6,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now,
                ContractId = 19,
                Amount = 500,
                WorkedHours = 16,
                PaidOn = DateTime.Now
            },
        };
        public static IEnumerable<Payment> GetDummyPayment() => new Payment[] {
            //month 2
            new Payment() {
                Id = 1,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddMonths(-1).FirstDayOfTheMonth().AddDays(10),
                ContractId = 11,
                GrossAmount = 5000,
                NetAmount = 5000 * 0.86m,
                PaidOn = DateTime.Now.AddMonths(-1).FirstDayOfTheMonth().AddDays(10),
            },
            new Payment() {
                Id = 2,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddMonths(-1).FirstDayOfTheMonth().AddDays(10),
                ContractId = 12,
                GrossAmount = 3000,
                NetAmount = 3000 * 0.86m,
                PaidOn = DateTime.Now.AddMonths(-1).FirstDayOfTheMonth().AddDays(10),
            },
            new Payment() {
                Id = 3,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddMonths(-1).FirstDayOfTheMonth().AddDays(10),
                ContractId = 13,
                GrossAmount = 4000,
                NetAmount = 4000 * 0.86m,
                PaidOn = DateTime.Now.AddMonths(-1).FirstDayOfTheMonth().AddDays(10),
            },
            //month 1
            new Payment() {
                Id = 4,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.FirstDayOfTheMonth().AddDays(10),
                ContractId = 14,
                GrossAmount = 5000,
                NetAmount = 5000 * 0.86m,
                PaidOn = DateTime.Now.FirstDayOfTheMonth().AddDays(10),
            },
            new Payment() {
                Id = 5,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.FirstDayOfTheMonth().AddDays(10),
                ContractId = 15,
                GrossAmount = 3000,
                NetAmount = 3000 * 0.86m,
                PaidOn = DateTime.Now.FirstDayOfTheMonth().AddDays(10),
            },
            new Payment() {
                Id = 6,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.FirstDayOfTheMonth().AddDays(10),
                ContractId = 16,
                GrossAmount = 4000,
                NetAmount = 4000 * 0.86m,
                PaidOn = DateTime.Now.FirstDayOfTheMonth().AddDays(10),
            }
        };

    }
}
