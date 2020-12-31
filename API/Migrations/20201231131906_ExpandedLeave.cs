using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class ExpandedLeave : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "To",
                table: "Leaves");

            migrationBuilder.AddColumn<DateTime>(
                name: "ActualTo",
                table: "Leaves",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpectedTo",
                table: "Leaves",
                nullable: true);

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
                column: "CreatedOn",
                value: new DateTime(2020, 12, 31, 14, 19, 5, 334, DateTimeKind.Local).AddTicks(5390));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActualTo",
                table: "Leaves");

            migrationBuilder.DropColumn(
                name: "ExpectedTo",
                table: "Leaves");

            migrationBuilder.AddColumn<DateTime>(
                name: "To",
                table: "Leaves",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2020, 12, 25, 19, 13, 1, 61, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2020, 12, 25, 19, 13, 1, 61, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "PaidOn" },
                values: new object[] { new DateTime(2020, 12, 25, 19, 13, 1, 61, DateTimeKind.Local).AddTicks(7741), new DateTime(2020, 12, 25, 19, 13, 1, 61, DateTimeKind.Local).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 2, 29, 19, 13, 1, 55, DateTimeKind.Local).AddTicks(9225), new DateTime(2018, 12, 25, 19, 13, 1, 55, DateTimeKind.Local).AddTicks(9240), new DateTime(2023, 12, 25, 19, 13, 1, 55, DateTimeKind.Local).AddTicks(9245) });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 6, 8, 19, 13, 1, 55, DateTimeKind.Local).AddTicks(9262), new DateTime(2020, 6, 8, 19, 13, 1, 55, DateTimeKind.Local).AddTicks(9265), new DateTime(2023, 6, 8, 19, 13, 1, 55, DateTimeKind.Local).AddTicks(9267) });

            migrationBuilder.UpdateData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 7, 28, 19, 13, 1, 55, DateTimeKind.Local).AddTicks(9271), new DateTime(2016, 7, 28, 19, 13, 1, 55, DateTimeKind.Local).AddTicks(9273), new DateTime(2021, 1, 23, 19, 13, 1, 55, DateTimeKind.Local).AddTicks(9276) });

            migrationBuilder.UpdateData(
                table: "ConfigurationPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 12, 25, 19, 13, 1, 51, DateTimeKind.Local).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 1,
                column: "ValidTo",
                value: new DateTime(2020, 7, 24, 19, 13, 1, 60, DateTimeKind.Local).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 2,
                column: "ValidTo",
                value: new DateTime(2020, 8, 24, 19, 13, 1, 60, DateTimeKind.Local).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 3,
                column: "ValidTo",
                value: new DateTime(2020, 8, 24, 19, 13, 1, 60, DateTimeKind.Local).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 4,
                column: "ValidTo",
                value: new DateTime(2020, 8, 24, 19, 13, 1, 60, DateTimeKind.Local).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 5,
                column: "ValidTo",
                value: new DateTime(2020, 9, 24, 19, 13, 1, 60, DateTimeKind.Local).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 6,
                column: "ValidTo",
                value: new DateTime(2020, 9, 24, 19, 13, 1, 60, DateTimeKind.Local).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 7,
                column: "ValidTo",
                value: new DateTime(2020, 9, 24, 19, 13, 1, 60, DateTimeKind.Local).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 8,
                column: "ValidTo",
                value: new DateTime(2020, 10, 24, 19, 13, 1, 60, DateTimeKind.Local).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 9,
                column: "ValidTo",
                value: new DateTime(2020, 10, 24, 19, 13, 1, 60, DateTimeKind.Local).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 10,
                column: "ValidTo",
                value: new DateTime(2020, 10, 24, 19, 13, 1, 60, DateTimeKind.Local).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 11,
                column: "ValidTo",
                value: new DateTime(2020, 11, 24, 19, 13, 1, 60, DateTimeKind.Local).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 12,
                column: "ValidTo",
                value: new DateTime(2020, 11, 24, 19, 13, 1, 60, DateTimeKind.Local).AddTicks(9992));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 13,
                column: "ValidTo",
                value: new DateTime(2020, 11, 24, 19, 13, 1, 61, DateTimeKind.Local).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 14,
                column: "ValidTo",
                value: new DateTime(2020, 12, 24, 19, 13, 1, 61, DateTimeKind.Local).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 15,
                column: "ValidTo",
                value: new DateTime(2020, 12, 24, 19, 13, 1, 61, DateTimeKind.Local).AddTicks(48));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 16,
                column: "ValidTo",
                value: new DateTime(2020, 12, 24, 19, 13, 1, 61, DateTimeKind.Local).AddTicks(66));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 17,
                column: "ValidTo",
                value: new DateTime(2021, 1, 24, 19, 13, 1, 61, DateTimeKind.Local).AddTicks(83));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 18,
                column: "ValidTo",
                value: new DateTime(2021, 1, 24, 19, 13, 1, 61, DateTimeKind.Local).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 19,
                column: "ValidTo",
                value: new DateTime(2021, 1, 24, 19, 13, 1, 61, DateTimeKind.Local).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 2, 29, 19, 13, 1, 52, DateTimeKind.Local).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 4, 19, 19, 13, 1, 52, DateTimeKind.Local).AddTicks(3677));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 4, 19, 19, 13, 1, 52, DateTimeKind.Local).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2020, 7, 28, 19, 13, 1, 52, DateTimeKind.Local).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 2, 29, 19, 13, 1, 54, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 4, 19, 19, 13, 1, 54, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 4, 19, 19, 13, 1, 54, DateTimeKind.Local).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2020, 6, 8, 19, 13, 1, 54, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2020, 7, 28, 19, 13, 1, 54, DateTimeKind.Local).AddTicks(3376));

            migrationBuilder.UpdateData(
                table: "EmployeesHistory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2020, 9, 16, 19, 13, 1, 54, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "Foremen",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 2, 29, 19, 13, 1, 53, DateTimeKind.Local).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "Foremen",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 4, 19, 19, 13, 1, 53, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Foremen",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 6, 8, 19, 13, 1, 53, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "From", "To" },
                values: new object[] { new DateTime(2020, 4, 19, 19, 13, 1, 56, DateTimeKind.Local).AddTicks(3180), new DateTime(2020, 5, 5, 19, 13, 1, 56, DateTimeKind.Local).AddTicks(3655), new DateTime(2020, 5, 19, 19, 13, 1, 56, DateTimeKind.Local).AddTicks(4127) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "From", "To" },
                values: new object[] { new DateTime(2020, 7, 21, 19, 13, 1, 56, DateTimeKind.Local).AddTicks(5526), new DateTime(2020, 7, 28, 19, 13, 1, 56, DateTimeKind.Local).AddTicks(5545), new DateTime(2020, 10, 6, 19, 13, 1, 56, DateTimeKind.Local).AddTicks(5554) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "From" },
                values: new object[] { new DateTime(2020, 10, 25, 19, 13, 1, 56, DateTimeKind.Local).AddTicks(5573), new DateTime(2020, 10, 25, 19, 13, 1, 56, DateTimeKind.Local).AddTicks(5575) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 2, 29, 19, 13, 1, 52, DateTimeKind.Local).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 4, 19, 19, 13, 1, 52, DateTimeKind.Local).AddTicks(9501));

            migrationBuilder.UpdateData(
                table: "MedicalCheckups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 2, 29, 19, 13, 1, 54, DateTimeKind.Local).AddTicks(8527), new DateTime(2019, 1, 23, 19, 13, 1, 55, DateTimeKind.Local).AddTicks(154), new DateTime(2021, 1, 23, 19, 13, 1, 55, DateTimeKind.Local).AddTicks(652) });

            migrationBuilder.UpdateData(
                table: "MedicalCheckups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 4, 19, 19, 13, 1, 55, DateTimeKind.Local).AddTicks(1105), new DateTime(2019, 1, 24, 19, 13, 1, 55, DateTimeKind.Local).AddTicks(1161), new DateTime(2021, 1, 24, 19, 13, 1, 55, DateTimeKind.Local).AddTicks(1175) });

            migrationBuilder.UpdateData(
                table: "MedicalCheckups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 4, 19, 19, 13, 1, 55, DateTimeKind.Local).AddTicks(1185), new DateTime(2019, 4, 19, 19, 13, 1, 55, DateTimeKind.Local).AddTicks(1188), new DateTime(2021, 4, 19, 19, 13, 1, 55, DateTimeKind.Local).AddTicks(1191) });

            migrationBuilder.UpdateData(
                table: "MedicalCheckups",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 4, 19, 19, 13, 1, 55, DateTimeKind.Local).AddTicks(1195), new DateTime(2019, 7, 28, 19, 13, 1, 55, DateTimeKind.Local).AddTicks(1197), new DateTime(2021, 7, 28, 19, 13, 1, 55, DateTimeKind.Local).AddTicks(1200) });

            migrationBuilder.UpdateData(
                table: "SafetyTrainings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 2, 29, 19, 13, 1, 55, DateTimeKind.Local).AddTicks(5761), new DateTime(2020, 2, 29, 19, 13, 1, 55, DateTimeKind.Local).AddTicks(5777), new DateTime(2022, 2, 28, 19, 13, 1, 55, DateTimeKind.Local).AddTicks(5780) });

            migrationBuilder.UpdateData(
                table: "SafetyTrainings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 4, 19, 19, 13, 1, 55, DateTimeKind.Local).AddTicks(5798), new DateTime(2020, 4, 19, 19, 13, 1, 55, DateTimeKind.Local).AddTicks(5801), new DateTime(2022, 4, 19, 19, 13, 1, 55, DateTimeKind.Local).AddTicks(5803) });

            migrationBuilder.UpdateData(
                table: "SafetyTrainings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 4, 19, 19, 13, 1, 55, DateTimeKind.Local).AddTicks(5807), new DateTime(2020, 4, 19, 19, 13, 1, 55, DateTimeKind.Local).AddTicks(5809), new DateTime(2022, 4, 19, 19, 13, 1, 55, DateTimeKind.Local).AddTicks(5812) });

            migrationBuilder.UpdateData(
                table: "SafetyTrainings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 6, 8, 19, 13, 1, 55, DateTimeKind.Local).AddTicks(5815), new DateTime(2020, 6, 8, 19, 13, 1, 55, DateTimeKind.Local).AddTicks(5818), new DateTime(2021, 6, 8, 19, 13, 1, 55, DateTimeKind.Local).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "SafetyTrainings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 6, 8, 19, 13, 1, 55, DateTimeKind.Local).AddTicks(5824), new DateTime(2020, 7, 28, 19, 13, 1, 55, DateTimeKind.Local).AddTicks(5826), new DateTime(2022, 7, 28, 19, 13, 1, 55, DateTimeKind.Local).AddTicks(5829) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 12, 25, 19, 13, 1, 46, DateTimeKind.Local).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 12, 25, 19, 13, 1, 50, DateTimeKind.Local).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 12, 25, 19, 13, 1, 50, DateTimeKind.Local).AddTicks(1742));
        }
    }
}
