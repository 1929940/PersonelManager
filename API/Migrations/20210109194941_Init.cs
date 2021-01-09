using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConfigurationPage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    BillingMonthStart = table.Column<int>(nullable: false),
                    BillingMonthEnd = table.Column<int>(nullable: false),
                    PercentOfAdvancesAllowed = table.Column<double>(nullable: false),
                    WarningBeforeMedicalCheckupExpires = table.Column<int>(nullable: false),
                    WarningBeforeSafetyTrainingExpires = table.Column<int>(nullable: false),
                    WarningBeforeCertificateExpires = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigurationPage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Pesel = table.Column<string>(nullable: true),
                    FatherName = table.Column<string>(nullable: true),
                    MotherName = table.Column<string>(nullable: true),
                    Nationality = table.Column<string>(nullable: true),
                    IsArchived = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Zip = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Hash = table.Column<string>(nullable: true),
                    RequestedPasswordReset = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Certificates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    ValidFrom = table.Column<DateTime>(nullable: false),
                    ValidTo = table.Column<DateTime>(nullable: false),
                    IssuedBy = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Certificates_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    ValidFrom = table.Column<DateTime>(nullable: false),
                    ValidTo = table.Column<DateTime>(nullable: false),
                    IssuedBy = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    TotalValue = table.Column<decimal>(nullable: false),
                    HourlySalary = table.Column<decimal>(nullable: false),
                    TaxPercent = table.Column<decimal>(nullable: false),
                    ContractSubject = table.Column<string>(nullable: true),
                    PaidOn = table.Column<DateTime>(nullable: true),
                    IsRealized = table.Column<bool>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contracts_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Leaves",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    From = table.Column<DateTime>(nullable: false),
                    To = table.Column<DateTime>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leaves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Leaves_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalCheckups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    ValidFrom = table.Column<DateTime>(nullable: false),
                    ValidTo = table.Column<DateTime>(nullable: false),
                    IssuedBy = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalCheckups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalCheckups_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SafetyTrainings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    ValidFrom = table.Column<DateTime>(nullable: false),
                    ValidTo = table.Column<DateTime>(nullable: false),
                    IssuedBy = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SafetyTrainings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SafetyTrainings_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Foremen",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PhoneNo = table.Column<string>(nullable: true),
                    Mail = table.Column<string>(nullable: true),
                    LocationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foremen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Foremen_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Advances",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    WorkedHours = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    PaidOn = table.Column<DateTime>(nullable: true),
                    ContractId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Advances_Contracts_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contracts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeesHistory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Zip = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Profession = table.Column<string>(nullable: true),
                    PhoneNo = table.Column<string>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: true),
                    ForemanId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeesHistory_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeesHistory_Foremen_ForemanId",
                        column: x => x.ForemanId,
                        principalTable: "Foremen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeesHistory_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ConfigurationPage",
                columns: new[] { "Id", "BillingMonthEnd", "BillingMonthStart", "CreatedBy", "CreatedOn", "PercentOfAdvancesAllowed", "UpdatedBy", "UpdatedOn", "WarningBeforeCertificateExpires", "WarningBeforeMedicalCheckupExpires", "WarningBeforeSafetyTrainingExpires" },
                values: new object[] { 1, 25, 26, "Initial", new DateTime(2021, 1, 9, 20, 49, 41, 48, DateTimeKind.Local).AddTicks(7500), 75.0, null, null, 30, 30, 30 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DateOfBirth", "FatherName", "FirstName", "IsArchived", "MotherName", "Nationality", "Pesel", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, "Initial", new DateTime(2020, 3, 15, 20, 49, 41, 49, DateTimeKind.Local).AddTicks(4363), new DateTime(1980, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mariusz", "Maciej", false, "Mariola", "Polska", "80012100000", null, null },
                    { 2, "Initial", new DateTime(2020, 5, 4, 20, 49, 41, 49, DateTimeKind.Local).AddTicks(6988), new DateTime(1997, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vitalii", "Dmyto", false, "Svetlana", "Ukraina", "", null, null },
                    { 3, "Initial", new DateTime(2020, 5, 4, 20, 49, 41, 49, DateTimeKind.Local).AddTicks(7049), new DateTime(1993, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oleksii", "Oleksandr", false, "Oleksandra", "Ukraina", "", null, null },
                    { 4, "Initial", new DateTime(2020, 8, 12, 20, 49, 41, 49, DateTimeKind.Local).AddTicks(7054), new DateTime(1997, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maxim", "Yevhenii", false, "Zlata", "Ukraina", "97022012345", null, null }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "City", "Country", "CreatedBy", "CreatedOn", "Name", "Number", "Region", "Street", "UpdatedBy", "UpdatedOn", "Zip" },
                values: new object[,]
                {
                    { 1, "Gdynia", "Polska", "Initial", new DateTime(2020, 3, 15, 20, 49, 41, 50, DateTimeKind.Local).AddTicks(57), "Stocznia Gdynia SA", "3", "Pomorze", "Czechosłowacka", null, null, "81-336" },
                    { 2, "Gdańsk", "Polska", "Initial", new DateTime(2020, 5, 4, 20, 49, 41, 50, DateTimeKind.Local).AddTicks(2887), "Stocznia Remontowa Gdańsk", "8", "Pomorze", "Swojska", null, null, "80-958" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Email", "FirstName", "Hash", "IsActive", "LastName", "RequestedPasswordReset", "Role", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, "Initial", new DateTime(2021, 1, 9, 20, 49, 41, 44, DateTimeKind.Local).AddTicks(992), "Jan.Kowalski@PersonelManager.pl", "Jan", "ECC1DD30FAE7C0D8A891953B0DCF883ECAE21ECD0576BF9E00B3A279AB351BA3", true, "Kowalski", true, "Kierownik", null, null },
                    { 2, "Initial", new DateTime(2021, 1, 9, 20, 49, 41, 47, DateTimeKind.Local).AddTicks(2580), "Jan.Nowak@PersonelManager.pl", "Jan", "ECC1DD30FAE7C0D8A891953B0DCF883ECAE21ECD0576BF9E00B3A279AB351BA3", true, "Nowak", false, "Pracownik", null, null },
                    { 3, "Initial", new DateTime(2021, 1, 9, 20, 49, 41, 47, DateTimeKind.Local).AddTicks(2657), "Maria.Niziolek@PersonelManager.pl", "Maria", "ECC1DD30FAE7C0D8A891953B0DCF883ECAE21ECD0576BF9E00B3A279AB351BA3", false, "Niziolek", true, "Pracownik", null, null },
                    { 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1929940@gmail.com", "Administrator", "ECC1DD30FAE7C0D8A891953B0DCF883ECAE21ECD0576BF9E00B3A279AB351BA3", true, "", false, "Administrator", null, null },
                    { 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@pm-tester.pl", "Tester1", "ECC1DD30FAE7C0D8A891953B0DCF883ECAE21ECD0576BF9E00B3A279AB351BA3", true, "Admin", false, "Administrator", null, null },
                    { 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "manager@pm-tester.pl", "Tester2", "ECC1DD30FAE7C0D8A891953B0DCF883ECAE21ECD0576BF9E00B3A279AB351BA3", true, "Manager", false, "Kierownik", null, null },
                    { 7, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "employee@pm-tester.pl", "Tester3", "ECC1DD30FAE7C0D8A891953B0DCF883ECAE21ECD0576BF9E00B3A279AB351BA3", true, "Employee", false, "Pracownik", null, null },
                    { 8, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "inactive@pm-tester.pl", "Tester4", "ECC1DD30FAE7C0D8A891953B0DCF883ECAE21ECD0576BF9E00B3A279AB351BA3", false, "Employee", false, "Pracownik", null, null }
                });

            migrationBuilder.InsertData(
                table: "Certificates",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "EmployeeId", "IssuedBy", "Number", "Title", "UpdatedBy", "UpdatedOn", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 1, "Initial", new DateTime(2020, 3, 15, 20, 49, 41, 53, DateTimeKind.Local).AddTicks(3242), 1, "Szkółka monterów Jastrząb", "PS/34/20", "Kurs palenia i szczepiania palnikiem gazowym", null, null, new DateTime(2019, 1, 9, 20, 49, 41, 53, DateTimeKind.Local).AddTicks(3258), new DateTime(2024, 1, 9, 20, 49, 41, 53, DateTimeKind.Local).AddTicks(3263) },
                    { 2, "Initial", new DateTime(2020, 6, 23, 20, 49, 41, 53, DateTimeKind.Local).AddTicks(3281), 1, "DNV", "DNV/086/2020", "Placówka szkoleniowa spawaczy - Stocznia Gdańsk", null, null, new DateTime(2020, 6, 23, 20, 49, 41, 53, DateTimeKind.Local).AddTicks(3284), new DateTime(2023, 6, 23, 20, 49, 41, 53, DateTimeKind.Local).AddTicks(3287) },
                    { 3, "Initial", new DateTime(2020, 8, 12, 20, 49, 41, 53, DateTimeKind.Local).AddTicks(3290), 4, "Zakład szkolenia monterów w Harkowie", "HR/127/20", "Kurs palenia i szczepiania palnikiem gazowym", null, null, new DateTime(2016, 8, 12, 20, 49, 41, 53, DateTimeKind.Local).AddTicks(3293), new DateTime(2021, 2, 7, 20, 49, 41, 53, DateTimeKind.Local).AddTicks(3296) }
                });

            migrationBuilder.InsertData(
                table: "Contracts",
                columns: new[] { "Id", "ContractSubject", "CreatedBy", "CreatedOn", "EmployeeId", "HourlySalary", "IsRealized", "IssuedBy", "Number", "PaidOn", "TaxPercent", "Title", "TotalValue", "UpdatedBy", "UpdatedOn", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 12, "Oszlifowanie wręgów 11-201 na jednostce NB231", "Initial", new DateTime(2020, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 15m, true, null, "2/11/2020", null, 14.0m, "Umowa za listopad", 3000m, null, null, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 8, 20, 49, 41, 58, DateTimeKind.Local).AddTicks(4249) },
                    { 3, "Oszlifowanie trapa na jednostce NB230", "Initial", new DateTime(2020, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 15m, true, null, "2/08/2020", null, 14.0m, "Umowa za sierpień", 3000m, null, null, new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 8, 20, 49, 41, 58, DateTimeKind.Local).AddTicks(4076) },
                    { 4, "Oszlifowanie zbiornika ZL15", "Initial", new DateTime(2020, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 15m, true, null, "3/08/2020", null, 14.0m, "Umowa za sierpień", 3000m, null, null, new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 8, 20, 49, 41, 58, DateTimeKind.Local).AddTicks(4097) },
                    { 6, "Oszlifowanie schodów na jednostce NB230", "Initial", new DateTime(2020, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 15m, true, null, "2/09/2020", null, 14.0m, "Umowa za wrzesień", 3000m, null, null, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 8, 20, 49, 41, 58, DateTimeKind.Local).AddTicks(4135) },
                    { 9, "Oszlifowanie wręgów 11-201 na jednostce NB230", "Initial", new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 15m, true, null, "2/10/2020", null, 14.0m, "Umowa za październik", 3000m, null, null, new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 8, 20, 49, 41, 58, DateTimeKind.Local).AddTicks(4192) },
                    { 7, "Wypalenie otworu technicznego 23 na jednostce NB230", "Initial", new DateTime(2020, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 20m, true, null, "3/09/2020", null, 14.0m, "Umowa za wrzesień", 4000m, null, null, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 8, 20, 49, 41, 58, DateTimeKind.Local).AddTicks(4154) },
                    { 17, "Przyspawanie sekcji okętowych NW23-NW24", "Initial", new DateTime(2020, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 25m, false, null, "1/01/2020", null, 14.0m, "Umowa za styczeń", 5000m, null, null, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 8, 20, 49, 41, 58, DateTimeKind.Local).AddTicks(4466) },
                    { 14, "Przyspawanie sekcji okętowych NW23-NW24", "Initial", new DateTime(2020, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 25m, true, null, "1/12/2020", null, 14.0m, "Umowa za grudzień", 5000m, null, null, new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 8, 20, 49, 41, 58, DateTimeKind.Local).AddTicks(4410) },
                    { 11, "Przyspawanie haków technocznych do płatu P12", "Initial", new DateTime(2020, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 25m, true, null, "1/11/2020", null, 14.0m, "Umowa za listopad", 5000m, null, null, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 8, 20, 49, 41, 58, DateTimeKind.Local).AddTicks(4230) },
                    { 8, "Przyspawanie haków technocznych do płatu P11", "Initial", new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 25m, true, null, "1/10/2020", null, 14.0m, "Umowa za październik", 5000m, null, null, new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 8, 20, 49, 41, 58, DateTimeKind.Local).AddTicks(4173) },
                    { 5, "Przyspawanie wręgów 201-421 na jednostce WZ211", "Initial", new DateTime(2020, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 25m, true, null, "1/09/2020", null, 14.0m, "Umowa za wrzesień", 5000m, null, null, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 8, 20, 49, 41, 58, DateTimeKind.Local).AddTicks(4116) },
                    { 2, "Przyspawanie wręgów 11-201 na jednostce WZ211", "Initial", new DateTime(2020, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 25m, true, null, "1/08/2020", null, 14.0m, "Umowa za sierpień", 5000m, null, null, new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 8, 20, 49, 41, 58, DateTimeKind.Local).AddTicks(4039) },
                    { 1, "Montaż obarierowania ochronnego na jednostce NB230", "Initial", new DateTime(2020, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 20m, true, null, "1/07/2020", null, 14.0m, "Umowa za lipiec", 4000m, null, null, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 8, 20, 49, 41, 58, DateTimeKind.Local).AddTicks(2711) },
                    { 10, "Montaż trapu na jednostce NB230", "Initial", new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 20m, true, null, "3/10/2020", null, 14.0m, "Umowa za październik", 4000m, null, null, new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 8, 20, 49, 41, 58, DateTimeKind.Local).AddTicks(4211) },
                    { 13, "Montaż trapu na jednostce NB231", "Initial", new DateTime(2020, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 20m, true, null, "3/11/2020", null, 14.0m, "Umowa za listopad", 4000m, null, null, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 8, 20, 49, 41, 58, DateTimeKind.Local).AddTicks(4268) },
                    { 16, "Montaż barierek ochronnych na jednostce NB231", "Initial", new DateTime(2020, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 20m, true, null, "3/12/2020", null, 14.0m, "Umowa za grudzień", 4000m, null, null, new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 8, 20, 49, 41, 58, DateTimeKind.Local).AddTicks(4448) },
                    { 19, "Montaż barierek ochronnych na jednostce NB231", "Initial", new DateTime(2020, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 20m, false, null, "3/01/2020", null, 14.0m, "Umowa za styczeń", 4000m, null, null, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 8, 20, 49, 41, 58, DateTimeKind.Local).AddTicks(4502) },
                    { 15, "Oszlifowanie wręgów zbiorników wody pitnej P12-P32", "Initial", new DateTime(2020, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 15m, true, null, "2/12/2020", null, 14.0m, "Umowa za grudzień", 3000m, null, null, new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 8, 20, 49, 41, 58, DateTimeKind.Local).AddTicks(4429) },
                    { 18, "Oszlifowanie wręgów zbiorników wody pitnej P12-P32", "Initial", new DateTime(2020, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 15m, false, null, "2/01/2020", null, 14.0m, "Umowa za styczeń", 3000m, null, null, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 8, 20, 49, 41, 58, DateTimeKind.Local).AddTicks(4484) }
                });

            migrationBuilder.InsertData(
                table: "Foremen",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "FirstName", "LastName", "LocationId", "Mail", "PhoneNo", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, "Initial", new DateTime(2020, 3, 15, 20, 49, 41, 50, DateTimeKind.Local).AddTicks(5793), "Grzegorz", "Grzegorczuk", 1, "G.Grzegorczuk@StoczniaGdynia.pl", "+58 608 385 512", null, null },
                    { 3, "Initial", new DateTime(2020, 6, 23, 20, 49, 41, 50, DateTimeKind.Local).AddTicks(7967), "Filip", "Filipiak", 2, "Filip.Filipiak@Remontowa.pl", "+58 808 100 001", null, null },
                    { 2, "Initial", new DateTime(2020, 5, 4, 20, 49, 41, 50, DateTimeKind.Local).AddTicks(7908), "Jakub", "Jakubczyk", 1, "J.Jakubczyk@StoczniaGdynia.pl", "+58 608 385 513", null, null }
                });

            migrationBuilder.InsertData(
                table: "Leaves",
                columns: new[] { "Id", "Comment", "CreatedBy", "CreatedOn", "EmployeeId", "From", "To", "Type", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 2, "Urlop Administracyjny, wymiana paszporty, wizy", "Initial", new DateTime(2020, 8, 5, 20, 49, 41, 53, DateTimeKind.Local).AddTicks(9647), 2, new DateTime(2020, 8, 12, 20, 49, 41, 53, DateTimeKind.Local).AddTicks(9665), new DateTime(2020, 10, 21, 20, 49, 41, 53, DateTimeKind.Local).AddTicks(9676), "Administracyjny", null, null },
                    { 3, "Obecność nieusprawiedliwiona", "Initial", new DateTime(2020, 11, 9, 20, 49, 41, 53, DateTimeKind.Local).AddTicks(9698), 1, new DateTime(2020, 11, 9, 20, 49, 41, 53, DateTimeKind.Local).AddTicks(9701), null, "Nieusprawiedliwiony", null, null },
                    { 1, "Urlop wypoczynkowy, 14 dni", "Initial", new DateTime(2020, 5, 4, 20, 49, 41, 53, DateTimeKind.Local).AddTicks(7246), 1, new DateTime(2020, 5, 20, 20, 49, 41, 53, DateTimeKind.Local).AddTicks(7721), new DateTime(2020, 6, 3, 20, 49, 41, 53, DateTimeKind.Local).AddTicks(8207), "Wypoczynkowy", null, null }
                });

            migrationBuilder.InsertData(
                table: "MedicalCheckups",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "EmployeeId", "IssuedBy", "Number", "Title", "UpdatedBy", "UpdatedOn", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 4, "Initial", new DateTime(2020, 5, 4, 20, 49, 41, 52, DateTimeKind.Local).AddTicks(5142), 2, "DiamentMed sp. z o.o.", "DM-178-19", "Badanie lekarskie wstępne", null, null, new DateTime(2019, 8, 12, 20, 49, 41, 52, DateTimeKind.Local).AddTicks(5144), new DateTime(2021, 8, 12, 20, 49, 41, 52, DateTimeKind.Local).AddTicks(5147) },
                    { 3, "Initial", new DateTime(2020, 5, 4, 20, 49, 41, 52, DateTimeKind.Local).AddTicks(5131), 2, "DiamentMed sp. z o.o.", "DM-177-19", "Badanie lekarskie wstępne", null, null, new DateTime(2019, 5, 4, 20, 49, 41, 52, DateTimeKind.Local).AddTicks(5134), new DateTime(2021, 5, 4, 20, 49, 41, 52, DateTimeKind.Local).AddTicks(5138) },
                    { 2, "Initial", new DateTime(2020, 5, 4, 20, 49, 41, 52, DateTimeKind.Local).AddTicks(5053), 2, "DiamentMed sp. z o.o.", "DM-076-19", "Badanie lekarskie wstępne", null, null, new DateTime(2019, 2, 8, 20, 49, 41, 52, DateTimeKind.Local).AddTicks(5107), new DateTime(2021, 2, 8, 20, 49, 41, 52, DateTimeKind.Local).AddTicks(5122) },
                    { 1, "Initial", new DateTime(2020, 3, 15, 20, 49, 41, 52, DateTimeKind.Local).AddTicks(2235), 1, "Prywatna praktyka - Dr Kamiński", "MD/016/19", "Badanie lekarskie wstępne", null, null, new DateTime(2019, 2, 7, 20, 49, 41, 52, DateTimeKind.Local).AddTicks(4019), new DateTime(2021, 2, 7, 20, 49, 41, 52, DateTimeKind.Local).AddTicks(4560) }
                });

            migrationBuilder.InsertData(
                table: "SafetyTrainings",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "EmployeeId", "IssuedBy", "Number", "Title", "UpdatedBy", "UpdatedOn", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 5, "Initial", new DateTime(2020, 6, 23, 20, 49, 41, 52, DateTimeKind.Local).AddTicks(9843), 4, "Dział BHP - Stocznia Gdynia", "BHP/440/19", "Szkolenie BHP - Stocznia Gdynia", null, null, new DateTime(2020, 8, 12, 20, 49, 41, 52, DateTimeKind.Local).AddTicks(9846), new DateTime(2022, 8, 12, 20, 49, 41, 52, DateTimeKind.Local).AddTicks(9848) },
                    { 4, "Initial", new DateTime(2020, 6, 23, 20, 49, 41, 52, DateTimeKind.Local).AddTicks(9835), 1, "Kierownik działu BHP - Ignacy Krasiński", "BHP-940-19", "Szkolenie Wstępne BHP - Stocznia Gdańsk", null, null, new DateTime(2020, 6, 23, 20, 49, 41, 52, DateTimeKind.Local).AddTicks(9837), new DateTime(2021, 6, 23, 20, 49, 41, 52, DateTimeKind.Local).AddTicks(9840) },
                    { 1, "Initial", new DateTime(2020, 3, 15, 20, 49, 41, 52, DateTimeKind.Local).AddTicks(9779), 1, "Dział BHP - Stocznia Gdynia", "BHP/99/19", "Szkolenie BHP - Stocznia Gdynia", null, null, new DateTime(2020, 3, 15, 20, 49, 41, 52, DateTimeKind.Local).AddTicks(9795), new DateTime(2022, 3, 15, 20, 49, 41, 52, DateTimeKind.Local).AddTicks(9798) },
                    { 3, "Initial", new DateTime(2020, 5, 4, 20, 49, 41, 52, DateTimeKind.Local).AddTicks(9827), 3, "Dział BHP - Stocznia Gdynia", "BHP/340/19", "Szkolenie BHP - Stocznia Gdynia", null, null, new DateTime(2020, 5, 4, 20, 49, 41, 52, DateTimeKind.Local).AddTicks(9829), new DateTime(2022, 5, 4, 20, 49, 41, 52, DateTimeKind.Local).AddTicks(9832) },
                    { 2, "Initial", new DateTime(2020, 5, 4, 20, 49, 41, 52, DateTimeKind.Local).AddTicks(9817), 2, "Dział BHP - Stocznia Gdynia", "BHP/339/19", "Szkolenie BHP - Stocznia Gdynia", null, null, new DateTime(2020, 5, 4, 20, 49, 41, 52, DateTimeKind.Local).AddTicks(9820), new DateTime(2022, 5, 4, 20, 49, 41, 52, DateTimeKind.Local).AddTicks(9823) }
                });

            migrationBuilder.InsertData(
                table: "Advances",
                columns: new[] { "Id", "Amount", "ContractId", "CreatedBy", "CreatedOn", "PaidOn", "UpdatedBy", "UpdatedOn", "WorkedHours" },
                values: new object[,]
                {
                    { 1, 1100m, 14, "Initial", new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 70 },
                    { 4, 2000m, 17, "Initial", new DateTime(2021, 1, 9, 20, 49, 41, 59, DateTimeKind.Local).AddTicks(2179), null, null, null, 10 },
                    { 2, 900m, 15, "Initial", new DateTime(2020, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 80 },
                    { 5, 2500m, 18, "Initial", new DateTime(2021, 1, 9, 20, 49, 41, 59, DateTimeKind.Local).AddTicks(2182), null, null, null, 10 },
                    { 3, 1000m, 16, "Initial", new DateTime(2020, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 86 },
                    { 6, 500m, 19, "Initial", new DateTime(2021, 1, 9, 20, 49, 41, 59, DateTimeKind.Local).AddTicks(2185), new DateTime(2021, 1, 9, 20, 49, 41, 59, DateTimeKind.Local).AddTicks(2188), null, null, 16 }
                });

            migrationBuilder.InsertData(
                table: "EmployeesHistory",
                columns: new[] { "Id", "City", "Country", "CreatedBy", "CreatedOn", "EmployeeId", "ForemanId", "LastName", "LocationId", "Number", "PhoneNo", "Profession", "Region", "Street", "UpdatedBy", "UpdatedOn", "Zip" },
                values: new object[,]
                {
                    { 1, "Kosokowo", "Polska", "Initial", new DateTime(2020, 3, 15, 20, 49, 41, 51, DateTimeKind.Local).AddTicks(4460), 1, 1, "Maciejewski", 1, "26C", "608 767 878", "Monter Okrętowy", "Pomorze", "Rzemieślnicza", null, null, "81-198" },
                    { 2, "Rumia", "Polska", "Initial", new DateTime(2020, 5, 4, 20, 49, 41, 51, DateTimeKind.Local).AddTicks(7127), 2, 2, "Kravchuk", 1, "20A", "982 280 556", "Szlifierz Okrętowy", "Pomorze", "Świętopełka", null, null, "84-230" },
                    { 3, "Gdynia", "Polska", "Initial", new DateTime(2020, 5, 4, 20, 49, 41, 51, DateTimeKind.Local).AddTicks(7185), 3, 2, "Kuchna", 1, "6", "777 090 210", "Szlifierz Okrętowy", "Pomorze", "Spokojna", null, null, "81-549" },
                    { 5, "Pogórze", "Polska", "Initial", new DateTime(2020, 8, 12, 20, 49, 41, 51, DateTimeKind.Local).AddTicks(7194), 4, 2, "Yushchenko", 1, "13", "606 852 298", "Monter Okrętowy", "Pomorze", "Wapienna", null, null, "81-198" },
                    { 4, "Gdańsk", "Polska", "Initial", new DateTime(2020, 6, 23, 20, 49, 41, 51, DateTimeKind.Local).AddTicks(7190), 1, 3, "Maciejewski", 2, "12", null, "Spawacz Okrętowy", "Pomorze", "Ks. Mariana Góreckiego", null, null, "80-553" },
                    { 6, "Gdańsk", "Polska", "Initial", new DateTime(2020, 10, 1, 20, 49, 41, 51, DateTimeKind.Local).AddTicks(7197), 1, 3, "Maciejewski", 2, "3-1", "608 767 878", "Spawacz Okrętowy", "Pomorze", "Nadmorski Dwór", null, null, "80-506" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Advances_ContractId",
                table: "Advances",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_EmployeeId",
                table: "Certificates",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_EmployeeId",
                table: "Contracts",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesHistory_EmployeeId",
                table: "EmployeesHistory",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesHistory_ForemanId",
                table: "EmployeesHistory",
                column: "ForemanId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesHistory_LocationId",
                table: "EmployeesHistory",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Foremen_LocationId",
                table: "Foremen",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Leaves_EmployeeId",
                table: "Leaves",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCheckups_EmployeeId",
                table: "MedicalCheckups",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_SafetyTrainings_EmployeeId",
                table: "SafetyTrainings",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advances");

            migrationBuilder.DropTable(
                name: "Certificates");

            migrationBuilder.DropTable(
                name: "ConfigurationPage");

            migrationBuilder.DropTable(
                name: "EmployeesHistory");

            migrationBuilder.DropTable(
                name: "Leaves");

            migrationBuilder.DropTable(
                name: "MedicalCheckups");

            migrationBuilder.DropTable(
                name: "SafetyTrainings");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "Foremen");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
