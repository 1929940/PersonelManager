using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class RemovedForeigners : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Passports");

            migrationBuilder.DropTable(
                name: "Permits");

            migrationBuilder.DropTable(
                name: "Visas");

            migrationBuilder.UpdateData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2020, 7, 25, 14, 39, 19, 452, DateTimeKind.Local).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2020, 7, 25, 14, 39, 19, 452, DateTimeKind.Local).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "PaidOn" },
                values: new object[] { new DateTime(2020, 7, 25, 14, 39, 19, 452, DateTimeKind.Local).AddTicks(3499), new DateTime(2020, 7, 25, 14, 39, 19, 452, DateTimeKind.Local).AddTicks(3502) });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 9, 29, 14, 39, 19, 446, DateTimeKind.Local).AddTicks(3858), new DateTime(2018, 7, 25, 14, 39, 19, 446, DateTimeKind.Local).AddTicks(3875), new DateTime(2023, 7, 25, 14, 39, 19, 446, DateTimeKind.Local).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 1, 7, 14, 39, 19, 446, DateTimeKind.Local).AddTicks(3898), new DateTime(2020, 1, 7, 14, 39, 19, 446, DateTimeKind.Local).AddTicks(3901), new DateTime(2023, 1, 6, 14, 39, 19, 446, DateTimeKind.Local).AddTicks(3904) });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 2, 26, 14, 39, 19, 446, DateTimeKind.Local).AddTicks(3907), new DateTime(2016, 2, 26, 14, 39, 19, 446, DateTimeKind.Local).AddTicks(3910), new DateTime(2020, 8, 23, 14, 39, 19, 446, DateTimeKind.Local).AddTicks(3913) });

            migrationBuilder.UpdateData(
                table: "ConfigurationPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 7, 25, 14, 39, 19, 441, DateTimeKind.Local).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 1,
                column: "ValidTo",
                value: new DateTime(2020, 2, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 2,
                column: "ValidTo",
                value: new DateTime(2020, 3, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 3,
                column: "ValidTo",
                value: new DateTime(2020, 3, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 4,
                column: "ValidTo",
                value: new DateTime(2020, 3, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 5,
                column: "ValidTo",
                value: new DateTime(2020, 4, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 6,
                column: "ValidTo",
                value: new DateTime(2020, 4, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 7,
                column: "ValidTo",
                value: new DateTime(2020, 4, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 8,
                column: "ValidTo",
                value: new DateTime(2020, 5, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 9,
                column: "ValidTo",
                value: new DateTime(2020, 5, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 10,
                column: "ValidTo",
                value: new DateTime(2020, 5, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 11,
                column: "ValidTo",
                value: new DateTime(2020, 6, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(5015));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 12,
                column: "ValidTo",
                value: new DateTime(2020, 6, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 13,
                column: "ValidTo",
                value: new DateTime(2020, 6, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(5055));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 14,
                column: "ValidTo",
                value: new DateTime(2020, 7, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 15,
                column: "ValidTo",
                value: new DateTime(2020, 7, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 16,
                column: "ValidTo",
                value: new DateTime(2020, 7, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 17,
                column: "ValidTo",
                value: new DateTime(2020, 8, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 18,
                column: "ValidTo",
                value: new DateTime(2020, 8, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 19,
                column: "ValidTo",
                value: new DateTime(2020, 8, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 9, 29, 14, 39, 19, 442, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2019, 11, 18, 14, 39, 19, 442, DateTimeKind.Local).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2019, 11, 18, 14, 39, 19, 442, DateTimeKind.Local).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2020, 2, 26, 14, 39, 19, 442, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 9, 29, 14, 39, 19, 444, DateTimeKind.Local).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2019, 11, 18, 14, 39, 19, 444, DateTimeKind.Local).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2019, 11, 18, 14, 39, 19, 444, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 7, 14, 39, 19, 444, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2020, 2, 26, 14, 39, 19, 444, DateTimeKind.Local).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2020, 4, 16, 14, 39, 19, 444, DateTimeKind.Local).AddTicks(7802));

            migrationBuilder.UpdateData(
                table: "Foremen",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 9, 29, 14, 39, 19, 443, DateTimeKind.Local).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "Foremen",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2019, 11, 18, 14, 39, 19, 443, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "Foremen",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 7, 14, 39, 19, 443, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "From", "To" },
                values: new object[] { new DateTime(2019, 11, 18, 14, 39, 19, 446, DateTimeKind.Local).AddTicks(7886), new DateTime(2019, 12, 4, 14, 39, 19, 446, DateTimeKind.Local).AddTicks(8350), new DateTime(2019, 12, 18, 14, 39, 19, 446, DateTimeKind.Local).AddTicks(8824) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "From", "To" },
                values: new object[] { new DateTime(2020, 2, 19, 14, 39, 19, 447, DateTimeKind.Local).AddTicks(265), new DateTime(2020, 2, 26, 14, 39, 19, 447, DateTimeKind.Local).AddTicks(284), new DateTime(2020, 5, 6, 14, 39, 19, 447, DateTimeKind.Local).AddTicks(292) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "From" },
                values: new object[] { new DateTime(2020, 5, 25, 14, 39, 19, 447, DateTimeKind.Local).AddTicks(316), new DateTime(2020, 5, 25, 14, 39, 19, 447, DateTimeKind.Local).AddTicks(319) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 9, 29, 14, 39, 19, 443, DateTimeKind.Local).AddTicks(282));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2019, 11, 18, 14, 39, 19, 443, DateTimeKind.Local).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "MedicalCheckups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 9, 29, 14, 39, 19, 445, DateTimeKind.Local).AddTicks(2813), new DateTime(2018, 8, 23, 14, 39, 19, 445, DateTimeKind.Local).AddTicks(4633), new DateTime(2020, 8, 23, 14, 39, 19, 445, DateTimeKind.Local).AddTicks(5154) });

            migrationBuilder.UpdateData(
                table: "MedicalCheckups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 18, 14, 39, 19, 445, DateTimeKind.Local).AddTicks(5625), new DateTime(2018, 8, 24, 14, 39, 19, 445, DateTimeKind.Local).AddTicks(5682), new DateTime(2020, 8, 24, 14, 39, 19, 445, DateTimeKind.Local).AddTicks(5698) });

            migrationBuilder.UpdateData(
                table: "MedicalCheckups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 18, 14, 39, 19, 445, DateTimeKind.Local).AddTicks(5709), new DateTime(2018, 11, 17, 14, 39, 19, 445, DateTimeKind.Local).AddTicks(5712), new DateTime(2020, 11, 17, 14, 39, 19, 445, DateTimeKind.Local).AddTicks(5716) });

            migrationBuilder.UpdateData(
                table: "MedicalCheckups",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 18, 14, 39, 19, 445, DateTimeKind.Local).AddTicks(5719), new DateTime(2019, 2, 25, 14, 39, 19, 445, DateTimeKind.Local).AddTicks(5722), new DateTime(2021, 2, 25, 14, 39, 19, 445, DateTimeKind.Local).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "SafetyTrainings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 9, 29, 14, 39, 19, 446, DateTimeKind.Local).AddTicks(450), new DateTime(2019, 9, 29, 14, 39, 19, 446, DateTimeKind.Local).AddTicks(466), new DateTime(2021, 9, 28, 14, 39, 19, 446, DateTimeKind.Local).AddTicks(469) });

            migrationBuilder.UpdateData(
                table: "SafetyTrainings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 18, 14, 39, 19, 446, DateTimeKind.Local).AddTicks(488), new DateTime(2019, 11, 18, 14, 39, 19, 446, DateTimeKind.Local).AddTicks(491), new DateTime(2021, 11, 17, 14, 39, 19, 446, DateTimeKind.Local).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "SafetyTrainings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 18, 14, 39, 19, 446, DateTimeKind.Local).AddTicks(497), new DateTime(2019, 11, 18, 14, 39, 19, 446, DateTimeKind.Local).AddTicks(500), new DateTime(2021, 11, 17, 14, 39, 19, 446, DateTimeKind.Local).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "SafetyTrainings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 1, 7, 14, 39, 19, 446, DateTimeKind.Local).AddTicks(506), new DateTime(2020, 1, 7, 14, 39, 19, 446, DateTimeKind.Local).AddTicks(509), new DateTime(2021, 1, 6, 14, 39, 19, 446, DateTimeKind.Local).AddTicks(511) });

            migrationBuilder.UpdateData(
                table: "SafetyTrainings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 1, 7, 14, 39, 19, 446, DateTimeKind.Local).AddTicks(515), new DateTime(2020, 2, 26, 14, 39, 19, 446, DateTimeKind.Local).AddTicks(518), new DateTime(2022, 2, 25, 14, 39, 19, 446, DateTimeKind.Local).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 7, 25, 14, 39, 19, 437, DateTimeKind.Local).AddTicks(1053));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 7, 25, 14, 39, 19, 440, DateTimeKind.Local).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 7, 25, 14, 39, 19, 440, DateTimeKind.Local).AddTicks(3395));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Passports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    IssuedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ValidFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValidTo = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                name: "Permits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    IssuedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ValidFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValidTo = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                name: "Visas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    IssuedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ValidFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValidTo = table.Column<DateTime>(type: "datetime2", nullable: false)
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

            migrationBuilder.UpdateData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2020, 7, 23, 12, 3, 32, 237, DateTimeKind.Local).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2020, 7, 23, 12, 3, 32, 237, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "PaidOn" },
                values: new object[] { new DateTime(2020, 7, 23, 12, 3, 32, 237, DateTimeKind.Local).AddTicks(7133), new DateTime(2020, 7, 23, 12, 3, 32, 237, DateTimeKind.Local).AddTicks(7136) });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 9, 27, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(5196), new DateTime(2018, 7, 23, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(5211), new DateTime(2023, 7, 23, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(5216) });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 1, 5, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(5232), new DateTime(2020, 1, 5, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(5235), new DateTime(2023, 1, 4, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(5238) });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 2, 24, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(5242), new DateTime(2016, 2, 24, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(5244), new DateTime(2020, 8, 21, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(5247) });

            migrationBuilder.UpdateData(
                table: "ConfigurationPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 7, 23, 12, 3, 32, 225, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 1,
                column: "ValidTo",
                value: new DateTime(2020, 2, 22, 12, 3, 32, 236, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 2,
                column: "ValidTo",
                value: new DateTime(2020, 3, 22, 12, 3, 32, 236, DateTimeKind.Local).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 3,
                column: "ValidTo",
                value: new DateTime(2020, 3, 22, 12, 3, 32, 236, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 4,
                column: "ValidTo",
                value: new DateTime(2020, 3, 22, 12, 3, 32, 236, DateTimeKind.Local).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 5,
                column: "ValidTo",
                value: new DateTime(2020, 4, 22, 12, 3, 32, 236, DateTimeKind.Local).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 6,
                column: "ValidTo",
                value: new DateTime(2020, 4, 22, 12, 3, 32, 236, DateTimeKind.Local).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 7,
                column: "ValidTo",
                value: new DateTime(2020, 4, 22, 12, 3, 32, 236, DateTimeKind.Local).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 8,
                column: "ValidTo",
                value: new DateTime(2020, 5, 22, 12, 3, 32, 236, DateTimeKind.Local).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 9,
                column: "ValidTo",
                value: new DateTime(2020, 5, 22, 12, 3, 32, 236, DateTimeKind.Local).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 10,
                column: "ValidTo",
                value: new DateTime(2020, 5, 22, 12, 3, 32, 236, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 11,
                column: "ValidTo",
                value: new DateTime(2020, 6, 22, 12, 3, 32, 236, DateTimeKind.Local).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 12,
                column: "ValidTo",
                value: new DateTime(2020, 6, 22, 12, 3, 32, 236, DateTimeKind.Local).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 13,
                column: "ValidTo",
                value: new DateTime(2020, 6, 22, 12, 3, 32, 236, DateTimeKind.Local).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 14,
                column: "ValidTo",
                value: new DateTime(2020, 7, 22, 12, 3, 32, 236, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 15,
                column: "ValidTo",
                value: new DateTime(2020, 7, 22, 12, 3, 32, 236, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 16,
                column: "ValidTo",
                value: new DateTime(2020, 7, 22, 12, 3, 32, 236, DateTimeKind.Local).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 17,
                column: "ValidTo",
                value: new DateTime(2020, 8, 22, 12, 3, 32, 236, DateTimeKind.Local).AddTicks(9187));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 18,
                column: "ValidTo",
                value: new DateTime(2020, 8, 22, 12, 3, 32, 236, DateTimeKind.Local).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 19,
                column: "ValidTo",
                value: new DateTime(2020, 8, 22, 12, 3, 32, 236, DateTimeKind.Local).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 9, 27, 12, 3, 32, 226, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2019, 11, 16, 12, 3, 32, 227, DateTimeKind.Local).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2019, 11, 16, 12, 3, 32, 227, DateTimeKind.Local).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2020, 2, 24, 12, 3, 32, 227, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 9, 27, 12, 3, 32, 228, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2019, 11, 16, 12, 3, 32, 228, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2019, 11, 16, 12, 3, 32, 228, DateTimeKind.Local).AddTicks(9986));

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 5, 12, 3, 32, 228, DateTimeKind.Local).AddTicks(9991));

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2020, 2, 24, 12, 3, 32, 228, DateTimeKind.Local).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2020, 4, 14, 12, 3, 32, 228, DateTimeKind.Local).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "Foremen",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 9, 27, 12, 3, 32, 227, DateTimeKind.Local).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "Foremen",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2019, 11, 16, 12, 3, 32, 228, DateTimeKind.Local).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "Foremen",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 5, 12, 3, 32, 228, DateTimeKind.Local).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "From", "To" },
                values: new object[] { new DateTime(2019, 11, 16, 12, 3, 32, 232, DateTimeKind.Local).AddTicks(2017), new DateTime(2019, 12, 2, 12, 3, 32, 232, DateTimeKind.Local).AddTicks(2473), new DateTime(2019, 12, 16, 12, 3, 32, 232, DateTimeKind.Local).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "From", "To" },
                values: new object[] { new DateTime(2020, 2, 17, 12, 3, 32, 232, DateTimeKind.Local).AddTicks(4268), new DateTime(2020, 2, 24, 12, 3, 32, 232, DateTimeKind.Local).AddTicks(4285), new DateTime(2020, 5, 4, 12, 3, 32, 232, DateTimeKind.Local).AddTicks(4294) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "From" },
                values: new object[] { new DateTime(2020, 5, 23, 12, 3, 32, 232, DateTimeKind.Local).AddTicks(4315), new DateTime(2020, 5, 23, 12, 3, 32, 232, DateTimeKind.Local).AddTicks(4318) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 9, 27, 12, 3, 32, 227, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2019, 11, 16, 12, 3, 32, 227, DateTimeKind.Local).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "MedicalCheckups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 9, 27, 12, 3, 32, 229, DateTimeKind.Local).AddTicks(4878), new DateTime(2018, 8, 21, 12, 3, 32, 229, DateTimeKind.Local).AddTicks(6440), new DateTime(2020, 8, 21, 12, 3, 32, 229, DateTimeKind.Local).AddTicks(6919) });

            migrationBuilder.UpdateData(
                table: "MedicalCheckups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 16, 12, 3, 32, 229, DateTimeKind.Local).AddTicks(7355), new DateTime(2018, 8, 22, 12, 3, 32, 229, DateTimeKind.Local).AddTicks(7410), new DateTime(2020, 8, 22, 12, 3, 32, 229, DateTimeKind.Local).AddTicks(7447) });

            migrationBuilder.UpdateData(
                table: "MedicalCheckups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 16, 12, 3, 32, 229, DateTimeKind.Local).AddTicks(7457), new DateTime(2018, 11, 15, 12, 3, 32, 229, DateTimeKind.Local).AddTicks(7461), new DateTime(2020, 11, 15, 12, 3, 32, 229, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "MedicalCheckups",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 16, 12, 3, 32, 229, DateTimeKind.Local).AddTicks(7468), new DateTime(2019, 2, 23, 12, 3, 32, 229, DateTimeKind.Local).AddTicks(7471), new DateTime(2021, 2, 23, 12, 3, 32, 229, DateTimeKind.Local).AddTicks(7474) });

            migrationBuilder.InsertData(
                table: "Passports",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "EmployeeId", "IssuedBy", "Number", "Title", "UpdatedBy", "UpdatedOn", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 2, "Initial", new DateTime(2019, 11, 16, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(9118), 3, "Biuro Paszportowe w Harkowie", "HKR05409", "Paszport Ukraina", null, null, new DateTime(2019, 7, 23, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(9122), new DateTime(2029, 7, 23, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(9125) },
                    { 3, "Initial", new DateTime(2020, 2, 24, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(9128), 4, "Biuro Paszportowe w Lwowie", "LWR12309", "Paszport Ukraina", null, null, new DateTime(2010, 8, 21, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(9131), new DateTime(2049, 7, 23, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(9134) },
                    { 4, "Initial", new DateTime(2020, 5, 4, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(9137), 2, "Biuro Paszportowe w Kijowie", "UKR191919", "Paszport Ukraina", null, null, new DateTime(2020, 4, 14, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(9140), new DateTime(2030, 4, 14, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(9142) },
                    { 1, "Initial", new DateTime(2019, 11, 16, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(9083), 2, "Biuro Paszportowe w Kijowie", "UKR090909", "Paszport Ukraina", null, null, new DateTime(2010, 2, 23, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(9098), new DateTime(2020, 2, 24, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(9103) }
                });

            migrationBuilder.InsertData(
                table: "Permits",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "EmployeeId", "IssuedBy", "LocationId", "Number", "Title", "UpdatedBy", "UpdatedOn", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 4, "Initial", new DateTime(2020, 4, 14, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(8715), 2, "Urząd wojewódzki w Gdańsku, wydział ds. cudzoziemców", 1, "A/216/2020", "Zezwolenie na pracę typ A", null, null, new DateTime(2020, 4, 14, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(8718), new DateTime(2023, 4, 14, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(8721) },
                    { 3, "Initial", new DateTime(2020, 2, 24, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(8706), 4, "Urząd wojewódzki w Gdańsku, wydział ds. cudzoziemców", 1, "A/196/2020", "Zezwolenie na pracę typ A", null, null, new DateTime(2019, 8, 21, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(8709), new DateTime(2020, 8, 21, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(8712) },
                    { 2, "Initial", new DateTime(2020, 2, 24, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(8686), 3, "Urząd wojewódzki w Gdańsku, wydział ds. cudzoziemców", 1, "KP/55/2020", "Karta Pobytu", null, null, new DateTime(2020, 2, 24, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(8698), new DateTime(2025, 2, 23, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(8701) },
                    { 1, "Initial", new DateTime(2019, 11, 16, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(8203), 2, "Panśtwowy Urząd Pracy w Gdyni", 1, "OSW/575/2019", "Oświadczenie o zamiarze powierzenia pracy", null, null, new DateTime(2019, 11, 16, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(8658), new DateTime(2020, 2, 24, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(8669) }
                });

            migrationBuilder.UpdateData(
                table: "SafetyTrainings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 9, 27, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(1928), new DateTime(2019, 9, 27, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(1944), new DateTime(2021, 9, 26, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "SafetyTrainings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 16, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(1966), new DateTime(2019, 11, 16, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(1969), new DateTime(2021, 11, 15, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(1972) });

            migrationBuilder.UpdateData(
                table: "SafetyTrainings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 16, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(1975), new DateTime(2019, 11, 16, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(1978), new DateTime(2021, 11, 15, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.UpdateData(
                table: "SafetyTrainings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 1, 5, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(1984), new DateTime(2020, 1, 5, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(1986), new DateTime(2021, 1, 4, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(1989) });

            migrationBuilder.UpdateData(
                table: "SafetyTrainings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 1, 5, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(1992), new DateTime(2020, 2, 24, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(1995), new DateTime(2022, 2, 23, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(1997) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 7, 23, 12, 3, 32, 221, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 7, 23, 12, 3, 32, 224, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 7, 23, 12, 3, 32, 224, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.InsertData(
                table: "Visas",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "EmployeeId", "IssuedBy", "Number", "Title", "Type", "UpdatedBy", "UpdatedOn", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 4, "Initial", new DateTime(2020, 5, 4, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(3780), 2, "Konsul w Kijowie", "PL053452", "Wiza krajowa", "D", null, null, new DateTime(2020, 4, 14, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(3783), new DateTime(2021, 4, 14, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(3786) },
                    { 3, "Initial", new DateTime(2020, 2, 24, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(3771), 4, "Konsul w Kijowie", "PL053452", "Wiza krajowa", "D", null, null, new DateTime(2019, 8, 21, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(3774), new DateTime(2020, 8, 21, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(3778) },
                    { 2, "Initial", new DateTime(2020, 2, 24, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(3762), 3, "Konsul w Kijowie", "PL053452", "Wiza krajowa", "D", null, null, new DateTime(2020, 2, 24, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(3765), new DateTime(2021, 2, 23, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(3767) },
                    { 1, "Initial", new DateTime(2019, 11, 16, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(3717), 2, "Konsul w Kijowie", "PL053452", "Wiza krajowa", "D", null, null, new DateTime(2019, 2, 23, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(3746), new DateTime(2020, 2, 24, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(3751) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Passports_EmployeeId",
                table: "Passports",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Permits_EmployeeId",
                table: "Permits",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Permits_LocationId",
                table: "Permits",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Visas_EmployeeId",
                table: "Visas",
                column: "EmployeeId");
        }
    }
}
