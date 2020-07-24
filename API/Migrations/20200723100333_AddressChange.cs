using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class AddressChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeesHistory_EmployeeAddresses_EmployeeAddressId",
                table: "EmployeesHistory");

            migrationBuilder.DropTable(
                name: "EmployeeAddresses");

            migrationBuilder.DropIndex(
                name: "IX_EmployeesHistory_EmployeeAddressId",
                table: "EmployeesHistory");

            migrationBuilder.DropColumn(
                name: "EmployeeAddressId",
                table: "EmployeesHistory");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "EmployeesHistory",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "EmployeesHistory",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "EmployeesHistory",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Region",
                table: "EmployeesHistory",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "EmployeesHistory",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Zip",
                table: "EmployeesHistory",
                nullable: true);

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
                columns: new[] { "City", "Country", "CreatedOn", "Number", "Region", "Street", "Zip" },
                values: new object[] { "Kosokowo", "Polska", new DateTime(2019, 9, 27, 12, 3, 32, 228, DateTimeKind.Local).AddTicks(7445), "26C", "Pomorze", "Rzemieślnicza", "81-198" });

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Country", "CreatedOn", "Number", "Region", "Street", "Zip" },
                values: new object[] { "Rumia", "Polska", new DateTime(2019, 11, 16, 12, 3, 32, 228, DateTimeKind.Local).AddTicks(9937), "20A", "Pomorze", "Świętopełka", "84-230" });

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Country", "CreatedOn", "Number", "Region", "Street", "Zip" },
                values: new object[] { "Gdynia", "Polska", new DateTime(2019, 11, 16, 12, 3, 32, 228, DateTimeKind.Local).AddTicks(9986), "6", "Pomorze", "Spokojna", "81-549" });

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "Country", "CreatedOn", "Number", "Region", "Street", "Zip" },
                values: new object[] { "Gdańsk", "Polska", new DateTime(2020, 1, 5, 12, 3, 32, 228, DateTimeKind.Local).AddTicks(9991), "12", "Pomorze", "Ks. Mariana Góreckiego", "80-553" });

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "Country", "CreatedOn", "Number", "Region", "Street", "Zip" },
                values: new object[] { "Pogórze", "Polska", new DateTime(2020, 2, 24, 12, 3, 32, 228, DateTimeKind.Local).AddTicks(9995), "13", "Pomorze", "Wapienna", "81-198" });

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "Country", "CreatedOn", "Number", "Region", "Street", "Zip" },
                values: new object[] { "Gdańsk", "Polska", new DateTime(2020, 4, 14, 12, 3, 32, 228, DateTimeKind.Local).AddTicks(9998), "3-1", "Pomorze", "Nadmorski Dwór", "80-506" });

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

            migrationBuilder.UpdateData(
                table: "Passports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 16, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(9083), new DateTime(2010, 2, 23, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(9098), new DateTime(2020, 2, 24, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(9103) });

            migrationBuilder.UpdateData(
                table: "Passports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 16, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(9118), new DateTime(2019, 7, 23, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(9122), new DateTime(2029, 7, 23, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(9125) });

            migrationBuilder.UpdateData(
                table: "Passports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 2, 24, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(9128), new DateTime(2010, 8, 21, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(9131), new DateTime(2049, 7, 23, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(9134) });

            migrationBuilder.UpdateData(
                table: "Passports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 5, 4, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(9137), new DateTime(2020, 4, 14, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(9140), new DateTime(2030, 4, 14, 12, 3, 32, 230, DateTimeKind.Local).AddTicks(9142) });

            migrationBuilder.UpdateData(
                table: "Permits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 16, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(8203), new DateTime(2019, 11, 16, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(8658), new DateTime(2020, 2, 24, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(8669) });

            migrationBuilder.UpdateData(
                table: "Permits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 2, 24, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(8686), new DateTime(2020, 2, 24, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(8698), new DateTime(2025, 2, 23, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(8701) });

            migrationBuilder.UpdateData(
                table: "Permits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 2, 24, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(8706), new DateTime(2019, 8, 21, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(8709), new DateTime(2020, 8, 21, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "Permits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 4, 14, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(8715), new DateTime(2020, 4, 14, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(8718), new DateTime(2023, 4, 14, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(8721) });

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

            migrationBuilder.UpdateData(
                table: "Visas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 16, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(3717), new DateTime(2019, 2, 23, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(3746), new DateTime(2020, 2, 24, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(3751) });

            migrationBuilder.UpdateData(
                table: "Visas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 2, 24, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(3762), new DateTime(2020, 2, 24, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(3765), new DateTime(2021, 2, 23, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(3767) });

            migrationBuilder.UpdateData(
                table: "Visas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 2, 24, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(3771), new DateTime(2019, 8, 21, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(3774), new DateTime(2020, 8, 21, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(3778) });

            migrationBuilder.UpdateData(
                table: "Visas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 5, 4, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(3780), new DateTime(2020, 4, 14, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(3783), new DateTime(2021, 4, 14, 12, 3, 32, 231, DateTimeKind.Local).AddTicks(3786) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "EmployeesHistory");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "EmployeesHistory");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "EmployeesHistory");

            migrationBuilder.DropColumn(
                name: "Region",
                table: "EmployeesHistory");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "EmployeesHistory");

            migrationBuilder.DropColumn(
                name: "Zip",
                table: "EmployeesHistory");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeAddressId",
                table: "EmployeesHistory",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EmployeeAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Zip = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeAddresses", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2020, 7, 22, 16, 20, 21, 917, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2020, 7, 22, 16, 20, 21, 917, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "PaidOn" },
                values: new object[] { new DateTime(2020, 7, 22, 16, 20, 21, 917, DateTimeKind.Local).AddTicks(5084), new DateTime(2020, 7, 22, 16, 20, 21, 917, DateTimeKind.Local).AddTicks(5087) });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 9, 26, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(4809), new DateTime(2018, 7, 22, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(4825), new DateTime(2023, 7, 22, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(4829) });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 1, 4, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(4847), new DateTime(2020, 1, 4, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(4850), new DateTime(2023, 1, 3, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(4853) });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 2, 23, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(4856), new DateTime(2016, 2, 23, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(4859), new DateTime(2020, 8, 20, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(4862) });

            migrationBuilder.UpdateData(
                table: "ConfigurationPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 7, 22, 16, 20, 21, 905, DateTimeKind.Local).AddTicks(4528));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 1,
                column: "ValidTo",
                value: new DateTime(2020, 2, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 2,
                column: "ValidTo",
                value: new DateTime(2020, 3, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 3,
                column: "ValidTo",
                value: new DateTime(2020, 3, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 4,
                column: "ValidTo",
                value: new DateTime(2020, 3, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 5,
                column: "ValidTo",
                value: new DateTime(2020, 4, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 6,
                column: "ValidTo",
                value: new DateTime(2020, 4, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 7,
                column: "ValidTo",
                value: new DateTime(2020, 4, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 8,
                column: "ValidTo",
                value: new DateTime(2020, 5, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 9,
                column: "ValidTo",
                value: new DateTime(2020, 5, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 10,
                column: "ValidTo",
                value: new DateTime(2020, 5, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 11,
                column: "ValidTo",
                value: new DateTime(2020, 6, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 12,
                column: "ValidTo",
                value: new DateTime(2020, 6, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 13,
                column: "ValidTo",
                value: new DateTime(2020, 6, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 14,
                column: "ValidTo",
                value: new DateTime(2020, 7, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 15,
                column: "ValidTo",
                value: new DateTime(2020, 7, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 16,
                column: "ValidTo",
                value: new DateTime(2020, 7, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 17,
                column: "ValidTo",
                value: new DateTime(2020, 8, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 18,
                column: "ValidTo",
                value: new DateTime(2020, 8, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 19,
                column: "ValidTo",
                value: new DateTime(2020, 8, 21, 16, 20, 21, 916, DateTimeKind.Local).AddTicks(7875));

            migrationBuilder.InsertData(
                table: "EmployeeAddresses",
                columns: new[] { "Id", "City", "Country", "CreatedBy", "CreatedOn", "Number", "Region", "Street", "UpdatedBy", "UpdatedOn", "Zip" },
                values: new object[,]
                {
                    { 1, "Kosokowo", "Polska", "Initial", new DateTime(2019, 9, 26, 16, 20, 21, 908, DateTimeKind.Local).AddTicks(405), "26C", "Pomorze", "Rzemieślnicza", null, null, "81-198" },
                    { 2, "Rumia", "Polska", "Initial", new DateTime(2019, 11, 15, 16, 20, 21, 908, DateTimeKind.Local).AddTicks(438), "20A", "Pomorze", "Świętopełka", null, null, "84-230" },
                    { 3, "Gdynia", "Polska", "Initial", new DateTime(2019, 11, 15, 16, 20, 21, 908, DateTimeKind.Local).AddTicks(443), "6", "Pomorze", "Spokojna", null, null, "81-549" },
                    { 5, "Pogórze", "Polska", "Initial", new DateTime(2020, 2, 23, 16, 20, 21, 908, DateTimeKind.Local).AddTicks(449), "13", "Pomorze", "Wapienna", null, null, "81-198" },
                    { 4, "Gdańsk", "Polska", "Initial", new DateTime(2020, 1, 4, 16, 20, 21, 908, DateTimeKind.Local).AddTicks(446), "12", "Pomorze", "Ks. Mariana Góreckiego", null, null, "80-553" },
                    { 6, "Gdańsk", "Polska", "Initial", new DateTime(2020, 4, 13, 16, 20, 21, 908, DateTimeKind.Local).AddTicks(453), "3-1", "Pomorze", "Nadmorski Dwór", null, null, "80-506" }
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 9, 26, 16, 20, 21, 906, DateTimeKind.Local).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2019, 11, 15, 16, 20, 21, 906, DateTimeKind.Local).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2019, 11, 15, 16, 20, 21, 906, DateTimeKind.Local).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2020, 2, 23, 16, 20, 21, 906, DateTimeKind.Local).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "Foremen",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 9, 26, 16, 20, 21, 907, DateTimeKind.Local).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "Foremen",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2019, 11, 15, 16, 20, 21, 907, DateTimeKind.Local).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "Foremen",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 4, 16, 20, 21, 907, DateTimeKind.Local).AddTicks(6366));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "From", "To" },
                values: new object[] { new DateTime(2019, 11, 15, 16, 20, 21, 912, DateTimeKind.Local).AddTicks(1597), new DateTime(2019, 12, 1, 16, 20, 21, 912, DateTimeKind.Local).AddTicks(2070), new DateTime(2019, 12, 15, 16, 20, 21, 912, DateTimeKind.Local).AddTicks(2588) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "From", "To" },
                values: new object[] { new DateTime(2020, 2, 16, 16, 20, 21, 912, DateTimeKind.Local).AddTicks(3981), new DateTime(2020, 2, 23, 16, 20, 21, 912, DateTimeKind.Local).AddTicks(4001), new DateTime(2020, 5, 3, 16, 20, 21, 912, DateTimeKind.Local).AddTicks(4010) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "From" },
                values: new object[] { new DateTime(2020, 5, 22, 16, 20, 21, 912, DateTimeKind.Local).AddTicks(4031), new DateTime(2020, 5, 22, 16, 20, 21, 912, DateTimeKind.Local).AddTicks(4034) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 9, 26, 16, 20, 21, 906, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2019, 11, 15, 16, 20, 21, 907, DateTimeKind.Local).AddTicks(1362));

            migrationBuilder.UpdateData(
                table: "MedicalCheckups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 9, 26, 16, 20, 21, 909, DateTimeKind.Local).AddTicks(4048), new DateTime(2018, 8, 20, 16, 20, 21, 909, DateTimeKind.Local).AddTicks(5695), new DateTime(2020, 8, 20, 16, 20, 21, 909, DateTimeKind.Local).AddTicks(6193) });

            migrationBuilder.UpdateData(
                table: "MedicalCheckups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 15, 16, 20, 21, 909, DateTimeKind.Local).AddTicks(6646), new DateTime(2018, 8, 21, 16, 20, 21, 909, DateTimeKind.Local).AddTicks(6704), new DateTime(2020, 8, 21, 16, 20, 21, 909, DateTimeKind.Local).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "MedicalCheckups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 15, 16, 20, 21, 909, DateTimeKind.Local).AddTicks(6729), new DateTime(2018, 11, 14, 16, 20, 21, 909, DateTimeKind.Local).AddTicks(6732), new DateTime(2020, 11, 14, 16, 20, 21, 909, DateTimeKind.Local).AddTicks(6735) });

            migrationBuilder.UpdateData(
                table: "MedicalCheckups",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 15, 16, 20, 21, 909, DateTimeKind.Local).AddTicks(6739), new DateTime(2019, 2, 22, 16, 20, 21, 909, DateTimeKind.Local).AddTicks(6742), new DateTime(2021, 2, 22, 16, 20, 21, 909, DateTimeKind.Local).AddTicks(6745) });

            migrationBuilder.UpdateData(
                table: "Passports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 15, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(8780), new DateTime(2010, 2, 22, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(8797), new DateTime(2020, 2, 23, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(8801) });

            migrationBuilder.UpdateData(
                table: "Passports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 15, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(8820), new DateTime(2019, 7, 22, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(8823), new DateTime(2029, 7, 22, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "Passports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 2, 23, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(8830), new DateTime(2010, 8, 20, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(8832), new DateTime(2049, 7, 22, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(8836) });

            migrationBuilder.UpdateData(
                table: "Passports",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 5, 3, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(8839), new DateTime(2020, 4, 13, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(8842), new DateTime(2030, 4, 13, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(8845) });

            migrationBuilder.UpdateData(
                table: "Permits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 15, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(7560), new DateTime(2019, 11, 15, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(8026), new DateTime(2020, 2, 23, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(8039) });

            migrationBuilder.UpdateData(
                table: "Permits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 2, 23, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(8057), new DateTime(2020, 2, 23, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(8067), new DateTime(2025, 2, 22, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "Permits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 2, 23, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(8075), new DateTime(2019, 8, 20, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(8078), new DateTime(2020, 8, 20, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(8081) });

            migrationBuilder.UpdateData(
                table: "Permits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 4, 13, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(8084), new DateTime(2020, 4, 13, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(8087), new DateTime(2023, 4, 13, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(8090) });

            migrationBuilder.UpdateData(
                table: "SafetyTrainings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 9, 26, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(1424), new DateTime(2019, 9, 26, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(1441), new DateTime(2021, 9, 25, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(1444) });

            migrationBuilder.UpdateData(
                table: "SafetyTrainings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 15, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(1465), new DateTime(2019, 11, 15, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(1469), new DateTime(2021, 11, 14, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(1471) });

            migrationBuilder.UpdateData(
                table: "SafetyTrainings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 15, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(1475), new DateTime(2019, 11, 15, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(1478), new DateTime(2021, 11, 14, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "SafetyTrainings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 1, 4, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(1484), new DateTime(2020, 1, 4, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(1487), new DateTime(2021, 1, 3, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(1489) });

            migrationBuilder.UpdateData(
                table: "SafetyTrainings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 1, 4, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(1492), new DateTime(2020, 2, 23, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(1495), new DateTime(2022, 2, 22, 16, 20, 21, 910, DateTimeKind.Local).AddTicks(1497) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 7, 22, 16, 20, 21, 901, DateTimeKind.Local).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 7, 22, 16, 20, 21, 904, DateTimeKind.Local).AddTicks(2273));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 7, 22, 16, 20, 21, 904, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "Visas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 15, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(3491), new DateTime(2019, 2, 22, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(3521), new DateTime(2020, 2, 23, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(3526) });

            migrationBuilder.UpdateData(
                table: "Visas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 2, 23, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(3538), new DateTime(2020, 2, 23, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(3541), new DateTime(2021, 2, 22, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(3543) });

            migrationBuilder.UpdateData(
                table: "Visas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 2, 23, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(3548), new DateTime(2019, 8, 20, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(3551), new DateTime(2020, 8, 20, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(3554) });

            migrationBuilder.UpdateData(
                table: "Visas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 5, 3, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(3557), new DateTime(2020, 4, 13, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(3560), new DateTime(2021, 4, 13, 16, 20, 21, 911, DateTimeKind.Local).AddTicks(3562) });

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "EmployeeAddressId" },
                values: new object[] { new DateTime(2019, 9, 26, 16, 20, 21, 908, DateTimeKind.Local).AddTicks(5952), 1 });

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "EmployeeAddressId" },
                values: new object[] { new DateTime(2019, 11, 15, 16, 20, 21, 908, DateTimeKind.Local).AddTicks(8918), 2 });

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "EmployeeAddressId" },
                values: new object[] { new DateTime(2019, 11, 15, 16, 20, 21, 908, DateTimeKind.Local).AddTicks(9000), 3 });

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "EmployeeAddressId" },
                values: new object[] { new DateTime(2020, 1, 4, 16, 20, 21, 908, DateTimeKind.Local).AddTicks(9004), 4 });

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "EmployeeAddressId" },
                values: new object[] { new DateTime(2020, 2, 23, 16, 20, 21, 908, DateTimeKind.Local).AddTicks(9008), 5 });

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "EmployeeAddressId" },
                values: new object[] { new DateTime(2020, 4, 13, 16, 20, 21, 908, DateTimeKind.Local).AddTicks(9011), 6 });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesHistory_EmployeeAddressId",
                table: "EmployeesHistory",
                column: "EmployeeAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeesHistory_EmployeeAddresses_EmployeeAddressId",
                table: "EmployeesHistory",
                column: "EmployeeAddressId",
                principalTable: "EmployeeAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
