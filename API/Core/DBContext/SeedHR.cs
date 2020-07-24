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
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddDays(-300),
                FirstName = "Maciej",
                DateOfBirth = new DateTime(1980, 1, 21),
                MotherName = "Mariola",
                FatherName = "Mariusz",
                Nationality = "Polska",
                Pesel = "80012100000",
            },
            new Employee() {
                Id = 2,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddDays(-250),
                FirstName = "Dmyto",
                DateOfBirth = new DateTime(1997, 2, 20),
                MotherName = "Svetlana",
                FatherName = "Vitalii",
                Nationality = "Ukraina",
                Pesel = "",
            },
            new Employee() {
                Id = 3,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddDays(-250),
                FirstName = "Oleksandr",
                DateOfBirth = new DateTime(1993, 12, 10),
                MotherName = "Oleksandra",
                FatherName = "Oleksii",
                Nationality = "Ukraina",
                Pesel = "",
            },
             new Employee() {
                Id = 4,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddDays(-150),
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
                CreatedBy = "Initial",
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
                CreatedBy = "Initial",
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
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddDays(-300),
                FirstName = "Grzegorz",
                LastName = "Grzegorczuk",
                LocationId = 1,
                Mail = "G.Grzegorczuk@StoczniaGdynia.pl",
                PhoneNo = "+58 608 385 512"
            },
            new Foreman() {
                Id = 2,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddDays(-250),
                FirstName = "Jakub",
                LastName = "Jakubczyk",
                LocationId = 1,
                Mail = "J.Jakubczyk@StoczniaGdynia.pl",
                PhoneNo = "+58 608 385 513"
            },
            new Foreman() {
                Id = 3,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddDays(-200),
                FirstName = "Filip",
                LastName = "Filipiak",
                LocationId = 2,
                Mail = "Filip.Filipiak@Remontowa.pl",
                PhoneNo = "+58 808 100 001"
            }
        };
        /*
        public static IEnumerable<EmployeeAddress> GetDummyEmployeeAddresses() => new EmployeeAddress[] {
            new EmployeeAddress() {
                Id = 1,
                CreatedBy = "Initial",
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
                CreatedBy = "Initial",
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
                CreatedBy = "Initial",
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
                CreatedBy = "Initial",
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
                CreatedBy = "Initial",
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
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddDays(-100),
                Country = "Polska",
                Region = "Pomorze",
                City = "Gdańsk",
                Zip = "80-506",
                Street = "Nadmorski Dwór",
                Number = "3-1",
            },
        };
        */
        public static IEnumerable<EmployeeHistory> GetDummyEmployeeHistories() => new EmployeeHistory[] {
            new EmployeeHistory() {
                Id = 1,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddDays(-300),
                LastName = "Maciejewski",
                Profession = "Monter Okrętowy",
                PhoneNo = "608 767 878",
                Country = "Polska",
                Region = "Pomorze",
                City = "Kosokowo",
                Zip = "81-198",
                Street = "Rzemieślnicza",
                Number = "26C",
                EmployeeId = 1,
                ForemanId = 1,
                LocationId = 1
            },
            new EmployeeHistory() {
                Id = 2,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddDays(-250),
                LastName = "Kravchuk",
                Profession = "Szlifierz Okrętowy",
                PhoneNo = "982 280 556",
                Country = "Polska",
                Region = "Pomorze",
                City = "Rumia",
                Zip = "84-230",
                Street = "Świętopełka",
                Number = "20A",
                EmployeeId = 2,
                ForemanId = 2,
                LocationId = 1
            },
            new EmployeeHistory() {
                Id = 3,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddDays(-250),
                LastName = "Kuchna",
                Profession = "Szlifierz Okrętowy",
                PhoneNo = "777 090 210",
                Country = "Polska",
                Region = "Pomorze",
                City = "Gdynia",
                Zip = "81-549",
                Street = "Spokojna",
                Number = "6",
                EmployeeId = 3,
                ForemanId = 2,
                LocationId = 1
            },
            new EmployeeHistory() {
                Id = 4,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddDays(-200),
                LastName = "Maciejewski",
                Profession = "Spawacz Okrętowy",
                Country = "Polska",
                Region = "Pomorze",
                City = "Gdańsk",
                Zip = "80-553",
                Street = "Ks. Mariana Góreckiego",
                Number = "12",
                EmployeeId = 1,
                ForemanId = 3,
                LocationId = 2
            },
            new EmployeeHistory() {
                Id = 5,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddDays(-150),
                LastName = "Yushchenko",
                Profession = "Monter Okrętowy",
                PhoneNo = "606 852 298",
                Country = "Polska",
                Region = "Pomorze",
                City = "Pogórze",
                Zip = "81-198",
                Street = "Wapienna",
                Number = "13",
                EmployeeId = 4,
                ForemanId = 2,
                LocationId = 1
            },
            new EmployeeHistory() {
                Id = 6,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddDays(-100),
                LastName = "Maciejewski",
                Profession = "Spawacz Okrętowy",
                PhoneNo = "608 767 878",
                Country = "Polska",
                Region = "Pomorze",
                City = "Gdańsk",
                Zip = "80-506",
                Street = "Nadmorski Dwór",
                Number = "3-1",
                EmployeeId = 1,
                ForemanId = 3,
                LocationId = 2
            },
        };
        public static IEnumerable<MedicalCheckup> GetDummyMedicalCheckups() => new MedicalCheckup[]{
            new MedicalCheckup() {
                Id = 1,
                CreatedBy = "Initial",
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
                CreatedBy = "Initial",
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
                CreatedBy = "Initial",
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
                CreatedBy = "Initial",
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
                CreatedBy = "Initial",
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
                CreatedBy = "Initial",
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
                CreatedBy = "Initial",
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
                CreatedBy = "Initial",
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
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddDays(-200),
                EmployeeId = 4,
                Title = "Szkolenie BHP - Stocznia Gdynia",
                IssuedBy = "Dział BHP - Stocznia Gdynia",
                Number = "BHP/440/19",
                ValidFrom = DateTime.Now.AddDays(-150),
                ValidTo = DateTime.Now.AddYears(2).AddDays(-150),
            },
        };
        public static IEnumerable<Certificate> GetDummyCertificates() => new Certificate[]{
            new Certificate() {
                Id = 1,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddDays(-300),
                EmployeeId = 1,
                Title = "Kurs palenia i szczepiania palnikiem gazowym",
                IssuedBy = "Szkółka monterów Jastrząb",
                Number = "PS/34/20",
                ValidFrom = DateTime.Now.AddYears(-2),
                ValidTo = DateTime.Now.AddYears(3)
            },
            new Certificate() {
                Id = 2,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddDays(-200),
                EmployeeId = 1,
                Title = "Placówka szkoleniowa spawaczy - Stocznia Gdańsk",
                IssuedBy = "DNV",
                Number = "DNV/086/2020",
                ValidFrom = DateTime.Now.AddDays(-200),
                ValidTo = DateTime.Now.AddYears(3).AddDays(-200)
            },
            new Certificate() {
                Id = 3,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddDays(-150),
                EmployeeId = 4,
                Title = "Kurs palenia i szczepiania palnikiem gazowym",
                IssuedBy = "Zakład szkolenia monterów w Harkowie",
                Number = "HR/127/20",
                ValidFrom = DateTime.Now.AddYears(-4).AddDays(-150),
                ValidTo = DateTime.Now.AddDays(29)
            }
        };
        public static IEnumerable<Passport> GetDummyPassports() => new Passport[] {
            new Passport() {
                Id = 1,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddDays(-250),
                EmployeeId = 2,
                IssuedBy = "Biuro Paszportowe w Kijowie",
                Number = "UKR090909",
                Title = "Paszport Ukraina",
                ValidFrom = DateTime.Now.AddYears(-10).AddDays(-150),
                ValidTo = DateTime.Now.AddDays(-150)
            },
            new Passport() {
                Id = 2,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddDays(-250),
                EmployeeId = 3,
                IssuedBy = "Biuro Paszportowe w Harkowie",
                Number = "HKR05409",
                Title = "Paszport Ukraina",
                ValidFrom = DateTime.Now.AddYears(-1),
                ValidTo = DateTime.Now.AddYears(9)
            },
            new Passport() {
                Id = 3,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddDays(-150),
                EmployeeId = 4,
                IssuedBy = "Biuro Paszportowe w Lwowie",
                Number = "LWR12309",
                Title = "Paszport Ukraina",
                ValidFrom = DateTime.Now.AddYears(-10).AddDays(29),
                ValidTo = DateTime.Now.AddYears(29)
            },
            new Passport() {
                Id = 4,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddDays(-80),
                EmployeeId = 2,
                IssuedBy = "Biuro Paszportowe w Kijowie",
                Number = "UKR191919",
                Title = "Paszport Ukraina",
                ValidFrom = DateTime.Now.AddDays(-100),
                ValidTo = DateTime.Now.AddYears(10).AddDays(-100)
            },
        };
        public static IEnumerable<Visa> GetDummyVisas() => new Visa[] {
            new Visa() {
                Id = 1,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddDays(-250),
                EmployeeId = 2,
                IssuedBy = "Konsul w Kijowie",
                Title = "Wiza krajowa",
                Type = "D",
                Number = "PL053452",
                ValidFrom = DateTime.Now.AddYears(-1).AddDays(-150),
                ValidTo = DateTime.Now.AddDays(-150),
            },
            new Visa() {
                Id = 2,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddDays(-150),
                EmployeeId = 3,
                IssuedBy = "Konsul w Kijowie",
                Title = "Wiza krajowa",
                Type = "D",
                Number = "PL053452",
                ValidFrom = DateTime.Now.AddDays(-150),
                ValidTo = DateTime.Now.AddYears(1).AddDays(-150),
            },
            new Visa() {
                Id = 3,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddDays(-150),
                EmployeeId = 4,
                IssuedBy = "Konsul w Kijowie",
                Title = "Wiza krajowa",
                Type = "D",
                Number = "PL053452",
                ValidFrom = DateTime.Now.AddYears(-1).AddDays(29),
                ValidTo = DateTime.Now.AddDays(29),
            },
            new Visa() {
                Id = 4,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddDays(-80),
                EmployeeId = 2,
                IssuedBy = "Konsul w Kijowie",
                Title = "Wiza krajowa",
                Type = "D",
                Number = "PL053452",
                ValidFrom = DateTime.Now.AddDays(-100),
                ValidTo = DateTime.Now.AddYears(1).AddDays(-100),
            },
        };


        //2 needs to visas, one till -150, other from -100
        //EXP 1 YEAR
        //3 VISA EXPIRES WITH PASSPORT - +29 days

        //Permits

        public static IEnumerable<Permit> GetDummyPermits() => new Permit[] {
            new Permit() {
                Id = 1,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddDays(-250),
                EmployeeId = 2,
                LocationId = 1,
                IssuedBy = "Panśtwowy Urząd Pracy w Gdyni",
                Number = "OSW/575/2019",
                Title = "Oświadczenie o zamiarze powierzenia pracy",
                ValidFrom = DateTime.Now.AddDays(-250),
                ValidTo = DateTime.Now.AddDays(-150),
            },
            new Permit() {
                Id = 2,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddDays(-150),
                EmployeeId = 3,
                LocationId = 1,
                IssuedBy = "Urząd wojewódzki w Gdańsku, wydział ds. cudzoziemców",
                Number = "KP/55/2020",
                Title = "Karta Pobytu",
                ValidFrom = DateTime.Now.AddDays(-150),
                ValidTo = DateTime.Now.AddYears(5).AddDays(-150),
            },
            new Permit() {
                Id = 3,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddDays(-150),
                EmployeeId = 4,
                LocationId = 1,
                IssuedBy = "Urząd wojewódzki w Gdańsku, wydział ds. cudzoziemców",
                Number = "A/196/2020",
                Title = "Zezwolenie na pracę typ A",
                ValidFrom = DateTime.Now.AddYears(-1).AddDays(29),
                ValidTo = DateTime.Now.AddDays(29),
            },
            new Permit() {
                Id = 4,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddDays(-100),
                EmployeeId = 2,
                LocationId = 1,
                IssuedBy = "Urząd wojewódzki w Gdańsku, wydział ds. cudzoziemców",
                Number = "A/216/2020",
                Title = "Zezwolenie na pracę typ A",
                ValidFrom = DateTime.Now.AddDays(-100),
                ValidTo = DateTime.Now.AddYears(3).AddDays(-100),
            },
        };

        //2 HAS TWO PERMITS: ONE TILL -250 to -150 (oswiadczenie wojewodzkie), other from -80 (oswiadczenie)
        //3 TYPU A
        //4 KARTA POBYTU

        //Leaves

        public static IEnumerable<Leave> GetDummyLeaves() => new Leave[] {
            new Leave() {
                Id = 1,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddDays(-250),
                EmployeeId = 1,
                From = DateTime.Now.AddDays(-234),
                To = DateTime.Now.AddDays(-220),
                Type = "Wypoczynkowy",
                Comment = "Urlop wypoczynkowy, 14 dni"
            },
            new Leave() {
                Id = 2,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddDays(-157),
                EmployeeId = 2,
                From = DateTime.Now.AddDays(-150),
                To = DateTime.Now.AddDays(-80),
                Type = "Administracyjny",
                Comment = "Urlop Administracyjny, wymiana paszporty, wizy"
            },
            new Leave() {
                Id = 3,
                CreatedBy = "Initial",
                CreatedOn = DateTime.Now.AddDays(-61),
                EmployeeId = 1,
                From = DateTime.Now.AddDays(-61),
                To = null,
                Type = "Nieusprawiedliwiony",
                Comment = "Obecność nieusprawiedliwiona"
            },
        };


        //1 jakis urlop
        //2 has been gone till days -150 to -80 aka 70 days. ON LEGAL
        //3 bumelka od -61 dni

    }
}
