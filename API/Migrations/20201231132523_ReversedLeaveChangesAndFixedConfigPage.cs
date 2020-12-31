using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class ReversedLeaveChangesAndFixedConfigPage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActualTo",
                table: "Leaves");

            migrationBuilder.DropColumn(
                name: "ExpectedTo",
                table: "Leaves");

            migrationBuilder.DropColumn(
                name: "MaximumLeaveTimeInDays",
                table: "ConfigurationPage");

            migrationBuilder.DropColumn(
                name: "WarningBeforeLeaveReachesLimit",
                table: "ConfigurationPage");

            migrationBuilder.AddColumn<DateTime>(
                name: "To",
                table: "Leaves",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2020, 12, 31, 14, 25, 22, 751, DateTimeKind.Local).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2020, 12, 31, 14, 25, 22, 751, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "PaidOn" },
                values: new object[] { new DateTime(2020, 12, 31, 14, 25, 22, 751, DateTimeKind.Local).AddTicks(9693), new DateTime(2020, 12, 31, 14, 25, 22, 751, DateTimeKind.Local).AddTicks(9696) });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 3, 6, 14, 25, 22, 746, DateTimeKind.Local).AddTicks(1598), new DateTime(2018, 12, 31, 14, 25, 22, 746, DateTimeKind.Local).AddTicks(1614), new DateTime(2023, 12, 31, 14, 25, 22, 746, DateTimeKind.Local).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 6, 14, 14, 25, 22, 746, DateTimeKind.Local).AddTicks(1636), new DateTime(2020, 6, 14, 14, 25, 22, 746, DateTimeKind.Local).AddTicks(1639), new DateTime(2023, 6, 14, 14, 25, 22, 746, DateTimeKind.Local).AddTicks(1642) });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 8, 3, 14, 25, 22, 746, DateTimeKind.Local).AddTicks(1645), new DateTime(2016, 8, 3, 14, 25, 22, 746, DateTimeKind.Local).AddTicks(1647), new DateTime(2021, 1, 29, 14, 25, 22, 746, DateTimeKind.Local).AddTicks(1650) });

            migrationBuilder.UpdateData(
                table: "ConfigurationPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 12, 31, 14, 25, 22, 741, DateTimeKind.Local).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 1,
                column: "ValidTo",
                value: new DateTime(2020, 7, 29, 14, 25, 22, 751, DateTimeKind.Local).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 2,
                column: "ValidTo",
                value: new DateTime(2020, 8, 30, 14, 25, 22, 751, DateTimeKind.Local).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 3,
                column: "ValidTo",
                value: new DateTime(2020, 8, 30, 14, 25, 22, 751, DateTimeKind.Local).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 4,
                column: "ValidTo",
                value: new DateTime(2020, 8, 30, 14, 25, 22, 751, DateTimeKind.Local).AddTicks(1758));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 5,
                column: "ValidTo",
                value: new DateTime(2020, 9, 29, 14, 25, 22, 751, DateTimeKind.Local).AddTicks(1777));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 6,
                column: "ValidTo",
                value: new DateTime(2020, 9, 29, 14, 25, 22, 751, DateTimeKind.Local).AddTicks(1795));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 7,
                column: "ValidTo",
                value: new DateTime(2020, 9, 29, 14, 25, 22, 751, DateTimeKind.Local).AddTicks(1814));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 8,
                column: "ValidTo",
                value: new DateTime(2020, 10, 29, 14, 25, 22, 751, DateTimeKind.Local).AddTicks(1833));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 9,
                column: "ValidTo",
                value: new DateTime(2020, 10, 29, 14, 25, 22, 751, DateTimeKind.Local).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 10,
                column: "ValidTo",
                value: new DateTime(2020, 10, 29, 14, 25, 22, 751, DateTimeKind.Local).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 11,
                column: "ValidTo",
                value: new DateTime(2020, 11, 29, 14, 25, 22, 751, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 12,
                column: "ValidTo",
                value: new DateTime(2020, 11, 29, 14, 25, 22, 751, DateTimeKind.Local).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 13,
                column: "ValidTo",
                value: new DateTime(2020, 11, 29, 14, 25, 22, 751, DateTimeKind.Local).AddTicks(1927));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 14,
                column: "ValidTo",
                value: new DateTime(2020, 12, 29, 14, 25, 22, 751, DateTimeKind.Local).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 15,
                column: "ValidTo",
                value: new DateTime(2020, 12, 29, 14, 25, 22, 751, DateTimeKind.Local).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 16,
                column: "ValidTo",
                value: new DateTime(2020, 12, 29, 14, 25, 22, 751, DateTimeKind.Local).AddTicks(1985));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 17,
                column: "ValidTo",
                value: new DateTime(2021, 1, 30, 14, 25, 22, 751, DateTimeKind.Local).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 18,
                column: "ValidTo",
                value: new DateTime(2021, 1, 30, 14, 25, 22, 751, DateTimeKind.Local).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 19,
                column: "ValidTo",
                value: new DateTime(2021, 1, 30, 14, 25, 22, 751, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 3, 6, 14, 25, 22, 742, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 4, 25, 14, 25, 22, 742, DateTimeKind.Local).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 4, 25, 14, 25, 22, 742, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2020, 8, 3, 14, 25, 22, 742, DateTimeKind.Local).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 3, 6, 14, 25, 22, 744, DateTimeKind.Local).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 4, 25, 14, 25, 22, 744, DateTimeKind.Local).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 4, 25, 14, 25, 22, 744, DateTimeKind.Local).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2020, 6, 14, 14, 25, 22, 744, DateTimeKind.Local).AddTicks(5237));

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2020, 8, 3, 14, 25, 22, 744, DateTimeKind.Local).AddTicks(5241));

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 22, 14, 25, 22, 744, DateTimeKind.Local).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Foremen",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 3, 6, 14, 25, 22, 743, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "Foremen",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 4, 25, 14, 25, 22, 743, DateTimeKind.Local).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "Foremen",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 6, 14, 14, 25, 22, 743, DateTimeKind.Local).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "From", "To" },
                values: new object[] { new DateTime(2020, 4, 25, 14, 25, 22, 746, DateTimeKind.Local).AddTicks(5627), new DateTime(2020, 5, 11, 14, 25, 22, 746, DateTimeKind.Local).AddTicks(6107), new DateTime(2020, 5, 25, 14, 25, 22, 746, DateTimeKind.Local).AddTicks(6595) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "From", "To" },
                values: new object[] { new DateTime(2020, 7, 27, 14, 25, 22, 746, DateTimeKind.Local).AddTicks(8039), new DateTime(2020, 8, 3, 14, 25, 22, 746, DateTimeKind.Local).AddTicks(8058), new DateTime(2020, 10, 12, 14, 25, 22, 746, DateTimeKind.Local).AddTicks(8066) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "From" },
                values: new object[] { new DateTime(2020, 10, 31, 14, 25, 22, 746, DateTimeKind.Local).AddTicks(8085), new DateTime(2020, 10, 31, 14, 25, 22, 746, DateTimeKind.Local).AddTicks(8088) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 3, 6, 14, 25, 22, 742, DateTimeKind.Local).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 4, 25, 14, 25, 22, 743, DateTimeKind.Local).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "MedicalCheckups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 3, 6, 14, 25, 22, 745, DateTimeKind.Local).AddTicks(568), new DateTime(2019, 1, 29, 14, 25, 22, 745, DateTimeKind.Local).AddTicks(2328), new DateTime(2021, 1, 29, 14, 25, 22, 745, DateTimeKind.Local).AddTicks(2866) });

            migrationBuilder.UpdateData(
                table: "MedicalCheckups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 4, 25, 14, 25, 22, 745, DateTimeKind.Local).AddTicks(3361), new DateTime(2019, 1, 30, 14, 25, 22, 745, DateTimeKind.Local).AddTicks(3417), new DateTime(2021, 1, 30, 14, 25, 22, 745, DateTimeKind.Local).AddTicks(3432) });

            migrationBuilder.UpdateData(
                table: "MedicalCheckups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 4, 25, 14, 25, 22, 745, DateTimeKind.Local).AddTicks(3442), new DateTime(2019, 4, 25, 14, 25, 22, 745, DateTimeKind.Local).AddTicks(3446), new DateTime(2021, 4, 25, 14, 25, 22, 745, DateTimeKind.Local).AddTicks(3449) });

            migrationBuilder.UpdateData(
                table: "MedicalCheckups",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 4, 25, 14, 25, 22, 745, DateTimeKind.Local).AddTicks(3452), new DateTime(2019, 8, 3, 14, 25, 22, 745, DateTimeKind.Local).AddTicks(3455), new DateTime(2021, 8, 3, 14, 25, 22, 745, DateTimeKind.Local).AddTicks(3458) });

            migrationBuilder.UpdateData(
                table: "SafetyTrainings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 3, 6, 14, 25, 22, 745, DateTimeKind.Local).AddTicks(8091), new DateTime(2020, 3, 6, 14, 25, 22, 745, DateTimeKind.Local).AddTicks(8108), new DateTime(2022, 3, 6, 14, 25, 22, 745, DateTimeKind.Local).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "SafetyTrainings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 4, 25, 14, 25, 22, 745, DateTimeKind.Local).AddTicks(8128), new DateTime(2020, 4, 25, 14, 25, 22, 745, DateTimeKind.Local).AddTicks(8131), new DateTime(2022, 4, 25, 14, 25, 22, 745, DateTimeKind.Local).AddTicks(8133) });

            migrationBuilder.UpdateData(
                table: "SafetyTrainings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 4, 25, 14, 25, 22, 745, DateTimeKind.Local).AddTicks(8137), new DateTime(2020, 4, 25, 14, 25, 22, 745, DateTimeKind.Local).AddTicks(8140), new DateTime(2022, 4, 25, 14, 25, 22, 745, DateTimeKind.Local).AddTicks(8142) });

            migrationBuilder.UpdateData(
                table: "SafetyTrainings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 6, 14, 14, 25, 22, 745, DateTimeKind.Local).AddTicks(8145), new DateTime(2020, 6, 14, 14, 25, 22, 745, DateTimeKind.Local).AddTicks(8148), new DateTime(2021, 6, 14, 14, 25, 22, 745, DateTimeKind.Local).AddTicks(8150) });

            migrationBuilder.UpdateData(
                table: "SafetyTrainings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 6, 14, 14, 25, 22, 745, DateTimeKind.Local).AddTicks(8153), new DateTime(2020, 8, 3, 14, 25, 22, 745, DateTimeKind.Local).AddTicks(8156), new DateTime(2022, 8, 3, 14, 25, 22, 745, DateTimeKind.Local).AddTicks(8158) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 12, 31, 14, 25, 22, 737, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 12, 31, 14, 25, 22, 740, DateTimeKind.Local).AddTicks(3369));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 12, 31, 14, 25, 22, 740, DateTimeKind.Local).AddTicks(3439));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "To",
                table: "Leaves");

            migrationBuilder.AddColumn<DateTime>(
                name: "ActualTo",
                table: "Leaves",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpectedTo",
                table: "Leaves",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaximumLeaveTimeInDays",
                table: "ConfigurationPage",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WarningBeforeLeaveReachesLimit",
                table: "ConfigurationPage",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2020, 12, 31, 14, 19, 5, 345, DateTimeKind.Local).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2020, 12, 31, 14, 19, 5, 345, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "PaidOn" },
                values: new object[] { new DateTime(2020, 12, 31, 14, 19, 5, 345, DateTimeKind.Local).AddTicks(9433), new DateTime(2020, 12, 31, 14, 19, 5, 345, DateTimeKind.Local).AddTicks(9435) });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 3, 6, 14, 19, 5, 339, DateTimeKind.Local).AddTicks(5290), new DateTime(2018, 12, 31, 14, 19, 5, 339, DateTimeKind.Local).AddTicks(5308), new DateTime(2023, 12, 31, 14, 19, 5, 339, DateTimeKind.Local).AddTicks(5312) });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 6, 14, 14, 19, 5, 339, DateTimeKind.Local).AddTicks(5330), new DateTime(2020, 6, 14, 14, 19, 5, 339, DateTimeKind.Local).AddTicks(5333), new DateTime(2023, 6, 14, 14, 19, 5, 339, DateTimeKind.Local).AddTicks(5335) });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 8, 3, 14, 19, 5, 339, DateTimeKind.Local).AddTicks(5338), new DateTime(2016, 8, 3, 14, 19, 5, 339, DateTimeKind.Local).AddTicks(5341), new DateTime(2021, 1, 29, 14, 19, 5, 339, DateTimeKind.Local).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "ConfigurationPage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "MaximumLeaveTimeInDays", "WarningBeforeLeaveReachesLimit" },
                values: new object[] { new DateTime(2020, 12, 31, 14, 19, 5, 334, DateTimeKind.Local).AddTicks(5390), 90, 60 });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 1,
                column: "ValidTo",
                value: new DateTime(2020, 7, 29, 14, 19, 5, 344, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 2,
                column: "ValidTo",
                value: new DateTime(2020, 8, 30, 14, 19, 5, 345, DateTimeKind.Local).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 3,
                column: "ValidTo",
                value: new DateTime(2020, 8, 30, 14, 19, 5, 345, DateTimeKind.Local).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 4,
                column: "ValidTo",
                value: new DateTime(2020, 8, 30, 14, 19, 5, 345, DateTimeKind.Local).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 5,
                column: "ValidTo",
                value: new DateTime(2020, 9, 29, 14, 19, 5, 345, DateTimeKind.Local).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 6,
                column: "ValidTo",
                value: new DateTime(2020, 9, 29, 14, 19, 5, 345, DateTimeKind.Local).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 7,
                column: "ValidTo",
                value: new DateTime(2020, 9, 29, 14, 19, 5, 345, DateTimeKind.Local).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 8,
                column: "ValidTo",
                value: new DateTime(2020, 10, 29, 14, 19, 5, 345, DateTimeKind.Local).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 9,
                column: "ValidTo",
                value: new DateTime(2020, 10, 29, 14, 19, 5, 345, DateTimeKind.Local).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 10,
                column: "ValidTo",
                value: new DateTime(2020, 10, 29, 14, 19, 5, 345, DateTimeKind.Local).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 11,
                column: "ValidTo",
                value: new DateTime(2020, 11, 29, 14, 19, 5, 345, DateTimeKind.Local).AddTicks(605));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 12,
                column: "ValidTo",
                value: new DateTime(2020, 11, 29, 14, 19, 5, 345, DateTimeKind.Local).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 13,
                column: "ValidTo",
                value: new DateTime(2020, 11, 29, 14, 19, 5, 345, DateTimeKind.Local).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 14,
                column: "ValidTo",
                value: new DateTime(2020, 12, 29, 14, 19, 5, 345, DateTimeKind.Local).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 15,
                column: "ValidTo",
                value: new DateTime(2020, 12, 29, 14, 19, 5, 345, DateTimeKind.Local).AddTicks(780));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 16,
                column: "ValidTo",
                value: new DateTime(2020, 12, 29, 14, 19, 5, 345, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 17,
                column: "ValidTo",
                value: new DateTime(2021, 1, 30, 14, 19, 5, 345, DateTimeKind.Local).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 18,
                column: "ValidTo",
                value: new DateTime(2021, 1, 30, 14, 19, 5, 345, DateTimeKind.Local).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 19,
                column: "ValidTo",
                value: new DateTime(2021, 1, 30, 14, 19, 5, 345, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 3, 6, 14, 19, 5, 335, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 4, 25, 14, 19, 5, 335, DateTimeKind.Local).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 4, 25, 14, 19, 5, 335, DateTimeKind.Local).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2020, 8, 3, 14, 19, 5, 335, DateTimeKind.Local).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 3, 6, 14, 19, 5, 337, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 4, 25, 14, 19, 5, 337, DateTimeKind.Local).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 4, 25, 14, 19, 5, 337, DateTimeKind.Local).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2020, 6, 14, 14, 19, 5, 337, DateTimeKind.Local).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2020, 8, 3, 14, 19, 5, 337, DateTimeKind.Local).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 22, 14, 19, 5, 337, DateTimeKind.Local).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "Foremen",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 3, 6, 14, 19, 5, 336, DateTimeKind.Local).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "Foremen",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 4, 25, 14, 19, 5, 336, DateTimeKind.Local).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "Foremen",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 6, 14, 14, 19, 5, 336, DateTimeKind.Local).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ExpectedTo", "From" },
                values: new object[] { new DateTime(2020, 4, 25, 14, 19, 5, 339, DateTimeKind.Local).AddTicks(9374), new DateTime(2020, 5, 25, 14, 19, 5, 340, DateTimeKind.Local).AddTicks(387), new DateTime(2020, 5, 11, 14, 19, 5, 339, DateTimeKind.Local).AddTicks(9876) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpectedTo", "From" },
                values: new object[] { new DateTime(2020, 7, 27, 14, 19, 5, 340, DateTimeKind.Local).AddTicks(1912), new DateTime(2020, 10, 12, 14, 19, 5, 340, DateTimeKind.Local).AddTicks(1941), new DateTime(2020, 8, 3, 14, 19, 5, 340, DateTimeKind.Local).AddTicks(1932) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "From" },
                values: new object[] { new DateTime(2020, 10, 31, 14, 19, 5, 340, DateTimeKind.Local).AddTicks(2497), new DateTime(2020, 10, 31, 14, 19, 5, 340, DateTimeKind.Local).AddTicks(2503) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 3, 6, 14, 19, 5, 335, DateTimeKind.Local).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 4, 25, 14, 19, 5, 336, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "MedicalCheckups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 3, 6, 14, 19, 5, 338, DateTimeKind.Local).AddTicks(3501), new DateTime(2019, 1, 29, 14, 19, 5, 338, DateTimeKind.Local).AddTicks(5341), new DateTime(2021, 1, 29, 14, 19, 5, 338, DateTimeKind.Local).AddTicks(5877) });

            migrationBuilder.UpdateData(
                table: "MedicalCheckups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 4, 25, 14, 19, 5, 338, DateTimeKind.Local).AddTicks(6366), new DateTime(2019, 1, 30, 14, 19, 5, 338, DateTimeKind.Local).AddTicks(6424), new DateTime(2021, 1, 30, 14, 19, 5, 338, DateTimeKind.Local).AddTicks(6438) });

            migrationBuilder.UpdateData(
                table: "MedicalCheckups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 4, 25, 14, 19, 5, 338, DateTimeKind.Local).AddTicks(6449), new DateTime(2019, 4, 25, 14, 19, 5, 338, DateTimeKind.Local).AddTicks(6452), new DateTime(2021, 4, 25, 14, 19, 5, 338, DateTimeKind.Local).AddTicks(6455) });

            migrationBuilder.UpdateData(
                table: "MedicalCheckups",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 4, 25, 14, 19, 5, 338, DateTimeKind.Local).AddTicks(6459), new DateTime(2019, 8, 3, 14, 19, 5, 338, DateTimeKind.Local).AddTicks(6461), new DateTime(2021, 8, 3, 14, 19, 5, 338, DateTimeKind.Local).AddTicks(6464) });

            migrationBuilder.UpdateData(
                table: "SafetyTrainings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 3, 6, 14, 19, 5, 339, DateTimeKind.Local).AddTicks(1240), new DateTime(2020, 3, 6, 14, 19, 5, 339, DateTimeKind.Local).AddTicks(1257), new DateTime(2022, 3, 6, 14, 19, 5, 339, DateTimeKind.Local).AddTicks(1260) });

            migrationBuilder.UpdateData(
                table: "SafetyTrainings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 4, 25, 14, 19, 5, 339, DateTimeKind.Local).AddTicks(1277), new DateTime(2020, 4, 25, 14, 19, 5, 339, DateTimeKind.Local).AddTicks(1281), new DateTime(2022, 4, 25, 14, 19, 5, 339, DateTimeKind.Local).AddTicks(1284) });

            migrationBuilder.UpdateData(
                table: "SafetyTrainings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 4, 25, 14, 19, 5, 339, DateTimeKind.Local).AddTicks(1288), new DateTime(2020, 4, 25, 14, 19, 5, 339, DateTimeKind.Local).AddTicks(1291), new DateTime(2022, 4, 25, 14, 19, 5, 339, DateTimeKind.Local).AddTicks(1293) });

            migrationBuilder.UpdateData(
                table: "SafetyTrainings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 6, 14, 14, 19, 5, 339, DateTimeKind.Local).AddTicks(1297), new DateTime(2020, 6, 14, 14, 19, 5, 339, DateTimeKind.Local).AddTicks(1299), new DateTime(2021, 6, 14, 14, 19, 5, 339, DateTimeKind.Local).AddTicks(1302) });

            migrationBuilder.UpdateData(
                table: "SafetyTrainings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 6, 14, 14, 19, 5, 339, DateTimeKind.Local).AddTicks(1305), new DateTime(2020, 8, 3, 14, 19, 5, 339, DateTimeKind.Local).AddTicks(1308), new DateTime(2022, 8, 3, 14, 19, 5, 339, DateTimeKind.Local).AddTicks(1310) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 12, 31, 14, 19, 5, 329, DateTimeKind.Local).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 12, 31, 14, 19, 5, 332, DateTimeKind.Local).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 12, 31, 14, 19, 5, 332, DateTimeKind.Local).AddTicks(9895));
        }
    }
}
