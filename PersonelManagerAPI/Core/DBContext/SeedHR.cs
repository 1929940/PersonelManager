using API.HR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Core.DBContext {
    public static class SeedHR {
        public static IEnumerable<Employee> GetDummyEmployees() => new Employee[] {
            new Employee() {
                Id = 1,
                CreatedBy = "Administrator",
                CreatedOn = DateTime.Today.AddDays(-300),
                FirstName = "Maciej",
                DateOfBirth = new DateTime(1980, 1, 21),
                MotherName = "Mariola",
                FatherName = "Mariusz",
                Nationality = "Polska",
                Pesel = "80012100000",
            },
            new Employee() {
                Id = 2,
                CreatedBy = "Administrator",
                CreatedOn = DateTime.Today.AddDays(-250),
                FirstName = "Dmyto",
                DateOfBirth = new DateTime(1997, 2, 20),
                MotherName = "Svetlana",
                FatherName = "Vitalii",
                Nationality = "Ukraina",
                Pesel = "",
            },
            new Employee() {
                Id = 3,
                CreatedBy = "Administrator",
                CreatedOn = DateTime.Today.AddDays(-250),
                FirstName = "Oleksandr",
                DateOfBirth = new DateTime(1993, 12, 10),
                MotherName = "Oleksandra",
                FatherName = "Oleksii",
                Nationality = "Ukraina",
                Pesel = "",
            },
             new Employee() {
                Id = 4,
                CreatedBy = "Administrator",
                CreatedOn = DateTime.Today.AddDays(-150),
                FirstName = "Yevhenii",
                DateOfBirth = new DateTime(1997, 2, 20),
                MotherName = "Zlata",
                FatherName = "Maxim",
                Nationality = "Ukraina",
                Pesel = "97022012345",
            },
        };


        public static IEnumerable<Location> GetDummyLocation() => new Location[] {
            new Location() {
                Id = 1,
                CreatedBy = "Administrator",
                CreatedOn = DateTime.Now.AddDays(-300),
                Name = "Stocznia Gdynia SA",
                Country = "Polska",
                Region = "Pomorze",
                City = "Gdynia",
                Zip = "81-336",
                Street = "Czechosłowacka",
                Number = "3",
            },
            new Location() {
                Id = 2,
                CreatedBy = "Administrator",
                CreatedOn = DateTime.Now.AddDays(-250),
                Name = "Stocznia Remontowa Gdańsk",
                Country = "Polska",
                Region = "Pomorze",
                City = "Gdańsk",
                Zip = "80-958",
                Street = "Swojska",
                Number = "8",
            }
        };
        public static IEnumerable<Foreman> GetDummyForemen() => new Foreman[] {
            new Foreman() {
                Id = 1,
                CreatedBy = "Administrator",
                CreatedOn = DateTime.Now.AddDays(-300),
                FirstName = "Grzegorz",
                LastName = "Grzegorczuk",
                LocationId = 1,
                Mail = "G.Grzegorczuk@StoczniaGdynia.pl",
                PhoneNo = "+58 608 385 512"
            },
            new Foreman() {
                Id = 2,
                CreatedBy = "Administrator",
                CreatedOn = DateTime.Now.AddDays(-250),
                FirstName = "Jakub",
                LastName = "Jakubczyk",
                LocationId = 1,
                Mail = "J.Jakubczyk@StoczniaGdynia.pl",
                PhoneNo = "+58 608 385 513"
            },
            new Foreman() {
                Id = 3,
                CreatedBy = "Administrator",
                CreatedOn = DateTime.Now.AddDays(-200),
                FirstName = "Filip",
                LastName = "Filipiak",
                LocationId = 2,
                Mail = "Filip.Filipiak@Remontowa.pl",
                PhoneNo = "+58 808 100 001"
            }
        };
        public static IEnumerable<EmployeeAddress> GetDummyEmployeeAddresses() => new EmployeeAddress[] {
            new EmployeeAddress() {
                Id = 1,
                CreatedBy = "Administrator",
                CreatedOn = DateTime.Now.AddDays(-300),
                Country = "Polska",
                Region = "Pomorze",
                City = "Kosokowo",
                Zip = "81-198",
                Street = "Rzemieślnicza",
                Number = "26C",
            },
                new EmployeeAddress() {
                Id = 2,
                CreatedBy = "Administrator",
                CreatedOn = DateTime.Now.AddDays(-250),
                Country = "Polska",
                Region = "Pomorze",
                City = "Rumia",
                Zip = "84-230",
                Street = "Świętopełka",
                Number = "20A",
            },
                new EmployeeAddress() {
                Id = 3,
                CreatedBy = "Administrator",
                CreatedOn = DateTime.Now.AddDays(-250),
                Country = "Polska",
                Region = "Pomorze",
                City = "Gdynia",
                Zip = "81-549",
                Street = "Spokojna",
                Number = "6",
            },
                new EmployeeAddress() {
                Id = 4,
                CreatedBy = "Administrator",
                CreatedOn = DateTime.Now.AddDays(-200),
                Country = "Polska",
                Region = "Pomorze",
                City = "Gdańsk",
                Zip = "80-553",
                Street = "Ks. Mariana Góreckiego",
                Number = "12",
            },
                new EmployeeAddress() {
                Id = 5,
                CreatedBy = "Administrator",
                CreatedOn = DateTime.Now.AddDays(-150),
                Country = "Polska",
                Region = "Pomorze",
                City = "Pogórze",
                Zip = "81-198",
                Street = "Wapienna",
                Number = "13",
            },
            new EmployeeAddress() {
                Id = 6,
                CreatedBy = "Administrator",
                CreatedOn = DateTime.Now.AddDays(-100),
                Country = "Polska",
                Region = "Pomorze",
                City = "Gdańsk",
                Zip = "80-506",
                Street = "Nadmorski Dwór",
                Number = "3-1",
            },
        };
        public static IEnumerable<EmployeeHistory> GetDummyEmployeeHistories() => new EmployeeHistory[] {
            new EmployeeHistory() {
                Id = 1,
                CreatedBy = "Administrator",
                CreatedOn = DateTime.Now.AddDays(-300),
                LastName = "Maciejewski",
                Profession = "Monter Okrętowy",
                EmployeeId = 1,
                EmployeeAddressId = 1,
                ForemanId = 1,
                LocationId = 1
            },
            new EmployeeHistory() {
                Id = 2,
                CreatedBy = "Administrator",
                CreatedOn = DateTime.Now.AddDays(-250),
                LastName = "Kravchuk",
                Profession = "Szlifierz Okrętowy",
                EmployeeId = 2,
                EmployeeAddressId = 2,
                ForemanId = 2,
                LocationId = 1
            },
            new EmployeeHistory() {
                Id = 3,
                CreatedBy = "Administrator",
                CreatedOn = DateTime.Now.AddDays(-250),
                LastName = "Kuchna",
                Profession = "Szlifierz Okrętowy",
                EmployeeId = 3,
                EmployeeAddressId = 3,
                ForemanId = 2,
                LocationId = 1
            },
            new EmployeeHistory() {
                Id = 4,
                CreatedBy = "Administrator",
                CreatedOn = DateTime.Now.AddDays(-200),
                LastName = "Maciejewski",
                Profession = "Spawacz Okrętowy",
                EmployeeId = 1,
                EmployeeAddressId = 4,
                ForemanId = 3,
                LocationId = 2
            },
            new EmployeeHistory() {
                Id = 5,
                CreatedBy = "Administrator",
                CreatedOn = DateTime.Now.AddDays(-150),
                LastName = "Yushchenko",
                Profession = "Monter Okrętowy",
                EmployeeId = 4,
                EmployeeAddressId = 5,
                ForemanId = 2,
                LocationId = 1
            },
            new EmployeeHistory() {
                Id = 6,
                CreatedBy = "Administrator",
                CreatedOn = DateTime.Now.AddDays(-100),
                LastName = "Maciejewski",
                Profession = "Spawacz Okrętowy",
                EmployeeId = 1,
                EmployeeAddressId = 6,
                ForemanId = 3,
                LocationId = 2
            },
        };
        public static IEnumerable<MedicalCheckup> GetDummyMedicalCheckups() => new MedicalCheckup[]{
            new MedicalCheckup() {
                Id = 1,
                CreatedBy = "Administrator",
                CreatedOn = DateTime.Now.AddDays(-300),
                EmployeeId = 1,
                IssuedBy = "Prywatna praktyka - Dr Kamiński",
                Number = "MD/016/19",
                Title = "Badanie lekarskie wstępne",
                ValidFrom = DateTime.Now.AddYears(-2).AddDays(29),
                ValidTo = DateTime.Now.AddDays(29)
            },
            new MedicalCheckup() {
                Id = 2,
                CreatedBy = "Administrator",
                CreatedOn = DateTime.Now.AddDays(-250),
                EmployeeId = 2,
                IssuedBy = "DiamentMed sp. z o.o.",
                Number = "DM-076-19",
                Title = "Badanie lekarskie wstępne",
                ValidFrom = DateTime.Now.AddYears(-2).AddDays(30),
                ValidTo = DateTime.Now.AddDays(30)
            },
            new MedicalCheckup() {
                Id = 3,
                CreatedBy = "Administrator",
                CreatedOn = DateTime.Now.AddDays(-250),
                EmployeeId = 2,
                IssuedBy = "DiamentMed sp. z o.o.",
                Number = "DM-177-19",
                Title = "Badanie lekarskie wstępne",
                ValidFrom = DateTime.Now.AddYears(-1).AddDays(-250),
                ValidTo = DateTime.Now.AddYears(1).AddDays(-250)
            },
            new MedicalCheckup() {
                Id = 4,
                CreatedBy = "Administrator",
                CreatedOn = DateTime.Now.AddDays(-250),
                EmployeeId = 2,
                IssuedBy = "DiamentMed sp. z o.o.",
                Number = "DM-178-19",
                Title = "Badanie lekarskie wstępne",
                ValidFrom = DateTime.Now.AddYears(-1).AddDays(-150),
                ValidTo = DateTime.Now.AddYears(1).AddDays(-150)
            }
        };
        public static IEnumerable<SafetyTraining> GetDummySafetyTrainings() => new SafetyTraining[] {
            new SafetyTraining() {
                Id = 1,
                CreatedBy = "Administrator",
                CreatedOn = DateTime.Now.AddDays(-300),
                EmployeeId = 1,
                Title = "Szkolenie BHP - Stocznia Gdynia",
                IssuedBy = "Dział BHP - Stocznia Gdynia",
                Number = "BHP/99/19",
                ValidFrom = DateTime.Now.AddDays(-300),
                ValidTo = DateTime.Now.AddYears(2).AddDays(-300),
            },
            new SafetyTraining() {
                Id = 2,
                CreatedBy = "Administrator",
                CreatedOn = DateTime.Now.AddDays(-250),
                EmployeeId = 2,
                Title = "Szkolenie BHP - Stocznia Gdynia",
                IssuedBy = "Dział BHP - Stocznia Gdynia",
                Number = "BHP/339/19",
                ValidFrom = DateTime.Now.AddDays(-250),
                ValidTo = DateTime.Now.AddYears(2).AddDays(-250),
            },
            new SafetyTraining() {
                Id = 3,
                CreatedBy = "Administrator",
                CreatedOn = DateTime.Now.AddDays(-250),
                EmployeeId = 3,
                Title = "Szkolenie BHP - Stocznia Gdynia",
                IssuedBy = "Dział BHP - Stocznia Gdynia",
                Number = "BHP/340/19",
                ValidFrom = DateTime.Now.AddDays(-250),
                ValidTo = DateTime.Now.AddYears(2).AddDays(-250),
            },
            new SafetyTraining() {
                Id = 4,
                CreatedBy = "Administrator",
                CreatedOn = DateTime.Now.AddDays(-200),
                EmployeeId = 1,
                Title = "Szkolenie Wstępne BHP - Stocznia Gdańsk",
                IssuedBy = "Kierownik działu BHP - Ignacy Krasiński",
                Number = "BHP-940-19",
                ValidFrom = DateTime.Now.AddDays(-200),
                ValidTo = DateTime.Now.AddYears(1).AddDays(-200),
            },
            new SafetyTraining() {
                Id = 5,
                CreatedBy = "Administrator",
                CreatedOn = DateTime.Now.AddDays(-200),
                EmployeeId = 4,
                Title = "Szkolenie BHP - Stocznia Gdynia",
                IssuedBy = "Dział BHP - Stocznia Gdynia",
                Number = "BHP/440/19",
                ValidFrom = DateTime.Now.AddDays(-150),
                ValidTo = DateTime.Now.AddYears(2).AddDays(-150),
            },
        };

        //Certificates

        //Passports

        //Wizas

        //Permits

        //Leaves
    }
}
