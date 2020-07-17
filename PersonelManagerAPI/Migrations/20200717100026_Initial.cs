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
                name: "Credential",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Hash = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    RequestedPasswordReset = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Credential", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeAddress",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
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
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
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
                name: "Certificate",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
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
                        name: "FK_Certificate_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
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
                        name: "FK_Leave_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
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
                        name: "FK_MedicalCheckup_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
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
                        name: "FK_Passport_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
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
                        name: "FK_SafetyTraining_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
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
                        name: "FK_Visa_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
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
                        name: "FK_Permit_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
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
                name: "EmployeeHistory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
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
                        name: "FK_EmployeeHistory_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
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

            migrationBuilder.CreateTable(
                name: "Advances",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    WorkedHours = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    PaidOn = table.Column<DateTime>(nullable: false),
                    ContractId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    PaidOn = table.Column<DateTime>(nullable: false),
                    TotalAmount = table.Column<decimal>(nullable: false),
                    PaidAmount = table.Column<decimal>(nullable: false),
                    TaxAmount = table.Column<decimal>(nullable: false),
                    ContractId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contract",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
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
                    PaymentId = table.Column<int>(nullable: true),
                    IsRealized = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contract", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contract_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contract_Payment_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ConfigurationPage",
                columns: new[] { "Id", "BillingMonthEnd", "BillingMonthStart", "CreatedBy", "CreatedOn", "MaximumLeaveTimeInDays", "PercentOfAdvancesAllowed", "WarningBeforeCertificateExpires", "WarningBeforeLeaveReachesLimit", "WarningBeforeMedicalCheckupExpires", "WarningBeforePassportExpires", "WarningBeforePermitExpires", "WarningBeforeSafetyTrainingExpires", "WarningBeforeVisaExpires" },
                values: new object[] { 1, 25, 26, "Administrator", new DateTime(2020, 7, 17, 12, 0, 26, 134, DateTimeKind.Local).AddTicks(4336), 90, 75.0, 30, 60, 30, 30, 30, 30, 30 });

            migrationBuilder.InsertData(
                table: "Credential",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Email", "FirstName", "Hash", "IsActive", "LastName", "RequestedPasswordReset" },
                values: new object[,]
                {
                    { 1, "Administrator", new DateTime(2020, 7, 17, 12, 0, 26, 130, DateTimeKind.Local).AddTicks(4978), "Jan.Kowalski@PersonelManager.pl", "Jan", "WWW", true, "Kowalski", false },
                    { 2, "Administrator", new DateTime(2020, 7, 17, 12, 0, 26, 133, DateTimeKind.Local).AddTicks(2081), "Jan.Nowak@PersonelManager.pl", "Jan", "YYY", true, "Nowak", true },
                    { 3, "Administrator", new DateTime(2020, 7, 17, 12, 0, 26, 133, DateTimeKind.Local).AddTicks(2144), "Maria.Niziolek@PersonelManager.pl", "Maria", "ZZZ", false, "Niziolek", false }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DateOfBirth", "FatherName", "FirstName", "IsArchived", "MotherName", "Nationality", "Pesel" },
                values: new object[,]
                {
                    { 1, "Administrator", new DateTime(2019, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1980, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mariusz", "Maciej", false, "Mariola", "Polska", "80012100000" },
                    { 2, "Administrator", new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1997, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vitalii", "Dmyto", false, "Svetlana", "Ukraina", "" },
                    { 3, "Administrator", new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1993, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oleksii", "Oleksandr", false, "Oleksandra", "Ukraina", "" },
                    { 4, "Administrator", new DateTime(2020, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1997, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maxim", "Yevhenii", false, "Zlata", "Ukraina", "97022012345" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeAddress",
                columns: new[] { "Id", "City", "Country", "CreatedBy", "CreatedOn", "Number", "Region", "Street", "Zip" },
                values: new object[,]
                {
                    { 1, "Kosokowo", "Polska", "Administrator", new DateTime(2019, 9, 21, 12, 0, 26, 137, DateTimeKind.Local).AddTicks(834), "26C", "Pomorze", "Rzemieślnicza", "81-198" },
                    { 2, "Rumia", "Polska", "Administrator", new DateTime(2019, 11, 10, 12, 0, 26, 137, DateTimeKind.Local).AddTicks(866), "20A", "Pomorze", "Świętopełka", "84-230" },
                    { 3, "Gdynia", "Polska", "Administrator", new DateTime(2019, 11, 10, 12, 0, 26, 137, DateTimeKind.Local).AddTicks(871), "6", "Pomorze", "Spokojna", "81-549" },
                    { 4, "Gdańsk", "Polska", "Administrator", new DateTime(2019, 12, 30, 12, 0, 26, 137, DateTimeKind.Local).AddTicks(874), "12", "Pomorze", "Ks. Mariana Góreckiego", "80-553" },
                    { 5, "Pogórze", "Polska", "Administrator", new DateTime(2020, 2, 18, 12, 0, 26, 137, DateTimeKind.Local).AddTicks(877), "13", "Pomorze", "Wapienna", "81-198" },
                    { 6, "Gdańsk", "Polska", "Administrator", new DateTime(2020, 4, 8, 12, 0, 26, 137, DateTimeKind.Local).AddTicks(880), "3-1", "Pomorze", "Nadmorski Dwór", "80-506" }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "City", "Country", "CreatedBy", "CreatedOn", "Name", "Number", "Region", "Street", "Zip" },
                values: new object[,]
                {
                    { 1, "Gdynia", "Polska", "Administrator", new DateTime(2019, 9, 21, 12, 0, 26, 135, DateTimeKind.Local).AddTicks(9320), "Stocznia Gdynia SA", "3", "Pomorze", "Czechosłowacka", "81-336" },
                    { 2, "Gdańsk", "Polska", "Administrator", new DateTime(2019, 11, 10, 12, 0, 26, 136, DateTimeKind.Local).AddTicks(1947), "Stocznia Remontowa Gdańsk", "8", "Pomorze", "Swojska", "80-958" }
                });

            migrationBuilder.InsertData(
                table: "Certificate",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "EmployeeId", "IssuedBy", "Number", "Title", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 1, "Administrator", new DateTime(2019, 9, 21, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(3102), 1, "Szkółka monterów Jastrząb", "PS/34/20", "Kurs palenia i szczepiania palnikiem gazowym", new DateTime(2018, 7, 17, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(3119), new DateTime(2023, 7, 17, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(3123) },
                    { 2, "Administrator", new DateTime(2019, 12, 30, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(3141), 1, "DNV", "DNV/086/2020", "Placówka szkoleniowa spawaczy - Stocznia Gdańsk", new DateTime(2019, 12, 30, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(3144), new DateTime(2022, 12, 29, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(3147) },
                    { 3, "Administrator", new DateTime(2020, 2, 18, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(3151), 4, "Zakład szkolenia monterów w Harkowie", "HR/127/20", "Kurs palenia i szczepiania palnikiem gazowym", new DateTime(2016, 2, 18, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(3154), new DateTime(2020, 8, 15, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(3157) }
                });

            migrationBuilder.InsertData(
                table: "Foreman",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "FirstName", "LastName", "LocationId", "Mail", "PhoneNo" },
                values: new object[,]
                {
                    { 2, "Administrator", new DateTime(2019, 11, 10, 12, 0, 26, 136, DateTimeKind.Local).AddTicks(6729), "Jakub", "Jakubczyk", 1, "J.Jakubczyk@StoczniaGdynia.pl", "+58 608 385 513" },
                    { 1, "Administrator", new DateTime(2019, 9, 21, 12, 0, 26, 136, DateTimeKind.Local).AddTicks(4703), "Grzegorz", "Grzegorczuk", 1, "G.Grzegorczuk@StoczniaGdynia.pl", "+58 608 385 512" },
                    { 3, "Administrator", new DateTime(2019, 12, 30, 12, 0, 26, 136, DateTimeKind.Local).AddTicks(6773), "Filip", "Filipiak", 2, "Filip.Filipiak@Remontowa.pl", "+58 808 100 001" }
                });

            migrationBuilder.InsertData(
                table: "Leave",
                columns: new[] { "Id", "Comment", "CreatedBy", "CreatedOn", "EmployeeId", "From", "To", "Type" },
                values: new object[,]
                {
                    { 2, "Urlop Administracyjny, wymiana paszporty, wizy", "Administrator", new DateTime(2020, 2, 11, 12, 0, 26, 141, DateTimeKind.Local).AddTicks(1743), 2, new DateTime(2020, 2, 18, 12, 0, 26, 141, DateTimeKind.Local).AddTicks(1763), new DateTime(2020, 4, 28, 12, 0, 26, 141, DateTimeKind.Local).AddTicks(1772), "Administracyjny" },
                    { 1, "Urlop wypoczynkowy, 14 dni", "Administrator", new DateTime(2019, 11, 10, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(9485), 1, new DateTime(2019, 11, 26, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(9937), new DateTime(2019, 12, 10, 12, 0, 26, 141, DateTimeKind.Local).AddTicks(391), "Wypoczynkowy" },
                    { 3, "Obecność nieusprawiedliwiona", "Administrator", new DateTime(2020, 5, 17, 12, 0, 26, 141, DateTimeKind.Local).AddTicks(1792), 1, new DateTime(2020, 5, 17, 12, 0, 26, 141, DateTimeKind.Local).AddTicks(1794), null, "Nieusprawiedliwiony" }
                });

            migrationBuilder.InsertData(
                table: "MedicalCheckup",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "EmployeeId", "IssuedBy", "Number", "Title", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 2, "Administrator", new DateTime(2019, 11, 10, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(5289), 2, "DiamentMed sp. z o.o.", "DM-076-19", "Badanie lekarskie wstępne", new DateTime(2018, 8, 16, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(5327), new DateTime(2020, 8, 16, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(5341) },
                    { 3, "Administrator", new DateTime(2019, 11, 10, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(5350), 2, "DiamentMed sp. z o.o.", "DM-177-19", "Badanie lekarskie wstępne", new DateTime(2018, 11, 9, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(5354), new DateTime(2020, 11, 9, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(5357) },
                    { 4, "Administrator", new DateTime(2019, 11, 10, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(5361), 2, "DiamentMed sp. z o.o.", "DM-178-19", "Badanie lekarskie wstępne", new DateTime(2019, 2, 17, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(5363), new DateTime(2021, 2, 17, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(5366) },
                    { 1, "Administrator", new DateTime(2019, 9, 21, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(2792), 1, "Prywatna praktyka - Dr Kamiński", "MD/016/19", "Badanie lekarskie wstępne", new DateTime(2018, 8, 15, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(4367), new DateTime(2020, 8, 15, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(4856) }
                });

            migrationBuilder.InsertData(
                table: "Passport",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "EmployeeId", "IssuedBy", "Number", "Title", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 1, "Administrator", new DateTime(2019, 11, 10, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(6945), 2, "Biuro Paszportowe w Kijowie", "UKR090909", "Paszport Ukraina", new DateTime(2010, 2, 17, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(6974), new DateTime(2020, 2, 18, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(6979) },
                    { 4, "Administrator", new DateTime(2020, 4, 28, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(7015), 2, "Biuro Paszportowe w Kijowie", "UKR191919", "Paszport Ukraina", new DateTime(2020, 4, 8, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(7018), new DateTime(2030, 4, 8, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(7020) },
                    { 2, "Administrator", new DateTime(2019, 11, 10, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(6996), 3, "Biuro Paszportowe w Harkowie", "HKR05409", "Paszport Ukraina", new DateTime(2019, 7, 17, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(6999), new DateTime(2029, 7, 17, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(7002) },
                    { 3, "Administrator", new DateTime(2020, 2, 18, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(7006), 4, "Biuro Paszportowe w Lwowie", "LWR12309", "Paszport Ukraina", new DateTime(2010, 8, 15, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(7009), new DateTime(2049, 7, 17, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(7012) }
                });

            migrationBuilder.InsertData(
                table: "Permit",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "EmployeeId", "IssuedBy", "LocationId", "Number", "Title", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 3, "Administrator", new DateTime(2020, 2, 18, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(6131), 4, "Urząd wojewódzki w Gdańsku, wydział ds. cudzoziemców", 1, "A/196/2020", "Zezwolenie na pracę typ A", new DateTime(2019, 8, 15, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(6134), new DateTime(2020, 8, 15, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(6137) },
                    { 4, "Administrator", new DateTime(2020, 4, 8, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(6140), 2, "Urząd wojewódzki w Gdańsku, wydział ds. cudzoziemców", 1, "A/216/2020", "Zezwolenie na pracę typ A", new DateTime(2020, 4, 8, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(6143), new DateTime(2023, 4, 8, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(6145) },
                    { 2, "Administrator", new DateTime(2020, 2, 18, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(6114), 3, "Urząd wojewódzki w Gdańsku, wydział ds. cudzoziemców", 1, "KP/55/2020", "Karta Pobytu", new DateTime(2020, 2, 18, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(6123), new DateTime(2025, 2, 17, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(6126) },
                    { 1, "Administrator", new DateTime(2019, 11, 10, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(5632), 2, "Panśtwowy Urząd Pracy w Gdyni", 1, "OSW/575/2019", "Oświadczenie o zamiarze powierzenia pracy", new DateTime(2019, 11, 10, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(6085), new DateTime(2020, 2, 18, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(6098) }
                });

            migrationBuilder.InsertData(
                table: "SafetyTraining",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "EmployeeId", "IssuedBy", "Number", "Title", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 4, "Administrator", new DateTime(2019, 12, 30, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(9905), 1, "Kierownik działu BHP - Ignacy Krasiński", "BHP-940-19", "Szkolenie Wstępne BHP - Stocznia Gdańsk", new DateTime(2019, 12, 30, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(9908), new DateTime(2020, 12, 29, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(9910) },
                    { 3, "Administrator", new DateTime(2019, 11, 10, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(9896), 3, "Dział BHP - Stocznia Gdynia", "BHP/340/19", "Szkolenie BHP - Stocznia Gdynia", new DateTime(2019, 11, 10, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(9899), new DateTime(2021, 11, 9, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(9901) },
                    { 5, "Administrator", new DateTime(2019, 12, 30, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(9913), 4, "Dział BHP - Stocznia Gdynia", "BHP/440/19", "Szkolenie BHP - Stocznia Gdynia", new DateTime(2020, 2, 18, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(9916), new DateTime(2022, 2, 17, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(9919) },
                    { 1, "Administrator", new DateTime(2019, 9, 21, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(9849), 1, "Dział BHP - Stocznia Gdynia", "BHP/99/19", "Szkolenie BHP - Stocznia Gdynia", new DateTime(2019, 9, 21, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(9866), new DateTime(2021, 9, 20, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(9869) },
                    { 2, "Administrator", new DateTime(2019, 11, 10, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(9886), 2, "Dział BHP - Stocznia Gdynia", "BHP/339/19", "Szkolenie BHP - Stocznia Gdynia", new DateTime(2019, 11, 10, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(9890), new DateTime(2021, 11, 9, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(9892) }
                });

            migrationBuilder.InsertData(
                table: "Visa",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "EmployeeId", "IssuedBy", "Number", "Title", "Type", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 2, "Administrator", new DateTime(2020, 2, 18, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(1563), 3, "Konsul w Kijowie", "PL053452", "Wiza krajowa", "D", new DateTime(2020, 2, 18, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(1567), new DateTime(2021, 2, 17, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(1569) },
                    { 4, "Administrator", new DateTime(2020, 4, 28, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(1582), 2, "Konsul w Kijowie", "PL053452", "Wiza krajowa", "D", new DateTime(2020, 4, 8, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(1585), new DateTime(2021, 4, 8, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(1587) },
                    { 3, "Administrator", new DateTime(2020, 2, 18, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(1573), 4, "Konsul w Kijowie", "PL053452", "Wiza krajowa", "D", new DateTime(2019, 8, 15, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(1576), new DateTime(2020, 8, 15, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(1579) },
                    { 1, "Administrator", new DateTime(2019, 11, 10, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(1497), 2, "Konsul w Kijowie", "PL053452", "Wiza krajowa", "D", new DateTime(2019, 2, 17, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(1527), new DateTime(2020, 2, 18, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(1532) }
                });

            migrationBuilder.InsertData(
                table: "EmployeeHistory",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "EmployeeAddressId", "EmployeeId", "ForemanId", "LastName", "LocationId", "Profession" },
                values: new object[,]
                {
                    { 1, "Administrator", new DateTime(2019, 9, 21, 12, 0, 26, 137, DateTimeKind.Local).AddTicks(5631), 1, 1, 1, "Maciejewski", 1, "Monter Okrętowy" },
                    { 2, "Administrator", new DateTime(2019, 11, 10, 12, 0, 26, 137, DateTimeKind.Local).AddTicks(8138), 2, 2, 2, "Kravchuk", 1, "Szlifierz Okrętowy" },
                    { 3, "Administrator", new DateTime(2019, 11, 10, 12, 0, 26, 137, DateTimeKind.Local).AddTicks(8204), 3, 3, 2, "Kuchna", 1, "Szlifierz Okrętowy" },
                    { 5, "Administrator", new DateTime(2020, 2, 18, 12, 0, 26, 137, DateTimeKind.Local).AddTicks(8212), 5, 4, 2, "Yushchenko", 1, "Monter Okrętowy" },
                    { 4, "Administrator", new DateTime(2019, 12, 30, 12, 0, 26, 137, DateTimeKind.Local).AddTicks(8208), 4, 1, 3, "Maciejewski", 2, "Spawacz Okrętowy" },
                    { 6, "Administrator", new DateTime(2020, 4, 8, 12, 0, 26, 137, DateTimeKind.Local).AddTicks(8215), 6, 1, 3, "Maciejewski", 2, "Spawacz Okrętowy" }
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
                name: "IX_Contract_EmployeeId",
                table: "Contract",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Contract_PaymentId",
                table: "Contract",
                column: "PaymentId");

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
                column: "ContractId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Advances_Contract_ContractId",
                table: "Advances",
                column: "ContractId",
                principalTable: "Contract",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Contract_ContractId",
                table: "Payment",
                column: "ContractId",
                principalTable: "Contract",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Contract_ContractId",
                table: "Payment");

            migrationBuilder.DropTable(
                name: "Advances");

            migrationBuilder.DropTable(
                name: "Certificate");

            migrationBuilder.DropTable(
                name: "ConfigurationPage");

            migrationBuilder.DropTable(
                name: "Credential");

            migrationBuilder.DropTable(
                name: "EmployeeHistory");

            migrationBuilder.DropTable(
                name: "Leave");

            migrationBuilder.DropTable(
                name: "MedicalCheckup");

            migrationBuilder.DropTable(
                name: "Passport");

            migrationBuilder.DropTable(
                name: "Permit");

            migrationBuilder.DropTable(
                name: "SafetyTraining");

            migrationBuilder.DropTable(
                name: "Visa");

            migrationBuilder.DropTable(
                name: "EmployeeAddress");

            migrationBuilder.DropTable(
                name: "Foreman");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Contract");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Payment");
        }
    }
}
