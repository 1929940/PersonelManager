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
                name: "Employees",
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
                    PaidOn = table.Column<DateTime>(nullable: true),
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
                    PaidOn = table.Column<DateTime>(nullable: true),
                    GrossAmount = table.Column<decimal>(nullable: false),
                    NetAmount = table.Column<decimal>(nullable: false),
                    ContractId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
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
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contracts_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contracts_Payment_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ConfigurationPage",
                columns: new[] { "Id", "BillingMonthEnd", "BillingMonthStart", "CreatedBy", "CreatedOn", "MaximumLeaveTimeInDays", "PercentOfAdvancesAllowed", "WarningBeforeCertificateExpires", "WarningBeforeLeaveReachesLimit", "WarningBeforeMedicalCheckupExpires", "WarningBeforePassportExpires", "WarningBeforePermitExpires", "WarningBeforeSafetyTrainingExpires", "WarningBeforeVisaExpires" },
                values: new object[] { 1, 25, 26, "Administrator", new DateTime(2020, 7, 17, 21, 58, 43, 727, DateTimeKind.Local).AddTicks(4168), 90, 75.0, 30, 60, 30, 30, 30, 30, 30 });

            migrationBuilder.InsertData(
                table: "EmployeeAddress",
                columns: new[] { "Id", "City", "Country", "CreatedBy", "CreatedOn", "Number", "Region", "Street", "Zip" },
                values: new object[,]
                {
                    { 6, "Gdańsk", "Polska", "Administrator", new DateTime(2020, 4, 8, 21, 58, 43, 730, DateTimeKind.Local).AddTicks(494), "3-1", "Pomorze", "Nadmorski Dwór", "80-506" },
                    { 5, "Pogórze", "Polska", "Administrator", new DateTime(2020, 2, 18, 21, 58, 43, 730, DateTimeKind.Local).AddTicks(490), "13", "Pomorze", "Wapienna", "81-198" },
                    { 4, "Gdańsk", "Polska", "Administrator", new DateTime(2019, 12, 30, 21, 58, 43, 730, DateTimeKind.Local).AddTicks(487), "12", "Pomorze", "Ks. Mariana Góreckiego", "80-553" },
                    { 3, "Gdynia", "Polska", "Administrator", new DateTime(2019, 11, 10, 21, 58, 43, 730, DateTimeKind.Local).AddTicks(483), "6", "Pomorze", "Spokojna", "81-549" },
                    { 2, "Rumia", "Polska", "Administrator", new DateTime(2019, 11, 10, 21, 58, 43, 730, DateTimeKind.Local).AddTicks(479), "20A", "Pomorze", "Świętopełka", "84-230" },
                    { 1, "Kosokowo", "Polska", "Administrator", new DateTime(2019, 9, 21, 21, 58, 43, 730, DateTimeKind.Local).AddTicks(447), "26C", "Pomorze", "Rzemieślnicza", "81-198" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DateOfBirth", "FatherName", "FirstName", "IsArchived", "MotherName", "Nationality", "Pesel" },
                values: new object[,]
                {
                    { 4, "Administrator", new DateTime(2020, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1997, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maxim", "Yevhenii", false, "Zlata", "Ukraina", "97022012345" },
                    { 2, "Administrator", new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1997, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vitalii", "Dmyto", false, "Svetlana", "Ukraina", "" },
                    { 1, "Administrator", new DateTime(2019, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1980, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mariusz", "Maciej", false, "Mariola", "Polska", "80012100000" },
                    { 3, "Administrator", new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1993, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oleksii", "Oleksandr", false, "Oleksandra", "Ukraina", "" }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "City", "Country", "CreatedBy", "CreatedOn", "Name", "Number", "Region", "Street", "Zip" },
                values: new object[,]
                {
                    { 1, "Gdynia", "Polska", "Administrator", new DateTime(2019, 9, 21, 21, 58, 43, 728, DateTimeKind.Local).AddTicks(8089), "Stocznia Gdynia SA", "3", "Pomorze", "Czechosłowacka", "81-336" },
                    { 2, "Gdańsk", "Polska", "Administrator", new DateTime(2019, 11, 10, 21, 58, 43, 729, DateTimeKind.Local).AddTicks(955), "Stocznia Remontowa Gdańsk", "8", "Pomorze", "Swojska", "80-958" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Email", "FirstName", "Hash", "IsActive", "LastName", "RequestedPasswordReset", "Role" },
                values: new object[,]
                {
                    { 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Administrator", "Administrator", "WSX_09", true, "", false, "Administrator" },
                    { 3, "Administrator", new DateTime(2020, 7, 17, 21, 58, 43, 726, DateTimeKind.Local).AddTicks(1753), "Maria.Niziolek@PersonelManager.pl", "Maria", "ZZZ", false, "Niziolek", false, "Pracownik" },
                    { 2, "Administrator", new DateTime(2020, 7, 17, 21, 58, 43, 726, DateTimeKind.Local).AddTicks(1680), "Jan.Nowak@PersonelManager.pl", "Jan", "YYY", true, "Nowak", true, "Pracownik" },
                    { 1, "Administrator", new DateTime(2020, 7, 17, 21, 58, 43, 723, DateTimeKind.Local).AddTicks(1349), "Jan.Kowalski@PersonelManager.pl", "Jan", "WWW", true, "Kowalski", false, "Kierownik" }
                });

            migrationBuilder.InsertData(
                table: "Certificate",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "EmployeeId", "IssuedBy", "Number", "Title", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 1, "Administrator", new DateTime(2019, 9, 21, 21, 58, 43, 732, DateTimeKind.Local).AddTicks(5978), 1, "Szkółka monterów Jastrząb", "PS/34/20", "Kurs palenia i szczepiania palnikiem gazowym", new DateTime(2018, 7, 17, 21, 58, 43, 732, DateTimeKind.Local).AddTicks(5998), new DateTime(2023, 7, 17, 21, 58, 43, 732, DateTimeKind.Local).AddTicks(6003) },
                    { 2, "Administrator", new DateTime(2019, 12, 30, 21, 58, 43, 732, DateTimeKind.Local).AddTicks(6046), 1, "DNV", "DNV/086/2020", "Placówka szkoleniowa spawaczy - Stocznia Gdańsk", new DateTime(2019, 12, 30, 21, 58, 43, 732, DateTimeKind.Local).AddTicks(6049), new DateTime(2022, 12, 29, 21, 58, 43, 732, DateTimeKind.Local).AddTicks(6052) },
                    { 3, "Administrator", new DateTime(2020, 2, 18, 21, 58, 43, 732, DateTimeKind.Local).AddTicks(6056), 4, "Zakład szkolenia monterów w Harkowie", "HR/127/20", "Kurs palenia i szczepiania palnikiem gazowym", new DateTime(2016, 2, 18, 21, 58, 43, 732, DateTimeKind.Local).AddTicks(6059), new DateTime(2020, 8, 15, 21, 58, 43, 732, DateTimeKind.Local).AddTicks(6062) }
                });

            migrationBuilder.InsertData(
                table: "Contracts",
                columns: new[] { "Id", "ContractSubject", "CreatedBy", "CreatedOn", "EmployeeId", "HourlySalary", "IsRealized", "IssuedBy", "Number", "PaymentId", "TaxPercent", "Title", "ValidFrom", "ValidTo", "Value" },
                values: new object[,]
                {
                    { 19, "Montaż barierek ochronnych na jednostce NB231", "Administrator", new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 20m, false, null, "3/07/2020", null, 14.0m, "Umowa za lipiec", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 16, 21, 58, 43, 739, DateTimeKind.Local).AddTicks(831), 4000m },
                    { 16, "Montaż barierek ochronnych na jednostce NB231", "Administrator", new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 20m, true, null, "3/06/2020", null, 14.0m, "Umowa za czerwiec", new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 16, 21, 58, 43, 739, DateTimeKind.Local).AddTicks(776), 4000m },
                    { 13, "Montaż trapu na jednostce NB231", "Administrator", new DateTime(2020, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 20m, true, null, "3/05/2020", null, 14.0m, "Umowa za maj", new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 16, 21, 58, 43, 739, DateTimeKind.Local).AddTicks(717), 4000m },
                    { 10, "Montaż trapu na jednostce NB230", "Administrator", new DateTime(2020, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 20m, true, null, "3/04/2020", null, 14.0m, "Umowa za kwiecień", new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 21, 58, 43, 739, DateTimeKind.Local).AddTicks(658), 4000m },
                    { 7, "Wypalenie otworu technicznego 23 na jednostce NB230", "Administrator", new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 20m, true, null, "3/03/2020", null, 14.0m, "Umowa za marzec", new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 16, 21, 58, 43, 739, DateTimeKind.Local).AddTicks(598), 4000m },
                    { 9, "Oszlifowanie wręgów 11-201 na jednostce NB230", "Administrator", new DateTime(2020, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 15m, true, null, "2/04/2020", null, 14.0m, "Umowa za kwiecień", new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 21, 58, 43, 739, DateTimeKind.Local).AddTicks(638), 3000m },
                    { 6, "Oszlifowanie schodów na jednostce NB230", "Administrator", new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 15m, true, null, "2/03/2020", null, 14.0m, "Umowa za marzec", new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 16, 21, 58, 43, 739, DateTimeKind.Local).AddTicks(578), 3000m },
                    { 4, "Oszlifowanie zbiornika ZL15", "Administrator", new DateTime(2020, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 15m, true, null, "3/02/2020", null, 14.0m, "Umowa za luty", new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 16, 21, 58, 43, 739, DateTimeKind.Local).AddTicks(538), 3000m },
                    { 18, "Oszlifowanie wręgów zbiorników wody pitnej P12-P32", "Administrator", new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 15m, false, null, "2/07/2020", null, 14.0m, "Umowa za lipiec", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 16, 21, 58, 43, 739, DateTimeKind.Local).AddTicks(813), 3000m },
                    { 15, "Oszlifowanie wręgów zbiorników wody pitnej P12-P32", "Administrator", new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 15m, true, null, "2/06/2020", null, 14.0m, "Umowa za czerwiec", new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 16, 21, 58, 43, 739, DateTimeKind.Local).AddTicks(757), 3000m },
                    { 3, "Oszlifowanie trapa na jednostce NB230", "Administrator", new DateTime(2020, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 15m, true, null, "2/02/2020", null, 14.0m, "Umowa za luty", new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 16, 21, 58, 43, 739, DateTimeKind.Local).AddTicks(517), 3000m },
                    { 12, "Oszlifowanie wręgów 11-201 na jednostce NB231", "Administrator", new DateTime(2020, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 15m, true, null, "2/05/2020", null, 14.0m, "Umowa za maj", new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 16, 21, 58, 43, 739, DateTimeKind.Local).AddTicks(697), 3000m },
                    { 5, "Przyspawanie wręgów 201-421 na jednostce WZ211", "Administrator", new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 25m, true, null, "1/03/2020", null, 14.0m, "Umowa za marzec", new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 16, 21, 58, 43, 739, DateTimeKind.Local).AddTicks(558), 5000m },
                    { 1, "Montaż obarierowania ochronnego na jednostce NB230", "Administrator", new DateTime(2019, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 20m, true, null, "1/01/2020", null, 14.0m, "Umowa za styczeń", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 16, 21, 58, 43, 738, DateTimeKind.Local).AddTicks(9162), 4000m },
                    { 2, "Przyspawanie wręgów 11-201 na jednostce WZ211", "Administrator", new DateTime(2020, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 25m, true, null, "1/02/2020", null, 14.0m, "Umowa za luty", new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 16, 21, 58, 43, 739, DateTimeKind.Local).AddTicks(481), 5000m },
                    { 8, "Przyspawanie haków technocznych do płatu P11", "Administrator", new DateTime(2020, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 25m, true, null, "1/04/2020", null, 14.0m, "Umowa za kwiecień", new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 21, 58, 43, 739, DateTimeKind.Local).AddTicks(618), 5000m },
                    { 11, "Przyspawanie haków technocznych do płatu P12", "Administrator", new DateTime(2020, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 25m, true, null, "1/05/2020", null, 14.0m, "Umowa za maj", new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 16, 21, 58, 43, 739, DateTimeKind.Local).AddTicks(677), 5000m },
                    { 14, "Przyspawanie sekcji okętowych NW23-NW24", "Administrator", new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 25m, true, null, "1/06/2020", null, 14.0m, "Umowa za czerwiec", new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 16, 21, 58, 43, 739, DateTimeKind.Local).AddTicks(737), 5000m },
                    { 17, "Przyspawanie sekcji okętowych NW23-NW24", "Administrator", new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 25m, false, null, "1/07/2020", null, 14.0m, "Umowa za lipiec", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 16, 21, 58, 43, 739, DateTimeKind.Local).AddTicks(795), 5000m }
                });

            migrationBuilder.InsertData(
                table: "Foreman",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "FirstName", "LastName", "LocationId", "Mail", "PhoneNo" },
                values: new object[,]
                {
                    { 2, "Administrator", new DateTime(2019, 11, 10, 21, 58, 43, 729, DateTimeKind.Local).AddTicks(6027), "Jakub", "Jakubczyk", 1, "J.Jakubczyk@StoczniaGdynia.pl", "+58 608 385 513" },
                    { 1, "Administrator", new DateTime(2019, 9, 21, 21, 58, 43, 729, DateTimeKind.Local).AddTicks(3919), "Grzegorz", "Grzegorczuk", 1, "G.Grzegorczuk@StoczniaGdynia.pl", "+58 608 385 512" },
                    { 3, "Administrator", new DateTime(2019, 12, 30, 21, 58, 43, 729, DateTimeKind.Local).AddTicks(6101), "Filip", "Filipiak", 2, "Filip.Filipiak@Remontowa.pl", "+58 808 100 001" }
                });

            migrationBuilder.InsertData(
                table: "Leave",
                columns: new[] { "Id", "Comment", "CreatedBy", "CreatedOn", "EmployeeId", "From", "To", "Type" },
                values: new object[,]
                {
                    { 1, "Urlop wypoczynkowy, 14 dni", "Administrator", new DateTime(2019, 11, 10, 21, 58, 43, 734, DateTimeKind.Local).AddTicks(3544), 1, new DateTime(2019, 11, 26, 21, 58, 43, 734, DateTimeKind.Local).AddTicks(4032), new DateTime(2019, 12, 10, 21, 58, 43, 734, DateTimeKind.Local).AddTicks(4530), "Wypoczynkowy" },
                    { 3, "Obecność nieusprawiedliwiona", "Administrator", new DateTime(2020, 5, 17, 21, 58, 43, 734, DateTimeKind.Local).AddTicks(6047), 1, new DateTime(2020, 5, 17, 21, 58, 43, 734, DateTimeKind.Local).AddTicks(6050), null, "Nieusprawiedliwiony" },
                    { 2, "Urlop Administracyjny, wymiana paszporty, wizy", "Administrator", new DateTime(2020, 2, 11, 21, 58, 43, 734, DateTimeKind.Local).AddTicks(5995), 2, new DateTime(2020, 2, 18, 21, 58, 43, 734, DateTimeKind.Local).AddTicks(6018), new DateTime(2020, 4, 28, 21, 58, 43, 734, DateTimeKind.Local).AddTicks(6027), "Administracyjny" }
                });

            migrationBuilder.InsertData(
                table: "MedicalCheckup",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "EmployeeId", "IssuedBy", "Number", "Title", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 2, "Administrator", new DateTime(2019, 11, 10, 21, 58, 43, 731, DateTimeKind.Local).AddTicks(5734), 2, "DiamentMed sp. z o.o.", "DM-076-19", "Badanie lekarskie wstępne", new DateTime(2018, 8, 16, 21, 58, 43, 731, DateTimeKind.Local).AddTicks(5772), new DateTime(2020, 8, 16, 21, 58, 43, 731, DateTimeKind.Local).AddTicks(5788) },
                    { 4, "Administrator", new DateTime(2019, 11, 10, 21, 58, 43, 731, DateTimeKind.Local).AddTicks(5821), 2, "DiamentMed sp. z o.o.", "DM-178-19", "Badanie lekarskie wstępne", new DateTime(2019, 2, 17, 21, 58, 43, 731, DateTimeKind.Local).AddTicks(5824), new DateTime(2021, 2, 17, 21, 58, 43, 731, DateTimeKind.Local).AddTicks(5827) },
                    { 1, "Administrator", new DateTime(2019, 9, 21, 21, 58, 43, 731, DateTimeKind.Local).AddTicks(3049), 1, "Prywatna praktyka - Dr Kamiński", "MD/016/19", "Badanie lekarskie wstępne", new DateTime(2018, 8, 15, 21, 58, 43, 731, DateTimeKind.Local).AddTicks(4746), new DateTime(2020, 8, 15, 21, 58, 43, 731, DateTimeKind.Local).AddTicks(5274) },
                    { 3, "Administrator", new DateTime(2019, 11, 10, 21, 58, 43, 731, DateTimeKind.Local).AddTicks(5810), 2, "DiamentMed sp. z o.o.", "DM-177-19", "Badanie lekarskie wstępne", new DateTime(2018, 11, 9, 21, 58, 43, 731, DateTimeKind.Local).AddTicks(5814), new DateTime(2020, 11, 9, 21, 58, 43, 731, DateTimeKind.Local).AddTicks(5817) }
                });

            migrationBuilder.InsertData(
                table: "Passport",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "EmployeeId", "IssuedBy", "Number", "Title", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 1, "Administrator", new DateTime(2019, 11, 10, 21, 58, 43, 733, DateTimeKind.Local).AddTicks(204), 2, "Biuro Paszportowe w Kijowie", "UKR090909", "Paszport Ukraina", new DateTime(2010, 2, 17, 21, 58, 43, 733, DateTimeKind.Local).AddTicks(229), new DateTime(2020, 2, 18, 21, 58, 43, 733, DateTimeKind.Local).AddTicks(234) },
                    { 3, "Administrator", new DateTime(2020, 2, 18, 21, 58, 43, 733, DateTimeKind.Local).AddTicks(267), 4, "Biuro Paszportowe w Lwowie", "LWR12309", "Paszport Ukraina", new DateTime(2010, 8, 15, 21, 58, 43, 733, DateTimeKind.Local).AddTicks(270), new DateTime(2049, 7, 17, 21, 58, 43, 733, DateTimeKind.Local).AddTicks(273) },
                    { 2, "Administrator", new DateTime(2019, 11, 10, 21, 58, 43, 733, DateTimeKind.Local).AddTicks(256), 3, "Biuro Paszportowe w Harkowie", "HKR05409", "Paszport Ukraina", new DateTime(2019, 7, 17, 21, 58, 43, 733, DateTimeKind.Local).AddTicks(259), new DateTime(2029, 7, 17, 21, 58, 43, 733, DateTimeKind.Local).AddTicks(263) },
                    { 4, "Administrator", new DateTime(2020, 4, 28, 21, 58, 43, 733, DateTimeKind.Local).AddTicks(276), 2, "Biuro Paszportowe w Kijowie", "UKR191919", "Paszport Ukraina", new DateTime(2020, 4, 8, 21, 58, 43, 733, DateTimeKind.Local).AddTicks(279), new DateTime(2030, 4, 8, 21, 58, 43, 733, DateTimeKind.Local).AddTicks(282) }
                });

            migrationBuilder.InsertData(
                table: "Permit",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "EmployeeId", "IssuedBy", "LocationId", "Number", "Title", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 4, "Administrator", new DateTime(2020, 4, 8, 21, 58, 43, 733, DateTimeKind.Local).AddTicks(9918), 2, "Urząd wojewódzki w Gdańsku, wydział ds. cudzoziemców", 1, "A/216/2020", "Zezwolenie na pracę typ A", new DateTime(2020, 4, 8, 21, 58, 43, 733, DateTimeKind.Local).AddTicks(9921), new DateTime(2023, 4, 8, 21, 58, 43, 733, DateTimeKind.Local).AddTicks(9924) },
                    { 2, "Administrator", new DateTime(2020, 2, 18, 21, 58, 43, 733, DateTimeKind.Local).AddTicks(9892), 3, "Urząd wojewódzki w Gdańsku, wydział ds. cudzoziemców", 1, "KP/55/2020", "Karta Pobytu", new DateTime(2020, 2, 18, 21, 58, 43, 733, DateTimeKind.Local).AddTicks(9900), new DateTime(2025, 2, 17, 21, 58, 43, 733, DateTimeKind.Local).AddTicks(9903) },
                    { 3, "Administrator", new DateTime(2020, 2, 18, 21, 58, 43, 733, DateTimeKind.Local).AddTicks(9908), 4, "Urząd wojewódzki w Gdańsku, wydział ds. cudzoziemców", 1, "A/196/2020", "Zezwolenie na pracę typ A", new DateTime(2019, 8, 15, 21, 58, 43, 733, DateTimeKind.Local).AddTicks(9912), new DateTime(2020, 8, 15, 21, 58, 43, 733, DateTimeKind.Local).AddTicks(9915) },
                    { 1, "Administrator", new DateTime(2019, 11, 10, 21, 58, 43, 733, DateTimeKind.Local).AddTicks(9363), 2, "Panśtwowy Urząd Pracy w Gdyni", 1, "OSW/575/2019", "Oświadczenie o zamiarze powierzenia pracy", new DateTime(2019, 11, 10, 21, 58, 43, 733, DateTimeKind.Local).AddTicks(9860), new DateTime(2020, 2, 18, 21, 58, 43, 733, DateTimeKind.Local).AddTicks(9873) }
                });

            migrationBuilder.InsertData(
                table: "SafetyTraining",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "EmployeeId", "IssuedBy", "Number", "Title", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 2, "Administrator", new DateTime(2019, 11, 10, 21, 58, 43, 732, DateTimeKind.Local).AddTicks(2032), 2, "Dział BHP - Stocznia Gdynia", "BHP/339/19", "Szkolenie BHP - Stocznia Gdynia", new DateTime(2019, 11, 10, 21, 58, 43, 732, DateTimeKind.Local).AddTicks(2036), new DateTime(2021, 11, 9, 21, 58, 43, 732, DateTimeKind.Local).AddTicks(2039) },
                    { 5, "Administrator", new DateTime(2019, 12, 30, 21, 58, 43, 732, DateTimeKind.Local).AddTicks(2060), 4, "Dział BHP - Stocznia Gdynia", "BHP/440/19", "Szkolenie BHP - Stocznia Gdynia", new DateTime(2020, 2, 18, 21, 58, 43, 732, DateTimeKind.Local).AddTicks(2062), new DateTime(2022, 2, 17, 21, 58, 43, 732, DateTimeKind.Local).AddTicks(2065) },
                    { 4, "Administrator", new DateTime(2019, 12, 30, 21, 58, 43, 732, DateTimeKind.Local).AddTicks(2051), 1, "Kierownik działu BHP - Ignacy Krasiński", "BHP-940-19", "Szkolenie Wstępne BHP - Stocznia Gdańsk", new DateTime(2019, 12, 30, 21, 58, 43, 732, DateTimeKind.Local).AddTicks(2054), new DateTime(2020, 12, 29, 21, 58, 43, 732, DateTimeKind.Local).AddTicks(2056) },
                    { 1, "Administrator", new DateTime(2019, 9, 21, 21, 58, 43, 732, DateTimeKind.Local).AddTicks(1978), 1, "Dział BHP - Stocznia Gdynia", "BHP/99/19", "Szkolenie BHP - Stocznia Gdynia", new DateTime(2019, 9, 21, 21, 58, 43, 732, DateTimeKind.Local).AddTicks(2007), new DateTime(2021, 9, 20, 21, 58, 43, 732, DateTimeKind.Local).AddTicks(2009) },
                    { 3, "Administrator", new DateTime(2019, 11, 10, 21, 58, 43, 732, DateTimeKind.Local).AddTicks(2042), 3, "Dział BHP - Stocznia Gdynia", "BHP/340/19", "Szkolenie BHP - Stocznia Gdynia", new DateTime(2019, 11, 10, 21, 58, 43, 732, DateTimeKind.Local).AddTicks(2045), new DateTime(2021, 11, 9, 21, 58, 43, 732, DateTimeKind.Local).AddTicks(2048) }
                });

            migrationBuilder.InsertData(
                table: "Visa",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "EmployeeId", "IssuedBy", "Number", "Title", "Type", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 3, "Administrator", new DateTime(2020, 2, 18, 21, 58, 43, 733, DateTimeKind.Local).AddTicks(5186), 4, "Konsul w Kijowie", "PL053452", "Wiza krajowa", "D", new DateTime(2019, 8, 15, 21, 58, 43, 733, DateTimeKind.Local).AddTicks(5189), new DateTime(2020, 8, 15, 21, 58, 43, 733, DateTimeKind.Local).AddTicks(5193) },
                    { 1, "Administrator", new DateTime(2019, 11, 10, 21, 58, 43, 733, DateTimeKind.Local).AddTicks(5129), 2, "Konsul w Kijowie", "PL053452", "Wiza krajowa", "D", new DateTime(2019, 2, 17, 21, 58, 43, 733, DateTimeKind.Local).AddTicks(5160), new DateTime(2020, 2, 18, 21, 58, 43, 733, DateTimeKind.Local).AddTicks(5166) },
                    { 2, "Administrator", new DateTime(2020, 2, 18, 21, 58, 43, 733, DateTimeKind.Local).AddTicks(5176), 3, "Konsul w Kijowie", "PL053452", "Wiza krajowa", "D", new DateTime(2020, 2, 18, 21, 58, 43, 733, DateTimeKind.Local).AddTicks(5179), new DateTime(2021, 2, 17, 21, 58, 43, 733, DateTimeKind.Local).AddTicks(5182) },
                    { 4, "Administrator", new DateTime(2020, 4, 28, 21, 58, 43, 733, DateTimeKind.Local).AddTicks(5196), 2, "Konsul w Kijowie", "PL053452", "Wiza krajowa", "D", new DateTime(2020, 4, 8, 21, 58, 43, 733, DateTimeKind.Local).AddTicks(5199), new DateTime(2021, 4, 8, 21, 58, 43, 733, DateTimeKind.Local).AddTicks(5201) }
                });

            migrationBuilder.InsertData(
                table: "Advances",
                columns: new[] { "Id", "Amount", "ContractId", "CreatedBy", "CreatedOn", "PaidOn", "WorkedHours" },
                values: new object[,]
                {
                    { 1, 1100m, 14, "Administrator", new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 70 },
                    { 4, 2000m, 17, "Administrator", new DateTime(2020, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), null, 10 },
                    { 2, 900m, 15, "Administrator", new DateTime(2020, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 80 },
                    { 5, 2500m, 18, "Administrator", new DateTime(2020, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), null, 10 },
                    { 3, 1000m, 16, "Administrator", new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 86 },
                    { 6, 500m, 19, "Administrator", new DateTime(2020, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), 16 }
                });

            migrationBuilder.InsertData(
                table: "EmployeeHistory",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "EmployeeAddressId", "EmployeeId", "ForemanId", "LastName", "LocationId", "Profession" },
                values: new object[,]
                {
                    { 6, "Administrator", new DateTime(2020, 4, 8, 21, 58, 43, 730, DateTimeKind.Local).AddTicks(8314), 6, 1, 3, "Maciejewski", 2, "Spawacz Okrętowy" },
                    { 5, "Administrator", new DateTime(2020, 2, 18, 21, 58, 43, 730, DateTimeKind.Local).AddTicks(8311), 5, 4, 2, "Yushchenko", 1, "Monter Okrętowy" },
                    { 3, "Administrator", new DateTime(2019, 11, 10, 21, 58, 43, 730, DateTimeKind.Local).AddTicks(8303), 3, 3, 2, "Kuchna", 1, "Szlifierz Okrętowy" },
                    { 2, "Administrator", new DateTime(2019, 11, 10, 21, 58, 43, 730, DateTimeKind.Local).AddTicks(8250), 2, 2, 2, "Kravchuk", 1, "Szlifierz Okrętowy" },
                    { 4, "Administrator", new DateTime(2019, 12, 30, 21, 58, 43, 730, DateTimeKind.Local).AddTicks(8307), 4, 1, 3, "Maciejewski", 2, "Spawacz Okrętowy" },
                    { 1, "Administrator", new DateTime(2019, 9, 21, 21, 58, 43, 730, DateTimeKind.Local).AddTicks(5556), 1, 1, 1, "Maciejewski", 1, "Monter Okrętowy" }
                });

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "Id", "ContractId", "CreatedBy", "CreatedOn", "GrossAmount", "NetAmount", "PaidOn" },
                values: new object[,]
                {
                    { 3, 13, "Administrator", new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4000m, 3440.00m, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 15, "Administrator", new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3000m, 2580.00m, new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 12, "Administrator", new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3000m, 2580.00m, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 14, "Administrator", new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5000m, 4300.00m, new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 16, "Administrator", new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4000m, 3440.00m, new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 11, "Administrator", new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5000m, 4300.00m, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
                name: "IX_Contracts_PaymentId",
                table: "Contracts",
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
                name: "FK_Advances_Contracts_ContractId",
                table: "Advances",
                column: "ContractId",
                principalTable: "Contracts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Contracts_ContractId",
                table: "Payment",
                column: "ContractId",
                principalTable: "Contracts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Contracts_ContractId",
                table: "Payment");

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
                name: "Location");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Payment");
        }
    }
}
