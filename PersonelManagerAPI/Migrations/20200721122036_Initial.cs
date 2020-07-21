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
                name: "EmployeeAddress",
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
                    table.PrimaryKey("PK_EmployeeAddress", x => x.Id);
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
                name: "Location",
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
                    table.PrimaryKey("PK_Location", x => x.Id);
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
                    Hash = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    RequestedPasswordReset = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Certificate",
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
                    table.PrimaryKey("PK_Certificate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Certificate_Employees_EmployeeId",
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
                    EmployeeId = table.Column<int>(nullable: false),
                    Value = table.Column<decimal>(nullable: false),
                    HourlySalary = table.Column<decimal>(nullable: false),
                    TaxPercent = table.Column<decimal>(nullable: false),
                    ContractSubject = table.Column<string>(nullable: true),
                    IsRealized = table.Column<bool>(nullable: false)
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
                name: "Leave",
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
                    table.PrimaryKey("PK_Leave", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Leave_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalCheckup",
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
                    table.PrimaryKey("PK_MedicalCheckup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalCheckup_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Passport",
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
                    table.PrimaryKey("PK_Passport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Passport_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SafetyTraining",
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
                    table.PrimaryKey("PK_SafetyTraining", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SafetyTraining_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Visa",
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
                    table.PrimaryKey("PK_Visa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Visa_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Foreman",
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
                    table.PrimaryKey("PK_Foreman", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Foreman_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Permit",
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
                    table.PrimaryKey("PK_Permit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permit_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Permit_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
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
                name: "EmployeeHistory",
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
                    EmployeeId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: true),
                    ForemanId = table.Column<int>(nullable: true),
                    EmployeeAddressId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeHistory_EmployeeAddress_EmployeeAddressId",
                        column: x => x.EmployeeAddressId,
                        principalTable: "EmployeeAddress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeHistory_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeHistory_Foreman_ForemanId",
                        column: x => x.ForemanId,
                        principalTable: "Foreman",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeHistory_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ConfigurationPage",
                columns: new[] { "Id", "BillingMonthEnd", "BillingMonthStart", "CreatedBy", "CreatedOn", "MaximumLeaveTimeInDays", "PercentOfAdvancesAllowed", "UpdatedBy", "UpdatedOn", "WarningBeforeCertificateExpires", "WarningBeforeLeaveReachesLimit", "WarningBeforeMedicalCheckupExpires", "WarningBeforePassportExpires", "WarningBeforePermitExpires", "WarningBeforeSafetyTrainingExpires", "WarningBeforeVisaExpires" },
                values: new object[] { 1, 25, 26, "Initial", new DateTime(2020, 7, 21, 14, 20, 36, 316, DateTimeKind.Local).AddTicks(7096), 90, 75.0, null, null, 30, 60, 30, 30, 30, 30, 30 });

            migrationBuilder.InsertData(
                table: "EmployeeAddress",
                columns: new[] { "Id", "City", "Country", "CreatedBy", "CreatedOn", "Number", "Region", "Street", "UpdatedBy", "UpdatedOn", "Zip" },
                values: new object[,]
                {
                    { 6, "Gdańsk", "Polska", "Initial", new DateTime(2020, 4, 12, 14, 20, 36, 319, DateTimeKind.Local).AddTicks(2775), "3-1", "Pomorze", "Nadmorski Dwór", null, null, "80-506" },
                    { 5, "Pogórze", "Polska", "Initial", new DateTime(2020, 2, 22, 14, 20, 36, 319, DateTimeKind.Local).AddTicks(2772), "13", "Pomorze", "Wapienna", null, null, "81-198" },
                    { 4, "Gdańsk", "Polska", "Initial", new DateTime(2020, 1, 3, 14, 20, 36, 319, DateTimeKind.Local).AddTicks(2769), "12", "Pomorze", "Ks. Mariana Góreckiego", null, null, "80-553" },
                    { 3, "Gdynia", "Polska", "Initial", new DateTime(2019, 11, 14, 14, 20, 36, 319, DateTimeKind.Local).AddTicks(2765), "6", "Pomorze", "Spokojna", null, null, "81-549" },
                    { 2, "Rumia", "Polska", "Initial", new DateTime(2019, 11, 14, 14, 20, 36, 319, DateTimeKind.Local).AddTicks(2761), "20A", "Pomorze", "Świętopełka", null, null, "84-230" },
                    { 1, "Kosokowo", "Polska", "Initial", new DateTime(2019, 9, 25, 14, 20, 36, 319, DateTimeKind.Local).AddTicks(2729), "26C", "Pomorze", "Rzemieślnicza", null, null, "81-198" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DateOfBirth", "FatherName", "FirstName", "IsArchived", "MotherName", "Nationality", "Pesel", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 4, "Initial", new DateTime(2020, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1997, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maxim", "Yevhenii", false, "Zlata", "Ukraina", "97022012345", null, null },
                    { 2, "Initial", new DateTime(2019, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1997, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vitalii", "Dmyto", false, "Svetlana", "Ukraina", "", null, null },
                    { 1, "Initial", new DateTime(2019, 9, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1980, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mariusz", "Maciej", false, "Mariola", "Polska", "80012100000", null, null },
                    { 3, "Initial", new DateTime(2019, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1993, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oleksii", "Oleksandr", false, "Oleksandra", "Ukraina", "", null, null }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "City", "Country", "CreatedBy", "CreatedOn", "Name", "Number", "Region", "Street", "UpdatedBy", "UpdatedOn", "Zip" },
                values: new object[,]
                {
                    { 1, "Gdynia", "Polska", "Initial", new DateTime(2019, 9, 25, 14, 20, 36, 318, DateTimeKind.Local).AddTicks(862), "Stocznia Gdynia SA", "3", "Pomorze", "Czechosłowacka", null, null, "81-336" },
                    { 2, "Gdańsk", "Polska", "Initial", new DateTime(2019, 11, 14, 14, 20, 36, 318, DateTimeKind.Local).AddTicks(3641), "Stocznia Remontowa Gdańsk", "8", "Pomorze", "Swojska", null, null, "80-958" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Email", "FirstName", "Hash", "IsActive", "LastName", "RequestedPasswordReset", "Role", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Administrator", "Administrator", "WSX_09", true, "", false, "Administrator", null, null },
                    { 3, "Initial", new DateTime(2020, 7, 21, 14, 20, 36, 315, DateTimeKind.Local).AddTicks(4741), "Maria.Niziolek@PersonelManager.pl", "Maria", "ZZZ", false, "Niziolek", false, "Pracownik", null, null },
                    { 2, "Initial", new DateTime(2020, 7, 21, 14, 20, 36, 315, DateTimeKind.Local).AddTicks(4657), "Jan.Nowak@PersonelManager.pl", "Jan", "YYY", true, "Nowak", true, "Pracownik", null, null },
                    { 1, "Initial", new DateTime(2020, 7, 21, 14, 20, 36, 312, DateTimeKind.Local).AddTicks(6795), "Jan.Kowalski@PersonelManager.pl", "Jan", "WWW", true, "Kowalski", false, "Kierownik", null, null }
                });

            migrationBuilder.InsertData(
                table: "Certificate",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "EmployeeId", "IssuedBy", "Number", "Title", "UpdatedBy", "UpdatedOn", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 1, "Initial", new DateTime(2019, 9, 25, 14, 20, 36, 321, DateTimeKind.Local).AddTicks(5962), 1, "Szkółka monterów Jastrząb", "PS/34/20", "Kurs palenia i szczepiania palnikiem gazowym", null, null, new DateTime(2018, 7, 21, 14, 20, 36, 321, DateTimeKind.Local).AddTicks(5979), new DateTime(2023, 7, 21, 14, 20, 36, 321, DateTimeKind.Local).AddTicks(5983) },
                    { 2, "Initial", new DateTime(2020, 1, 3, 14, 20, 36, 321, DateTimeKind.Local).AddTicks(6019), 1, "DNV", "DNV/086/2020", "Placówka szkoleniowa spawaczy - Stocznia Gdańsk", null, null, new DateTime(2020, 1, 3, 14, 20, 36, 321, DateTimeKind.Local).AddTicks(6022), new DateTime(2023, 1, 2, 14, 20, 36, 321, DateTimeKind.Local).AddTicks(6025) },
                    { 3, "Initial", new DateTime(2020, 2, 22, 14, 20, 36, 321, DateTimeKind.Local).AddTicks(6029), 4, "Zakład szkolenia monterów w Harkowie", "HR/127/20", "Kurs palenia i szczepiania palnikiem gazowym", null, null, new DateTime(2016, 2, 22, 14, 20, 36, 321, DateTimeKind.Local).AddTicks(6031), new DateTime(2020, 8, 19, 14, 20, 36, 321, DateTimeKind.Local).AddTicks(6035) }
                });

            migrationBuilder.InsertData(
                table: "Contracts",
                columns: new[] { "Id", "ContractSubject", "CreatedBy", "CreatedOn", "EmployeeId", "HourlySalary", "IsRealized", "IssuedBy", "Number", "TaxPercent", "Title", "UpdatedBy", "UpdatedOn", "ValidFrom", "ValidTo", "Value" },
                values: new object[,]
                {
                    { 19, "Montaż barierek ochronnych na jednostce NB231", "Initial", new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 20m, false, null, "3/07/2020", 14.0m, "Umowa za lipiec", null, null, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 20, 14, 20, 36, 328, DateTimeKind.Local).AddTicks(2959), 4000m },
                    { 16, "Montaż barierek ochronnych na jednostce NB231", "Initial", new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 20m, true, null, "3/06/2020", 14.0m, "Umowa za czerwiec", null, null, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 20, 14, 20, 36, 328, DateTimeKind.Local).AddTicks(2905), 4000m },
                    { 13, "Montaż trapu na jednostce NB231", "Initial", new DateTime(2020, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 20m, true, null, "3/05/2020", 14.0m, "Umowa za maj", null, null, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 20, 14, 20, 36, 328, DateTimeKind.Local).AddTicks(2842), 4000m },
                    { 10, "Montaż trapu na jednostce NB230", "Initial", new DateTime(2020, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 20m, true, null, "3/04/2020", 14.0m, "Umowa za kwiecień", null, null, new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 20, 14, 20, 36, 328, DateTimeKind.Local).AddTicks(2783), 4000m },
                    { 7, "Wypalenie otworu technicznego 23 na jednostce NB230", "Initial", new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 20m, true, null, "3/03/2020", 14.0m, "Umowa za marzec", null, null, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 20, 14, 20, 36, 328, DateTimeKind.Local).AddTicks(2640), 4000m },
                    { 9, "Oszlifowanie wręgów 11-201 na jednostce NB230", "Initial", new DateTime(2020, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 15m, true, null, "2/04/2020", 14.0m, "Umowa za kwiecień", null, null, new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 20, 14, 20, 36, 328, DateTimeKind.Local).AddTicks(2681), 3000m },
                    { 6, "Oszlifowanie schodów na jednostce NB230", "Initial", new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 15m, true, null, "2/03/2020", 14.0m, "Umowa za marzec", null, null, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 20, 14, 20, 36, 328, DateTimeKind.Local).AddTicks(2620), 3000m },
                    { 4, "Oszlifowanie zbiornika ZL15", "Initial", new DateTime(2020, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 15m, true, null, "3/02/2020", 14.0m, "Umowa za luty", null, null, new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 20, 14, 20, 36, 328, DateTimeKind.Local).AddTicks(2580), 3000m },
                    { 18, "Oszlifowanie wręgów zbiorników wody pitnej P12-P32", "Initial", new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 15m, false, null, "2/07/2020", 14.0m, "Umowa za lipiec", null, null, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 20, 14, 20, 36, 328, DateTimeKind.Local).AddTicks(2941), 3000m },
                    { 15, "Oszlifowanie wręgów zbiorników wody pitnej P12-P32", "Initial", new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 15m, true, null, "2/06/2020", 14.0m, "Umowa za czerwiec", null, null, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 20, 14, 20, 36, 328, DateTimeKind.Local).AddTicks(2886), 3000m },
                    { 3, "Oszlifowanie trapa na jednostce NB230", "Initial", new DateTime(2020, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 15m, true, null, "2/02/2020", 14.0m, "Umowa za luty", null, null, new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 20, 14, 20, 36, 328, DateTimeKind.Local).AddTicks(2559), 3000m },
                    { 12, "Oszlifowanie wręgów 11-201 na jednostce NB231", "Initial", new DateTime(2020, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 15m, true, null, "2/05/2020", 14.0m, "Umowa za maj", null, null, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 20, 14, 20, 36, 328, DateTimeKind.Local).AddTicks(2823), 3000m },
                    { 5, "Przyspawanie wręgów 201-421 na jednostce WZ211", "Initial", new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 25m, true, null, "1/03/2020", 14.0m, "Umowa za marzec", null, null, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 20, 14, 20, 36, 328, DateTimeKind.Local).AddTicks(2600), 5000m },
                    { 1, "Montaż obarierowania ochronnego na jednostce NB230", "Initial", new DateTime(2019, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 20m, true, null, "1/01/2020", 14.0m, "Umowa za styczeń", null, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 20, 14, 20, 36, 328, DateTimeKind.Local).AddTicks(1146), 4000m },
                    { 2, "Przyspawanie wręgów 11-201 na jednostce WZ211", "Initial", new DateTime(2020, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 25m, true, null, "1/02/2020", 14.0m, "Umowa za luty", null, null, new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 20, 14, 20, 36, 328, DateTimeKind.Local).AddTicks(2518), 5000m },
                    { 8, "Przyspawanie haków technocznych do płatu P11", "Initial", new DateTime(2020, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 25m, true, null, "1/04/2020", 14.0m, "Umowa za kwiecień", null, null, new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 20, 14, 20, 36, 328, DateTimeKind.Local).AddTicks(2660), 5000m },
                    { 11, "Przyspawanie haków technocznych do płatu P12", "Initial", new DateTime(2020, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 25m, true, null, "1/05/2020", 14.0m, "Umowa za maj", null, null, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 20, 14, 20, 36, 328, DateTimeKind.Local).AddTicks(2804), 5000m },
                    { 14, "Przyspawanie sekcji okętowych NW23-NW24", "Initial", new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 25m, true, null, "1/06/2020", 14.0m, "Umowa za czerwiec", null, null, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 20, 14, 20, 36, 328, DateTimeKind.Local).AddTicks(2861), 5000m },
                    { 17, "Przyspawanie sekcji okętowych NW23-NW24", "Initial", new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 25m, false, null, "1/07/2020", 14.0m, "Umowa za lipiec", null, null, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 20, 14, 20, 36, 328, DateTimeKind.Local).AddTicks(2923), 5000m }
                });

            migrationBuilder.InsertData(
                table: "Foreman",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "FirstName", "LastName", "LocationId", "Mail", "PhoneNo", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 2, "Initial", new DateTime(2019, 11, 14, 14, 20, 36, 318, DateTimeKind.Local).AddTicks(8619), "Jakub", "Jakubczyk", 1, "J.Jakubczyk@StoczniaGdynia.pl", "+58 608 385 513", null, null },
                    { 1, "Initial", new DateTime(2019, 9, 25, 14, 20, 36, 318, DateTimeKind.Local).AddTicks(6552), "Grzegorz", "Grzegorczuk", 1, "G.Grzegorczuk@StoczniaGdynia.pl", "+58 608 385 512", null, null },
                    { 3, "Initial", new DateTime(2020, 1, 3, 14, 20, 36, 318, DateTimeKind.Local).AddTicks(8678), "Filip", "Filipiak", 2, "Filip.Filipiak@Remontowa.pl", "+58 808 100 001", null, null }
                });

            migrationBuilder.InsertData(
                table: "Leave",
                columns: new[] { "Id", "Comment", "CreatedBy", "CreatedOn", "EmployeeId", "From", "To", "Type", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, "Urlop wypoczynkowy, 14 dni", "Initial", new DateTime(2019, 11, 14, 14, 20, 36, 323, DateTimeKind.Local).AddTicks(2859), 1, new DateTime(2019, 11, 30, 14, 20, 36, 323, DateTimeKind.Local).AddTicks(3344), new DateTime(2019, 12, 14, 14, 20, 36, 323, DateTimeKind.Local).AddTicks(3841), "Wypoczynkowy", null, null },
                    { 3, "Obecność nieusprawiedliwiona", "Initial", new DateTime(2020, 5, 21, 14, 20, 36, 323, DateTimeKind.Local).AddTicks(5407), 1, new DateTime(2020, 5, 21, 14, 20, 36, 323, DateTimeKind.Local).AddTicks(5410), null, "Nieusprawiedliwiony", null, null },
                    { 2, "Urlop Administracyjny, wymiana paszporty, wizy", "Initial", new DateTime(2020, 2, 15, 14, 20, 36, 323, DateTimeKind.Local).AddTicks(5356), 2, new DateTime(2020, 2, 22, 14, 20, 36, 323, DateTimeKind.Local).AddTicks(5376), new DateTime(2020, 5, 2, 14, 20, 36, 323, DateTimeKind.Local).AddTicks(5386), "Administracyjny", null, null }
                });

            migrationBuilder.InsertData(
                table: "MedicalCheckup",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "EmployeeId", "IssuedBy", "Number", "Title", "UpdatedBy", "UpdatedOn", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 2, "Initial", new DateTime(2019, 11, 14, 14, 20, 36, 320, DateTimeKind.Local).AddTicks(7719), 2, "DiamentMed sp. z o.o.", "DM-076-19", "Badanie lekarskie wstępne", null, null, new DateTime(2018, 8, 20, 14, 20, 36, 320, DateTimeKind.Local).AddTicks(7757), new DateTime(2020, 8, 20, 14, 20, 36, 320, DateTimeKind.Local).AddTicks(7773) },
                    { 4, "Initial", new DateTime(2019, 11, 14, 14, 20, 36, 320, DateTimeKind.Local).AddTicks(7794), 2, "DiamentMed sp. z o.o.", "DM-178-19", "Badanie lekarskie wstępne", null, null, new DateTime(2019, 2, 21, 14, 20, 36, 320, DateTimeKind.Local).AddTicks(7797), new DateTime(2021, 2, 21, 14, 20, 36, 320, DateTimeKind.Local).AddTicks(7800) },
                    { 1, "Initial", new DateTime(2019, 9, 25, 14, 20, 36, 320, DateTimeKind.Local).AddTicks(5009), 1, "Prywatna praktyka - Dr Kamiński", "MD/016/19", "Badanie lekarskie wstępne", null, null, new DateTime(2018, 8, 19, 14, 20, 36, 320, DateTimeKind.Local).AddTicks(6755), new DateTime(2020, 8, 19, 14, 20, 36, 320, DateTimeKind.Local).AddTicks(7265) },
                    { 3, "Initial", new DateTime(2019, 11, 14, 14, 20, 36, 320, DateTimeKind.Local).AddTicks(7783), 2, "DiamentMed sp. z o.o.", "DM-177-19", "Badanie lekarskie wstępne", null, null, new DateTime(2018, 11, 13, 14, 20, 36, 320, DateTimeKind.Local).AddTicks(7787), new DateTime(2020, 11, 13, 14, 20, 36, 320, DateTimeKind.Local).AddTicks(7790) }
                });

            migrationBuilder.InsertData(
                table: "Passport",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "EmployeeId", "IssuedBy", "Number", "Title", "UpdatedBy", "UpdatedOn", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 1, "Initial", new DateTime(2019, 11, 14, 14, 20, 36, 321, DateTimeKind.Local).AddTicks(9932), 2, "Biuro Paszportowe w Kijowie", "UKR090909", "Paszport Ukraina", null, null, new DateTime(2010, 2, 21, 14, 20, 36, 321, DateTimeKind.Local).AddTicks(9950), new DateTime(2020, 2, 22, 14, 20, 36, 321, DateTimeKind.Local).AddTicks(9955) },
                    { 3, "Initial", new DateTime(2020, 2, 22, 14, 20, 36, 321, DateTimeKind.Local).AddTicks(9982), 4, "Biuro Paszportowe w Lwowie", "LWR12309", "Paszport Ukraina", null, null, new DateTime(2010, 8, 19, 14, 20, 36, 321, DateTimeKind.Local).AddTicks(9985), new DateTime(2049, 7, 21, 14, 20, 36, 321, DateTimeKind.Local).AddTicks(9988) },
                    { 2, "Initial", new DateTime(2019, 11, 14, 14, 20, 36, 321, DateTimeKind.Local).AddTicks(9972), 3, "Biuro Paszportowe w Harkowie", "HKR05409", "Paszport Ukraina", null, null, new DateTime(2019, 7, 21, 14, 20, 36, 321, DateTimeKind.Local).AddTicks(9975), new DateTime(2029, 7, 21, 14, 20, 36, 321, DateTimeKind.Local).AddTicks(9978) },
                    { 4, "Initial", new DateTime(2020, 5, 2, 14, 20, 36, 321, DateTimeKind.Local).AddTicks(9991), 2, "Biuro Paszportowe w Kijowie", "UKR191919", "Paszport Ukraina", null, null, new DateTime(2020, 4, 12, 14, 20, 36, 321, DateTimeKind.Local).AddTicks(9994), new DateTime(2030, 4, 12, 14, 20, 36, 321, DateTimeKind.Local).AddTicks(9996) }
                });

            migrationBuilder.InsertData(
                table: "Permit",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "EmployeeId", "IssuedBy", "LocationId", "Number", "Title", "UpdatedBy", "UpdatedOn", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 4, "Initial", new DateTime(2020, 4, 12, 14, 20, 36, 322, DateTimeKind.Local).AddTicks(9407), 2, "Urząd wojewódzki w Gdańsku, wydział ds. cudzoziemców", 1, "A/216/2020", "Zezwolenie na pracę typ A", null, null, new DateTime(2020, 4, 12, 14, 20, 36, 322, DateTimeKind.Local).AddTicks(9410), new DateTime(2023, 4, 12, 14, 20, 36, 322, DateTimeKind.Local).AddTicks(9413) },
                    { 2, "Initial", new DateTime(2020, 2, 22, 14, 20, 36, 322, DateTimeKind.Local).AddTicks(9341), 3, "Urząd wojewódzki w Gdańsku, wydział ds. cudzoziemców", 1, "KP/55/2020", "Karta Pobytu", null, null, new DateTime(2020, 2, 22, 14, 20, 36, 322, DateTimeKind.Local).AddTicks(9349), new DateTime(2025, 2, 21, 14, 20, 36, 322, DateTimeKind.Local).AddTicks(9352) },
                    { 3, "Initial", new DateTime(2020, 2, 22, 14, 20, 36, 322, DateTimeKind.Local).AddTicks(9357), 4, "Urząd wojewódzki w Gdańsku, wydział ds. cudzoziemców", 1, "A/196/2020", "Zezwolenie na pracę typ A", null, null, new DateTime(2019, 8, 19, 14, 20, 36, 322, DateTimeKind.Local).AddTicks(9360), new DateTime(2020, 8, 19, 14, 20, 36, 322, DateTimeKind.Local).AddTicks(9363) },
                    { 1, "Initial", new DateTime(2019, 11, 14, 14, 20, 36, 322, DateTimeKind.Local).AddTicks(8828), 2, "Panśtwowy Urząd Pracy w Gdyni", 1, "OSW/575/2019", "Oświadczenie o zamiarze powierzenia pracy", null, null, new DateTime(2019, 11, 14, 14, 20, 36, 322, DateTimeKind.Local).AddTicks(9310), new DateTime(2020, 2, 22, 14, 20, 36, 322, DateTimeKind.Local).AddTicks(9323) }
                });

            migrationBuilder.InsertData(
                table: "SafetyTraining",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "EmployeeId", "IssuedBy", "Number", "Title", "UpdatedBy", "UpdatedOn", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 2, "Initial", new DateTime(2019, 11, 14, 14, 20, 36, 321, DateTimeKind.Local).AddTicks(2506), 2, "Dział BHP - Stocznia Gdynia", "BHP/339/19", "Szkolenie BHP - Stocznia Gdynia", null, null, new DateTime(2019, 11, 14, 14, 20, 36, 321, DateTimeKind.Local).AddTicks(2510), new DateTime(2021, 11, 13, 14, 20, 36, 321, DateTimeKind.Local).AddTicks(2512) },
                    { 5, "Initial", new DateTime(2020, 1, 3, 14, 20, 36, 321, DateTimeKind.Local).AddTicks(2534), 4, "Dział BHP - Stocznia Gdynia", "BHP/440/19", "Szkolenie BHP - Stocznia Gdynia", null, null, new DateTime(2020, 2, 22, 14, 20, 36, 321, DateTimeKind.Local).AddTicks(2537), new DateTime(2022, 2, 21, 14, 20, 36, 321, DateTimeKind.Local).AddTicks(2539) },
                    { 4, "Initial", new DateTime(2020, 1, 3, 14, 20, 36, 321, DateTimeKind.Local).AddTicks(2525), 1, "Kierownik działu BHP - Ignacy Krasiński", "BHP-940-19", "Szkolenie Wstępne BHP - Stocznia Gdańsk", null, null, new DateTime(2020, 1, 3, 14, 20, 36, 321, DateTimeKind.Local).AddTicks(2528), new DateTime(2021, 1, 2, 14, 20, 36, 321, DateTimeKind.Local).AddTicks(2531) },
                    { 1, "Initial", new DateTime(2019, 9, 25, 14, 20, 36, 321, DateTimeKind.Local).AddTicks(2466), 1, "Dział BHP - Stocznia Gdynia", "BHP/99/19", "Szkolenie BHP - Stocznia Gdynia", null, null, new DateTime(2019, 9, 25, 14, 20, 36, 321, DateTimeKind.Local).AddTicks(2484), new DateTime(2021, 9, 24, 14, 20, 36, 321, DateTimeKind.Local).AddTicks(2487) },
                    { 3, "Initial", new DateTime(2019, 11, 14, 14, 20, 36, 321, DateTimeKind.Local).AddTicks(2516), 3, "Dział BHP - Stocznia Gdynia", "BHP/340/19", "Szkolenie BHP - Stocznia Gdynia", null, null, new DateTime(2019, 11, 14, 14, 20, 36, 321, DateTimeKind.Local).AddTicks(2519), new DateTime(2021, 11, 13, 14, 20, 36, 321, DateTimeKind.Local).AddTicks(2522) }
                });

            migrationBuilder.InsertData(
                table: "Visa",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "EmployeeId", "IssuedBy", "Number", "Title", "Type", "UpdatedBy", "UpdatedOn", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 3, "Initial", new DateTime(2020, 2, 22, 14, 20, 36, 322, DateTimeKind.Local).AddTicks(4745), 4, "Konsul w Kijowie", "PL053452", "Wiza krajowa", "D", null, null, new DateTime(2019, 8, 19, 14, 20, 36, 322, DateTimeKind.Local).AddTicks(4748), new DateTime(2020, 8, 19, 14, 20, 36, 322, DateTimeKind.Local).AddTicks(4751) },
                    { 1, "Initial", new DateTime(2019, 11, 14, 14, 20, 36, 322, DateTimeKind.Local).AddTicks(4687), 2, "Konsul w Kijowie", "PL053452", "Wiza krajowa", "D", null, null, new DateTime(2019, 2, 21, 14, 20, 36, 322, DateTimeKind.Local).AddTicks(4720), new DateTime(2020, 2, 22, 14, 20, 36, 322, DateTimeKind.Local).AddTicks(4725) },
                    { 2, "Initial", new DateTime(2020, 2, 22, 14, 20, 36, 322, DateTimeKind.Local).AddTicks(4735), 3, "Konsul w Kijowie", "PL053452", "Wiza krajowa", "D", null, null, new DateTime(2020, 2, 22, 14, 20, 36, 322, DateTimeKind.Local).AddTicks(4738), new DateTime(2021, 2, 21, 14, 20, 36, 322, DateTimeKind.Local).AddTicks(4741) },
                    { 4, "Initial", new DateTime(2020, 5, 2, 14, 20, 36, 322, DateTimeKind.Local).AddTicks(4754), 2, "Konsul w Kijowie", "PL053452", "Wiza krajowa", "D", null, null, new DateTime(2020, 4, 12, 14, 20, 36, 322, DateTimeKind.Local).AddTicks(4757), new DateTime(2021, 4, 12, 14, 20, 36, 322, DateTimeKind.Local).AddTicks(4759) }
                });

            migrationBuilder.InsertData(
                table: "Advances",
                columns: new[] { "Id", "Amount", "ContractId", "CreatedBy", "CreatedOn", "PaidOn", "UpdatedBy", "UpdatedOn", "WorkedHours" },
                values: new object[,]
                {
                    { 1, 1100m, 14, "Initial", new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 70 },
                    { 4, 2000m, 17, "Initial", new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), null, null, null, 10 },
                    { 2, 900m, 15, "Initial", new DateTime(2020, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 80 },
                    { 5, 2500m, 18, "Initial", new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), null, null, null, 10 },
                    { 3, 1000m, 16, "Initial", new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 86 },
                    { 6, 500m, 19, "Initial", new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), null, null, 16 }
                });

            migrationBuilder.InsertData(
                table: "EmployeeHistory",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "EmployeeAddressId", "EmployeeId", "ForemanId", "LastName", "LocationId", "Profession", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 6, "Initial", new DateTime(2020, 4, 12, 14, 20, 36, 320, DateTimeKind.Local).AddTicks(410), 6, 1, 3, "Maciejewski", 2, "Spawacz Okrętowy", null, null },
                    { 5, "Initial", new DateTime(2020, 2, 22, 14, 20, 36, 320, DateTimeKind.Local).AddTicks(365), 5, 4, 2, "Yushchenko", 1, "Monter Okrętowy", null, null },
                    { 3, "Initial", new DateTime(2019, 11, 14, 14, 20, 36, 320, DateTimeKind.Local).AddTicks(357), 3, 3, 2, "Kuchna", 1, "Szlifierz Okrętowy", null, null },
                    { 2, "Initial", new DateTime(2019, 11, 14, 14, 20, 36, 320, DateTimeKind.Local).AddTicks(305), 2, 2, 2, "Kravchuk", 1, "Szlifierz Okrętowy", null, null },
                    { 4, "Initial", new DateTime(2020, 1, 3, 14, 20, 36, 320, DateTimeKind.Local).AddTicks(361), 4, 1, 3, "Maciejewski", 2, "Spawacz Okrętowy", null, null },
                    { 1, "Initial", new DateTime(2019, 9, 25, 14, 20, 36, 319, DateTimeKind.Local).AddTicks(7690), 1, 1, 1, "Maciejewski", 1, "Monter Okrętowy", null, null }
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
                name: "IX_Certificate_EmployeeId",
                table: "Certificate",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_EmployeeId",
                table: "Contracts",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeHistory_EmployeeAddressId",
                table: "EmployeeHistory",
                column: "EmployeeAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeHistory_EmployeeId",
                table: "EmployeeHistory",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeHistory_ForemanId",
                table: "EmployeeHistory",
                column: "ForemanId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeHistory_LocationId",
                table: "EmployeeHistory",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Foreman_LocationId",
                table: "Foreman",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Leave_EmployeeId",
                table: "Leave",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCheckup_EmployeeId",
                table: "MedicalCheckup",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Passport_EmployeeId",
                table: "Passport",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_ContractId",
                table: "Payment",
                column: "ContractId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Permit_EmployeeId",
                table: "Permit",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Permit_LocationId",
                table: "Permit",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_SafetyTraining_EmployeeId",
                table: "SafetyTraining",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Visa_EmployeeId",
                table: "Visa",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advances");

            migrationBuilder.DropTable(
                name: "Certificate");

            migrationBuilder.DropTable(
                name: "ConfigurationPage");

            migrationBuilder.DropTable(
                name: "EmployeeHistory");

            migrationBuilder.DropTable(
                name: "Leave");

            migrationBuilder.DropTable(
                name: "MedicalCheckup");

            migrationBuilder.DropTable(
                name: "Passport");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Permit");

            migrationBuilder.DropTable(
                name: "SafetyTraining");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Visa");

            migrationBuilder.DropTable(
                name: "EmployeeAddress");

            migrationBuilder.DropTable(
                name: "Foreman");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
