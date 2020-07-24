using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class Initial : Migration
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
                    MaximumLeaveTimeInDays = table.Column<int>(nullable: false),
                    WarningBeforeLeaveReachesLimit = table.Column<int>(nullable: false),
                    WarningBeforeMedicalCheckupExpires = table.Column<int>(nullable: false),
                    WarningBeforeSafetyTrainingExpires = table.Column<int>(nullable: false),
                    WarningBeforeCertificateExpires = table.Column<int>(nullable: false),
                    WarningBeforeVisaExpires = table.Column<int>(nullable: false),
                    WarningBeforePermitExpires = table.Column<int>(nullable: false),
                    WarningBeforePassportExpires = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigurationPage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeAddresses",
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
                    Number = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeAddresses", x => x.Id);
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
                    Value = table.Column<decimal>(nullable: false),
                    HourlySalary = table.Column<decimal>(nullable: false),
                    TaxPercent = table.Column<decimal>(nullable: false),
                    ContractSubject = table.Column<string>(nullable: true),
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
                name: "Passports",
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
                    table.PrimaryKey("PK_Passports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Passports_Employees_EmployeeId",
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
                name: "Visas",
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
                    EmployeeId = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Visas_Employees_EmployeeId",
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
                name: "Permits",
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
                    EmployeeId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permits_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Permits_Locations_LocationId",
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
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    PaidOn = table.Column<DateTime>(nullable: true),
                    GrossAmount = table.Column<decimal>(nullable: false),
                    NetAmount = table.Column<decimal>(nullable: false),
                    ContractId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payment_Contracts_ContractId",
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
                    LastName = table.Column<string>(nullable: true),
                    Profession = table.Column<string>(nullable: true),
                    PhoneNo = table.Column<string>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: true),
                    ForemanId = table.Column<int>(nullable: true),
                    EmployeeAddressId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeesHistory_EmployeeAddresses_EmployeeAddressId",
                        column: x => x.EmployeeAddressId,
                        principalTable: "EmployeeAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                columns: new[] { "Id", "BillingMonthEnd", "BillingMonthStart", "CreatedBy", "CreatedOn", "MaximumLeaveTimeInDays", "PercentOfAdvancesAllowed", "UpdatedBy", "UpdatedOn", "WarningBeforeCertificateExpires", "WarningBeforeLeaveReachesLimit", "WarningBeforeMedicalCheckupExpires", "WarningBeforePassportExpires", "WarningBeforePermitExpires", "WarningBeforeSafetyTrainingExpires", "WarningBeforeVisaExpires" },
                values: new object[] { 1, 25, 26, "Initial", new DateTime(2020, 7, 22, 16, 20, 21, 905, DateTimeKind.Local).AddTicks(4528), 90, 75.0, null, null, 30, 60, 30, 30, 30, 30, 30 });

            migrationBuilder.InsertData(
                table: "EmployeeAddresses",
                columns: new[] { "Id", "City", "Country", "CreatedBy", "CreatedOn", "Number", "Region", "Street", "UpdatedBy", "UpdatedOn", "Zip" },
                values: new object[,]
                {
                    { 6, "Gdańsk", "Polska", "Initial", new DateTime(2020, 4, 13, 16, 20, 21, 908, DateTimeKind.Local).AddTicks(453), "3-1", "Pomorze", "Nadmorski Dwór", null, null, "80-506" },
                    { 5, "Pogórze", "Polska", "Initial", new DateTime(2020, 2, 23, 16, 20, 21, 908, DateTimeKind.Local).AddTicks(449), "13", "Pomorze", "Wapienna", null, null, "81-198" },
                    { 4, "Gdańsk", "Polska", "Initial", new DateTime(2020, 1, 4, 16, 20, 21, 908, DateTimeKind.Local).AddTicks(446), "12", "Pomorze", "Ks. Mariana Góreckiego", null, null, "80-553" },
                    { 3, "Gdynia", "Polska", "Initial", new DateTime(2019, 11, 15, 16, 20, 21, 908, DateTimeKind.Local).AddTicks(443), "6", "Pomorze", "Spokojna", null, null, "81-549" },
                    { 2, "Rumia", "Polska", "Initial", new DateTime(2019, 11, 15, 16, 20, 21, 908, DateTimeKind.Local).AddTicks(438), "20A", "Pomorze", "Świętopełka", null, null, "84-230" },
                    { 1, "Kosokowo", "Polska", "Initial", new DateTime(2019, 9, 26, 16, 20, 21, 908, DateTimeKind.Local).AddTicks(405), "26C", "Pomorze", "Rzemieślnicza", null, null, "81-198" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DateOfBirth", "FatherName", "FirstName", "IsArchived", "MotherName", "Nationality", "Pesel", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 4, "Initial", new DateTime(2020, 2, 23, 16, 20, 21, 906, DateTimeKind.Local).AddTicks(5596), new DateTime(1997, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maxim", "Yevhenii", false, "Zlata", "Ukraina", "97022012345", null, null },
                    { 2, "Initial", new DateTime(2019, 11, 15, 16, 20, 21, 906, DateTimeKind.Local).AddTicks(5526), new DateTime(1997, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vitalii", "Dmyto", false, "Svetlana", "Ukraina", "", null, null },
                    { 1, "Initial", new DateTime(2019, 9, 26, 16, 20, 21, 906, DateTimeKind.Local).AddTicks(2947), new DateTime(1980, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mariusz", "Maciej", false, "Mariola", "Polska", "80012100000", null, null },
                    { 3, "Initial", new DateTime(2019, 11, 15, 16, 20, 21, 906, DateTimeKind.Local).AddTicks(5591), new DateTime(1993, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oleksii", "Oleksandr", false, "Oleksandra", "Ukraina", "", null, null }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "City", "Country", "CreatedBy", "CreatedOn", "Name", "Number", "Region", "Street", "UpdatedBy", "UpdatedOn", "Zip" },
                values: new object[,]
                {
                    { 1, "Gdynia", "Polska", "Initial", new DateTime(2019, 9, 26, 16, 20, 21, 906, DateTimeKind.Local).AddTicks(8529), "Stocznia Gdynia SA", "3", "Pomorze", "Czechosłowacka", null, null, "81-336" },
                    { 2, "Gdańsk", "Polska", "Initial", new DateTime(2019, 11, 15, 16, 20, 21, 907, DateTimeKind.Local).AddTicks(1362), "Stocznia Remontowa Gdańsk", "8", "Pomorze", "Swojska", null, null, "80-958" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Email", "FirstName", "Hash", "IsActive", "LastName", "RequestedPasswordReset", "Role", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Administrator", "Administrator", "WSX_09", true, "", false, "Administrator", null, null },
                    { 3, "Initial", new DateTime(2020, 7, 22, 16, 20, 21, 904, DateTimeKind.Local).AddTicks(2341), "Maria.Niziolek@PersonelManager.pl", "Maria", "ZZZ", false, "Niziolek", false, "Pracownik", null, null },
                    { 2, "Initial", new DateTime(2020, 7, 22, 16, 20, 21, 904, DateTimeKind.Local).AddTicks(2273), "Jan.Nowak@PersonelManager.pl", "Jan", "YYY", true, "Nowak", true, "Pracownik", null, null },
                    { 1, "Initial", new DateTime(2020, 7, 22, 16, 20, 21, 901, DateTimeKind.Local).AddTicks(1525), "Jan.Kowalski@PersonelManager.pl", "Jan", "WWW", true, "Kowalski", false, "Kierownik", null, null }
                });

            migrationBuilder.InsertData(
                table: "Certificates",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "EmployeeId", "IssuedBy", "Number", "Title", "UpdatedBy", "UpdatedOn", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 1, "Initial", new DateTime(2019, 9, 26, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(4809), 1, "Szkółka monterów Jastrząb", "PS/34/20", "Kurs palenia i szczepiania palnikiem gazowym", null, null, new DateTime(2018, 7, 22, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(4825), new DateTime(2023, 7, 22, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(4829) },
                    { 2, "Initial", new DateTime(2020, 1, 4, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(4847), 1, "DNV", "DNV/086/2020", "Placówka szkoleniowa spawaczy - Stocznia Gdańsk", null, null, new DateTime(2020, 1, 4, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(4850), new DateTime(2023, 1, 3, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(4853) },
                    { 3, "Initial", new DateTime(2020, 2, 23, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(4856), 4, "Zakład szkolenia monterów w Harkowie", "HR/127/20", "Kurs palenia i szczepiania palnikiem gazowym", null, null, new DateTime(2016, 2, 23, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(4859), new DateTime(2020, 8, 20, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(4862) }
                });

            migrationBuilder.InsertData(
                table: "Contracts",
                columns: new[] { "Id", "ContractSubject", "CreatedBy", "CreatedOn", "EmployeeId", "HourlySalary", "IsRealized", "IssuedBy", "Number", "TaxPercent", "Title", "UpdatedBy", "UpdatedOn", "ValidFrom", "ValidTo", "Value" },
                values: new object[,]
                {
                    { 19, "Montaż barierek ochronnych na jednostce NB231", "Initial", new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 20m, false, null, "3/07/2020", 14.0m, "Umowa za lipiec", null, null, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(7875), 4000m },
                    { 16, "Montaż barierek ochronnych na jednostce NB231", "Initial", new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 20m, true, null, "3/06/2020", 14.0m, "Umowa za czerwiec", null, null, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(7820), 4000m },
                    { 13, "Montaż trapu na jednostce NB231", "Initial", new DateTime(2020, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 20m, true, null, "3/05/2020", 14.0m, "Umowa za maj", null, null, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(7719), 4000m },
                    { 10, "Montaż trapu na jednostce NB230", "Initial", new DateTime(2020, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 20m, true, null, "3/04/2020", 14.0m, "Umowa za kwiecień", null, null, new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(7660), 4000m },
                    { 7, "Wypalenie otworu technicznego 23 na jednostce NB230", "Initial", new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 20m, true, null, "3/03/2020", 14.0m, "Umowa za marzec", null, null, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(7602), 4000m },
                    { 9, "Oszlifowanie wręgów 11-201 na jednostce NB230", "Initial", new DateTime(2020, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 15m, true, null, "2/04/2020", 14.0m, "Umowa za kwiecień", null, null, new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(7641), 3000m },
                    { 6, "Oszlifowanie schodów na jednostce NB230", "Initial", new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 15m, true, null, "2/03/2020", 14.0m, "Umowa za marzec", null, null, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(7583), 3000m },
                    { 4, "Oszlifowanie zbiornika ZL15", "Initial", new DateTime(2020, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 15m, true, null, "3/02/2020", 14.0m, "Umowa za luty", null, null, new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(7544), 3000m },
                    { 18, "Oszlifowanie wręgów zbiorników wody pitnej P12-P32", "Initial", new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 15m, false, null, "2/07/2020", 14.0m, "Umowa za lipiec", null, null, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(7857), 3000m },
                    { 15, "Oszlifowanie wręgów zbiorników wody pitnej P12-P32", "Initial", new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 15m, true, null, "2/06/2020", 14.0m, "Umowa za czerwiec", null, null, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(7757), 3000m },
                    { 3, "Oszlifowanie trapa na jednostce NB230", "Initial", new DateTime(2020, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 15m, true, null, "2/02/2020", 14.0m, "Umowa za luty", null, null, new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(7523), 3000m },
                    { 12, "Oszlifowanie wręgów 11-201 na jednostce NB231", "Initial", new DateTime(2020, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 15m, true, null, "2/05/2020", 14.0m, "Umowa za maj", null, null, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(7699), 3000m },
                    { 5, "Przyspawanie wręgów 201-421 na jednostce WZ211", "Initial", new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 25m, true, null, "1/03/2020", 14.0m, "Umowa za marzec", null, null, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(7564), 5000m },
                    { 1, "Montaż obarierowania ochronnego na jednostce NB230", "Initial", new DateTime(2019, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 20m, true, null, "1/01/2020", 14.0m, "Umowa za styczeń", null, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(6159), 4000m },
                    { 2, "Przyspawanie wręgów 11-201 na jednostce WZ211", "Initial", new DateTime(2020, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 25m, true, null, "1/02/2020", 14.0m, "Umowa za luty", null, null, new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(7457), 5000m },
                    { 8, "Przyspawanie haków technocznych do płatu P11", "Initial", new DateTime(2020, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 25m, true, null, "1/04/2020", 14.0m, "Umowa za kwiecień", null, null, new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(7622), 5000m },
                    { 11, "Przyspawanie haków technocznych do płatu P12", "Initial", new DateTime(2020, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 25m, true, null, "1/05/2020", 14.0m, "Umowa za maj", null, null, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(7680), 5000m },
                    { 14, "Przyspawanie sekcji okętowych NW23-NW24", "Initial", new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 25m, true, null, "1/06/2020", 14.0m, "Umowa za czerwiec", null, null, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(7738), 5000m },
                    { 17, "Przyspawanie sekcji okętowych NW23-NW24", "Initial", new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 25m, false, null, "1/07/2020", 14.0m, "Umowa za lipiec", null, null, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(7839), 5000m }
                });

            migrationBuilder.InsertData(
                table: "Foremen",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "FirstName", "LastName", "LocationId", "Mail", "PhoneNo", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 2, "Initial", new DateTime(2019, 11, 15, 16, 20, 21, 907, DateTimeKind.Local).AddTicks(6305), "Jakub", "Jakubczyk", 1, "J.Jakubczyk@StoczniaGdynia.pl", "+58 608 385 513", null, null },
                    { 1, "Initial", new DateTime(2019, 9, 26, 16, 20, 21, 907, DateTimeKind.Local).AddTicks(4261), "Grzegorz", "Grzegorczuk", 1, "G.Grzegorczuk@StoczniaGdynia.pl", "+58 608 385 512", null, null },
                    { 3, "Initial", new DateTime(2020, 1, 4, 16, 20, 21, 907, DateTimeKind.Local).AddTicks(6366), "Filip", "Filipiak", 2, "Filip.Filipiak@Remontowa.pl", "+58 808 100 001", null, null }
                });

            migrationBuilder.InsertData(
                table: "Leaves",
                columns: new[] { "Id", "Comment", "CreatedBy", "CreatedOn", "EmployeeId", "From", "To", "Type", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, "Urlop wypoczynkowy, 14 dni", "Initial", new DateTime(2019, 11, 15, 16, 20, 21, 912, DateTimeKind.Local).AddTicks(1597), 1, new DateTime(2019, 12, 1, 16, 20, 21, 912, DateTimeKind.Local).AddTicks(2070), new DateTime(2019, 12, 15, 16, 20, 21, 912, DateTimeKind.Local).AddTicks(2588), "Wypoczynkowy", null, null },
                    { 3, "Obecność nieusprawiedliwiona", "Initial", new DateTime(2020, 5, 22, 16, 20, 21, 912, DateTimeKind.Local).AddTicks(4031), 1, new DateTime(2020, 5, 22, 16, 20, 21, 912, DateTimeKind.Local).AddTicks(4034), null, "Nieusprawiedliwiony", null, null },
                    { 2, "Urlop Administracyjny, wymiana paszporty, wizy", "Initial", new DateTime(2020, 2, 16, 16, 20, 21, 912, DateTimeKind.Local).AddTicks(3981), 2, new DateTime(2020, 2, 23, 16, 20, 21, 912, DateTimeKind.Local).AddTicks(4001), new DateTime(2020, 5, 3, 16, 20, 21, 912, DateTimeKind.Local).AddTicks(4010), "Administracyjny", null, null }
                });

            migrationBuilder.InsertData(
                table: "MedicalCheckups",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "EmployeeId", "IssuedBy", "Number", "Title", "UpdatedBy", "UpdatedOn", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 2, "Initial", new DateTime(2019, 11, 15, 16, 20, 21, 909, DateTimeKind.Local).AddTicks(6646), 2, "DiamentMed sp. z o.o.", "DM-076-19", "Badanie lekarskie wstępne", null, null, new DateTime(2018, 8, 21, 16, 20, 21, 909, DateTimeKind.Local).AddTicks(6704), new DateTime(2020, 8, 21, 16, 20, 21, 909, DateTimeKind.Local).AddTicks(6720) },
                    { 4, "Initial", new DateTime(2019, 11, 15, 16, 20, 21, 909, DateTimeKind.Local).AddTicks(6739), 2, "DiamentMed sp. z o.o.", "DM-178-19", "Badanie lekarskie wstępne", null, null, new DateTime(2019, 2, 22, 16, 20, 21, 909, DateTimeKind.Local).AddTicks(6742), new DateTime(2021, 2, 22, 16, 20, 21, 909, DateTimeKind.Local).AddTicks(6745) },
                    { 1, "Initial", new DateTime(2019, 9, 26, 16, 20, 21, 909, DateTimeKind.Local).AddTicks(4048), 1, "Prywatna praktyka - Dr Kamiński", "MD/016/19", "Badanie lekarskie wstępne", null, null, new DateTime(2018, 8, 20, 16, 20, 21, 909, DateTimeKind.Local).AddTicks(5695), new DateTime(2020, 8, 20, 16, 20, 21, 909, DateTimeKind.Local).AddTicks(6193) },
                    { 3, "Initial", new DateTime(2019, 11, 15, 16, 20, 21, 909, DateTimeKind.Local).AddTicks(6729), 2, "DiamentMed sp. z o.o.", "DM-177-19", "Badanie lekarskie wstępne", null, null, new DateTime(2018, 11, 14, 16, 20, 21, 909, DateTimeKind.Local).AddTicks(6732), new DateTime(2020, 11, 14, 16, 20, 21, 909, DateTimeKind.Local).AddTicks(6735) }
                });

            migrationBuilder.InsertData(
                table: "Passports",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "EmployeeId", "IssuedBy", "Number", "Title", "UpdatedBy", "UpdatedOn", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 1, "Initial", new DateTime(2019, 11, 15, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(8780), 2, "Biuro Paszportowe w Kijowie", "UKR090909", "Paszport Ukraina", null, null, new DateTime(2010, 2, 22, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(8797), new DateTime(2020, 2, 23, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(8801) },
                    { 3, "Initial", new DateTime(2020, 2, 23, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(8830), 4, "Biuro Paszportowe w Lwowie", "LWR12309", "Paszport Ukraina", null, null, new DateTime(2010, 8, 20, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(8832), new DateTime(2049, 7, 22, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(8836) },
                    { 2, "Initial", new DateTime(2019, 11, 15, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(8820), 3, "Biuro Paszportowe w Harkowie", "HKR05409", "Paszport Ukraina", null, null, new DateTime(2019, 7, 22, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(8823), new DateTime(2029, 7, 22, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(8826) },
                    { 4, "Initial", new DateTime(2020, 5, 3, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(8839), 2, "Biuro Paszportowe w Kijowie", "UKR191919", "Paszport Ukraina", null, null, new DateTime(2020, 4, 13, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(8842), new DateTime(2030, 4, 13, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(8845) }
                });

            migrationBuilder.InsertData(
                table: "Permits",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "EmployeeId", "IssuedBy", "LocationId", "Number", "Title", "UpdatedBy", "UpdatedOn", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 4, "Initial", new DateTime(2020, 4, 13, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(8084), 2, "Urząd wojewódzki w Gdańsku, wydział ds. cudzoziemców", 1, "A/216/2020", "Zezwolenie na pracę typ A", null, null, new DateTime(2020, 4, 13, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(8087), new DateTime(2023, 4, 13, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(8090) },
                    { 2, "Initial", new DateTime(2020, 2, 23, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(8057), 3, "Urząd wojewódzki w Gdańsku, wydział ds. cudzoziemców", 1, "KP/55/2020", "Karta Pobytu", null, null, new DateTime(2020, 2, 23, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(8067), new DateTime(2025, 2, 22, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(8070) },
                    { 3, "Initial", new DateTime(2020, 2, 23, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(8075), 4, "Urząd wojewódzki w Gdańsku, wydział ds. cudzoziemców", 1, "A/196/2020", "Zezwolenie na pracę typ A", null, null, new DateTime(2019, 8, 20, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(8078), new DateTime(2020, 8, 20, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(8081) },
                    { 1, "Initial", new DateTime(2019, 11, 15, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(7560), 2, "Panśtwowy Urząd Pracy w Gdyni", 1, "OSW/575/2019", "Oświadczenie o zamiarze powierzenia pracy", null, null, new DateTime(2019, 11, 15, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(8026), new DateTime(2020, 2, 23, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(8039) }
                });

            migrationBuilder.InsertData(
                table: "SafetyTrainings",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "EmployeeId", "IssuedBy", "Number", "Title", "UpdatedBy", "UpdatedOn", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 2, "Initial", new DateTime(2019, 11, 15, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(1465), 2, "Dział BHP - Stocznia Gdynia", "BHP/339/19", "Szkolenie BHP - Stocznia Gdynia", null, null, new DateTime(2019, 11, 15, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(1469), new DateTime(2021, 11, 14, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(1471) },
                    { 5, "Initial", new DateTime(2020, 1, 4, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(1492), 4, "Dział BHP - Stocznia Gdynia", "BHP/440/19", "Szkolenie BHP - Stocznia Gdynia", null, null, new DateTime(2020, 2, 23, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(1495), new DateTime(2022, 2, 22, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(1497) },
                    { 4, "Initial", new DateTime(2020, 1, 4, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(1484), 1, "Kierownik działu BHP - Ignacy Krasiński", "BHP-940-19", "Szkolenie Wstępne BHP - Stocznia Gdańsk", null, null, new DateTime(2020, 1, 4, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(1487), new DateTime(2021, 1, 3, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(1489) },
                    { 1, "Initial", new DateTime(2019, 9, 26, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(1424), 1, "Dział BHP - Stocznia Gdynia", "BHP/99/19", "Szkolenie BHP - Stocznia Gdynia", null, null, new DateTime(2019, 9, 26, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(1441), new DateTime(2021, 9, 25, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(1444) },
                    { 3, "Initial", new DateTime(2019, 11, 15, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(1475), 3, "Dział BHP - Stocznia Gdynia", "BHP/340/19", "Szkolenie BHP - Stocznia Gdynia", null, null, new DateTime(2019, 11, 15, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(1478), new DateTime(2021, 11, 14, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(1481) }
                });

            migrationBuilder.InsertData(
                table: "Visas",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "EmployeeId", "IssuedBy", "Number", "Title", "Type", "UpdatedBy", "UpdatedOn", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 3, "Initial", new DateTime(2020, 2, 23, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(3548), 4, "Konsul w Kijowie", "PL053452", "Wiza krajowa", "D", null, null, new DateTime(2019, 8, 20, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(3551), new DateTime(2020, 8, 20, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(3554) },
                    { 1, "Initial", new DateTime(2019, 11, 15, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(3491), 2, "Konsul w Kijowie", "PL053452", "Wiza krajowa", "D", null, null, new DateTime(2019, 2, 22, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(3521), new DateTime(2020, 2, 23, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(3526) },
                    { 2, "Initial", new DateTime(2020, 2, 23, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(3538), 3, "Konsul w Kijowie", "PL053452", "Wiza krajowa", "D", null, null, new DateTime(2020, 2, 23, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(3541), new DateTime(2021, 2, 22, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(3543) },
                    { 4, "Initial", new DateTime(2020, 5, 3, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(3557), 2, "Konsul w Kijowie", "PL053452", "Wiza krajowa", "D", null, null, new DateTime(2020, 4, 13, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(3560), new DateTime(2021, 4, 13, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(3562) }
                });

            migrationBuilder.InsertData(
                table: "Advances",
                columns: new[] { "Id", "Amount", "ContractId", "CreatedBy", "CreatedOn", "PaidOn", "UpdatedBy", "UpdatedOn", "WorkedHours" },
                values: new object[,]
                {
                    { 1, 1100m, 14, "Initial", new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 70 },
                    { 4, 2000m, 17, "Initial", new DateTime(2020, 7, 22, 16, 20, 21, 917, DateTimeKind.Local).AddTicks(5078), null, null, null, 10 },
                    { 2, 900m, 15, "Initial", new DateTime(2020, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 80 },
                    { 5, 2500m, 18, "Initial", new DateTime(2020, 7, 22, 16, 20, 21, 917, DateTimeKind.Local).AddTicks(5081), null, null, null, 10 },
                    { 3, 1000m, 16, "Initial", new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 86 },
                    { 6, 500m, 19, "Initial", new DateTime(2020, 7, 22, 16, 20, 21, 917, DateTimeKind.Local).AddTicks(5084), new DateTime(2020, 7, 22, 16, 20, 21, 917, DateTimeKind.Local).AddTicks(5087), null, null, 16 }
                });

            migrationBuilder.InsertData(
                table: "EmployeesHistory",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "EmployeeAddressId", "EmployeeId", "ForemanId", "LastName", "LocationId", "PhoneNo", "Profession", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 6, "Initial", new DateTime(2020, 4, 13, 16, 20, 21, 908, DateTimeKind.Local).AddTicks(9011), 6, 1, 3, "Maciejewski", 2, "608 767 878", "Spawacz Okrętowy", null, null },
                    { 5, "Initial", new DateTime(2020, 2, 23, 16, 20, 21, 908, DateTimeKind.Local).AddTicks(9008), 5, 4, 2, "Yushchenko", 1, "606 852 298", "Monter Okrętowy", null, null },
                    { 3, "Initial", new DateTime(2019, 11, 15, 16, 20, 21, 908, DateTimeKind.Local).AddTicks(9000), 3, 3, 2, "Kuchna", 1, "777 090 210", "Szlifierz Okrętowy", null, null },
                    { 2, "Initial", new DateTime(2019, 11, 15, 16, 20, 21, 908, DateTimeKind.Local).AddTicks(8918), 2, 2, 2, "Kravchuk", 1, "982 280 556", "Szlifierz Okrętowy", null, null },
                    { 4, "Initial", new DateTime(2020, 1, 4, 16, 20, 21, 908, DateTimeKind.Local).AddTicks(9004), 4, 1, 3, "Maciejewski", 2, null, "Spawacz Okrętowy", null, null },
                    { 1, "Initial", new DateTime(2019, 9, 26, 16, 20, 21, 908, DateTimeKind.Local).AddTicks(5952), 1, 1, 1, "Maciejewski", 1, "608 767 878", "Monter Okrętowy", null, null }
                });

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "Id", "ContractId", "CreatedBy", "CreatedOn", "GrossAmount", "NetAmount", "PaidOn", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 3, 13, "Initial", new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4000m, 3440.00m, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 5, 15, "Initial", new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3000m, 2580.00m, new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 2, 12, "Initial", new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3000m, 2580.00m, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 4, 14, "Initial", new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5000m, 4300.00m, new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 6, 16, "Initial", new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4000m, 3440.00m, new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 1, 11, "Initial", new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5000m, 4300.00m, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null }
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
                name: "IX_EmployeesHistory_EmployeeAddressId",
                table: "EmployeesHistory",
                column: "EmployeeAddressId");

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
                name: "IX_Passports_EmployeeId",
                table: "Passports",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_ContractId",
                table: "Payment",
                column: "ContractId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Permits_EmployeeId",
                table: "Permits",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Permits_LocationId",
                table: "Permits",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_SafetyTrainings_EmployeeId",
                table: "SafetyTrainings",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Visas_EmployeeId",
                table: "Visas",
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
                name: "Passports");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Permits");

            migrationBuilder.DropTable(
                name: "SafetyTrainings");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Visas");

            migrationBuilder.DropTable(
                name: "EmployeeAddresses");

            migrationBuilder.DropTable(
                name: "Foremen");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
