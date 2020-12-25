using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class ContractRedo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "WarningBeforePassportExpires",
                table: "ConfigurationPage");

            migrationBuilder.DropColumn(
                name: "WarningBeforePermitExpires",
                table: "ConfigurationPage");

            migrationBuilder.DropColumn(
                name: "WarningBeforeVisaExpires",
                table: "ConfigurationPage");

            migrationBuilder.AddColumn<DateTime>(
                name: "PaidOn",
                table: "Contracts",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalValue",
                table: "Contracts",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "PaidOn" },
                values: new object[] { new DateTime(2020, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "PaidOn" },
                values: new object[] { new DateTime(2020, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "PaidOn" },
                values: new object[] { new DateTime(2020, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "CreatedOn", "Number", "Title", "TotalValue", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "1/06/2020", "Umowa za czerwiec", 4000m, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 24, 19, 13, 1, 60, DateTimeKind.Local).AddTicks(8425) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "Number", "Title", "TotalValue", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "1/07/2020", "Umowa za lipiec", 5000m, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 24, 19, 13, 1, 60, DateTimeKind.Local).AddTicks(9736) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "Number", "Title", "TotalValue", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "2/07/2020", "Umowa za lipiec", 3000m, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 24, 19, 13, 1, 60, DateTimeKind.Local).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "Number", "Title", "TotalValue", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "3/07/2020", "Umowa za lipiec", 3000m, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 24, 19, 13, 1, 60, DateTimeKind.Local).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "Number", "Title", "TotalValue", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "1/08/2020", "Umowa za sierpień", 5000m, new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 24, 19, 13, 1, 60, DateTimeKind.Local).AddTicks(9818) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "Number", "Title", "TotalValue", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "2/08/2020", "Umowa za sierpień", 3000m, new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 24, 19, 13, 1, 60, DateTimeKind.Local).AddTicks(9836) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "Number", "Title", "TotalValue", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "3/08/2020", "Umowa za sierpień", 4000m, new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 24, 19, 13, 1, 60, DateTimeKind.Local).AddTicks(9898) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "Number", "Title", "TotalValue", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "1/09/2020", "Umowa za wrzesień", 5000m, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 24, 19, 13, 1, 60, DateTimeKind.Local).AddTicks(9917) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "Number", "Title", "TotalValue", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "2/09/2020", "Umowa za wrzesień", 3000m, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 24, 19, 13, 1, 60, DateTimeKind.Local).AddTicks(9936) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "Number", "Title", "TotalValue", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "3/09/2020", "Umowa za wrzesień", 4000m, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 24, 19, 13, 1, 60, DateTimeKind.Local).AddTicks(9954) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "Number", "Title", "TotalValue", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "1/10/2020", "Umowa za październik", 5000m, new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 24, 19, 13, 1, 60, DateTimeKind.Local).AddTicks(9973) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "Number", "Title", "TotalValue", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "2/10/2020", "Umowa za październik", 3000m, new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 24, 19, 13, 1, 60, DateTimeKind.Local).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "Number", "Title", "TotalValue", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "3/10/2020", "Umowa za październik", 4000m, new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 24, 19, 13, 1, 61, DateTimeKind.Local).AddTicks(11) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "Number", "Title", "TotalValue", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "1/11/2020", "Umowa za listopad", 5000m, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 24, 19, 13, 1, 61, DateTimeKind.Local).AddTicks(29) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "Number", "Title", "TotalValue", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "2/11/2020", "Umowa za listopad", 3000m, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 24, 19, 13, 1, 61, DateTimeKind.Local).AddTicks(48) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "Number", "Title", "TotalValue", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "3/11/2020", "Umowa za listopad", 4000m, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 24, 19, 13, 1, 61, DateTimeKind.Local).AddTicks(66) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "Number", "Title", "TotalValue", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "1/12/2020", "Umowa za grudzień", 5000m, new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 24, 19, 13, 1, 61, DateTimeKind.Local).AddTicks(83) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "Number", "Title", "TotalValue", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "2/12/2020", "Umowa za grudzień", 3000m, new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 24, 19, 13, 1, 61, DateTimeKind.Local).AddTicks(102) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "Number", "Title", "TotalValue", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "3/12/2020", "Umowa za grudzień", 4000m, new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 24, 19, 13, 1, 61, DateTimeKind.Local).AddTicks(119) });

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
                columns: new[] { "CreatedOn", "Hash" },
                values: new object[] { new DateTime(2020, 12, 25, 19, 13, 1, 46, DateTimeKind.Local).AddTicks(8926), "1111" });

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Hash",
                value: "QWER");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaidOn",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "TotalValue",
                table: "Contracts");

            migrationBuilder.AddColumn<decimal>(
                name: "Value",
                table: "Contracts",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "WarningBeforePassportExpires",
                table: "ConfigurationPage",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WarningBeforePermitExpires",
                table: "ConfigurationPage",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WarningBeforeVisaExpires",
                table: "ConfigurationPage",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GrossAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaidOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
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

            migrationBuilder.UpdateData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "PaidOn" },
                values: new object[] { new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "PaidOn" },
                values: new object[] { new DateTime(2020, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "PaidOn" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "CreatedOn", "WarningBeforePassportExpires", "WarningBeforePermitExpires", "WarningBeforeVisaExpires" },
                values: new object[] { new DateTime(2020, 7, 25, 14, 39, 19, 441, DateTimeKind.Local).AddTicks(5833), 30, 30, 30 });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Number", "Title", "ValidFrom", "ValidTo", "Value" },
                values: new object[] { new DateTime(2019, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "1/01/2020", "Umowa za styczeń", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(3381), 4000m });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "Number", "Title", "ValidFrom", "ValidTo", "Value" },
                values: new object[] { new DateTime(2020, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "1/02/2020", "Umowa za luty", new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(4815), 5000m });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "Number", "Title", "ValidFrom", "ValidTo", "Value" },
                values: new object[] { new DateTime(2020, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "2/02/2020", "Umowa za luty", new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(4855), 3000m });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "Number", "Title", "ValidFrom", "ValidTo", "Value" },
                values: new object[] { new DateTime(2020, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "3/02/2020", "Umowa za luty", new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(4876), 3000m });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "Number", "Title", "ValidFrom", "ValidTo", "Value" },
                values: new object[] { new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "1/03/2020", "Umowa za marzec", new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(4896), 5000m });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "Number", "Title", "ValidFrom", "ValidTo", "Value" },
                values: new object[] { new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "2/03/2020", "Umowa za marzec", new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(4916), 3000m });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "Number", "Title", "ValidFrom", "ValidTo", "Value" },
                values: new object[] { new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "3/03/2020", "Umowa za marzec", new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(4936), 4000m });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "Number", "Title", "ValidFrom", "ValidTo", "Value" },
                values: new object[] { new DateTime(2020, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "1/04/2020", "Umowa za kwiecień", new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(4955), 5000m });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "Number", "Title", "ValidFrom", "ValidTo", "Value" },
                values: new object[] { new DateTime(2020, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "2/04/2020", "Umowa za kwiecień", new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(4975), 3000m });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "Number", "Title", "ValidFrom", "ValidTo", "Value" },
                values: new object[] { new DateTime(2020, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "3/04/2020", "Umowa za kwiecień", new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(4995), 4000m });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "Number", "Title", "ValidFrom", "ValidTo", "Value" },
                values: new object[] { new DateTime(2020, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "1/05/2020", "Umowa za maj", new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(5015), 5000m });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "Number", "Title", "ValidFrom", "ValidTo", "Value" },
                values: new object[] { new DateTime(2020, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "2/05/2020", "Umowa za maj", new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(5035), 3000m });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "Number", "Title", "ValidFrom", "ValidTo", "Value" },
                values: new object[] { new DateTime(2020, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "3/05/2020", "Umowa za maj", new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(5055), 4000m });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "Number", "Title", "ValidFrom", "ValidTo", "Value" },
                values: new object[] { new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "1/06/2020", "Umowa za czerwiec", new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(5075), 5000m });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "Number", "Title", "ValidFrom", "ValidTo", "Value" },
                values: new object[] { new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "2/06/2020", "Umowa za czerwiec", new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(5095), 3000m });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "Number", "Title", "ValidFrom", "ValidTo", "Value" },
                values: new object[] { new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "3/06/2020", "Umowa za czerwiec", new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(5115), 4000m });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "Number", "Title", "ValidFrom", "ValidTo", "Value" },
                values: new object[] { new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "1/07/2020", "Umowa za lipiec", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(5134), 5000m });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "Number", "Title", "ValidFrom", "ValidTo", "Value" },
                values: new object[] { new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "2/07/2020", "Umowa za lipiec", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(5152), 3000m });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "Number", "Title", "ValidFrom", "ValidTo", "Value" },
                values: new object[] { new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "3/07/2020", "Umowa za lipiec", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 24, 14, 39, 19, 451, DateTimeKind.Local).AddTicks(5170), 4000m });

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

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "Id", "ContractId", "CreatedBy", "CreatedOn", "GrossAmount", "NetAmount", "PaidOn", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 2, 12, "Initial", new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3000m, 2580.00m, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 3, 13, "Initial", new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4000m, 3440.00m, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 4, 14, "Initial", new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5000m, 4300.00m, new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 5, 15, "Initial", new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3000m, 2580.00m, new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 6, 16, "Initial", new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4000m, 3440.00m, new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 1, 11, "Initial", new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5000m, 4300.00m, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null }
                });

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
                columns: new[] { "CreatedOn", "Hash" },
                values: new object[] { new DateTime(2020, 7, 25, 14, 39, 19, 437, DateTimeKind.Local).AddTicks(1053), "WWW" });

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Hash",
                value: "WSX_09");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_ContractId",
                table: "Payment",
                column: "ContractId",
                unique: true);
        }
    }
}
