using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaidAmount",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "TaxAmount",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "Payment");

            migrationBuilder.AddColumn<decimal>(
                name: "GrossAmount",
                table: "Payment",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "NetAmount",
                table: "Payment",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaidOn",
                table: "Advances",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Advances",
                columns: new[] { "Id", "Amount", "ContractId", "CreatedBy", "CreatedOn", "PaidOn", "WorkedHours" },
                values: new object[,]
                {
                    { 1, 1100m, 14, "Administrator", new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 70 },
                    { 2, 900m, 15, "Administrator", new DateTime(2020, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 80 },
                    { 3, 1000m, 16, "Administrator", new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 86 },
                    { 4, 2000m, 17, "Administrator", new DateTime(2020, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), null, 10 },
                    { 5, 2500m, 18, "Administrator", new DateTime(2020, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), null, 10 },
                    { 6, 500m, 19, "Administrator", new DateTime(2020, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), 16 }
                });

            migrationBuilder.UpdateData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 9, 21, 14, 44, 33, 444, DateTimeKind.Local).AddTicks(6731), new DateTime(2018, 7, 17, 14, 44, 33, 444, DateTimeKind.Local).AddTicks(6747), new DateTime(2023, 7, 17, 14, 44, 33, 444, DateTimeKind.Local).AddTicks(6752) });

            migrationBuilder.UpdateData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 12, 30, 14, 44, 33, 444, DateTimeKind.Local).AddTicks(6768), new DateTime(2019, 12, 30, 14, 44, 33, 444, DateTimeKind.Local).AddTicks(6771), new DateTime(2022, 12, 29, 14, 44, 33, 444, DateTimeKind.Local).AddTicks(6774) });

            migrationBuilder.UpdateData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 2, 18, 14, 44, 33, 444, DateTimeKind.Local).AddTicks(6777), new DateTime(2016, 2, 18, 14, 44, 33, 444, DateTimeKind.Local).AddTicks(6780), new DateTime(2020, 8, 15, 14, 44, 33, 444, DateTimeKind.Local).AddTicks(6782) });

            migrationBuilder.UpdateData(
                table: "ConfigurationPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 7, 17, 14, 44, 33, 439, DateTimeKind.Local).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 1,
                column: "ValidTo",
                value: new DateTime(2020, 2, 16, 14, 44, 33, 450, DateTimeKind.Local).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 2,
                column: "ValidTo",
                value: new DateTime(2020, 3, 16, 14, 44, 33, 451, DateTimeKind.Local).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 3,
                column: "ValidTo",
                value: new DateTime(2020, 3, 16, 14, 44, 33, 451, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 4,
                column: "ValidTo",
                value: new DateTime(2020, 3, 16, 14, 44, 33, 451, DateTimeKind.Local).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 5,
                column: "ValidTo",
                value: new DateTime(2020, 4, 16, 14, 44, 33, 451, DateTimeKind.Local).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 6,
                column: "ValidTo",
                value: new DateTime(2020, 4, 16, 14, 44, 33, 451, DateTimeKind.Local).AddTicks(1363));

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 7,
                column: "ValidTo",
                value: new DateTime(2020, 4, 16, 14, 44, 33, 451, DateTimeKind.Local).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 8,
                column: "ValidTo",
                value: new DateTime(2020, 5, 16, 14, 44, 33, 451, DateTimeKind.Local).AddTicks(1401));

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 9,
                column: "ValidTo",
                value: new DateTime(2020, 5, 16, 14, 44, 33, 451, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 10,
                column: "ValidTo",
                value: new DateTime(2020, 5, 16, 14, 44, 33, 451, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 11,
                column: "ValidTo",
                value: new DateTime(2020, 6, 16, 14, 44, 33, 451, DateTimeKind.Local).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 12,
                column: "ValidTo",
                value: new DateTime(2020, 6, 16, 14, 44, 33, 451, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 13,
                column: "ValidTo",
                value: new DateTime(2020, 6, 16, 14, 44, 33, 451, DateTimeKind.Local).AddTicks(1546));

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 14,
                column: "ValidTo",
                value: new DateTime(2020, 7, 16, 14, 44, 33, 451, DateTimeKind.Local).AddTicks(1566));

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 15,
                column: "ValidTo",
                value: new DateTime(2020, 7, 16, 14, 44, 33, 451, DateTimeKind.Local).AddTicks(1585));

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 16,
                column: "ValidTo",
                value: new DateTime(2020, 7, 16, 14, 44, 33, 451, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsRealized", "ValidTo" },
                values: new object[] { false, new DateTime(2020, 8, 16, 14, 44, 33, 451, DateTimeKind.Local).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsRealized", "ValidTo" },
                values: new object[] { false, new DateTime(2020, 8, 16, 14, 44, 33, 451, DateTimeKind.Local).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsRealized", "ValidTo" },
                values: new object[] { false, new DateTime(2020, 8, 16, 14, 44, 33, 451, DateTimeKind.Local).AddTicks(1658) });

            migrationBuilder.UpdateData(
                table: "Credential",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 7, 17, 14, 44, 33, 435, DateTimeKind.Local).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "Credential",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 7, 17, 14, 44, 33, 438, DateTimeKind.Local).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "Credential",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 7, 17, 14, 44, 33, 438, DateTimeKind.Local).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "EmployeeAddress",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 9, 21, 14, 44, 33, 442, DateTimeKind.Local).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "EmployeeAddress",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2019, 11, 10, 14, 44, 33, 442, DateTimeKind.Local).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "EmployeeAddress",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2019, 11, 10, 14, 44, 33, 442, DateTimeKind.Local).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "EmployeeAddress",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 30, 14, 44, 33, 442, DateTimeKind.Local).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "EmployeeAddress",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2020, 2, 18, 14, 44, 33, 442, DateTimeKind.Local).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "EmployeeAddress",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2020, 4, 8, 14, 44, 33, 442, DateTimeKind.Local).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "EmployeeHistory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 9, 21, 14, 44, 33, 442, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "EmployeeHistory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2019, 11, 10, 14, 44, 33, 443, DateTimeKind.Local).AddTicks(368));

            migrationBuilder.UpdateData(
                table: "EmployeeHistory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2019, 11, 10, 14, 44, 33, 443, DateTimeKind.Local).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "EmployeeHistory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 30, 14, 44, 33, 443, DateTimeKind.Local).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "EmployeeHistory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2020, 2, 18, 14, 44, 33, 443, DateTimeKind.Local).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "EmployeeHistory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2020, 4, 8, 14, 44, 33, 443, DateTimeKind.Local).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "Foreman",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 9, 21, 14, 44, 33, 441, DateTimeKind.Local).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "Foreman",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2019, 11, 10, 14, 44, 33, 441, DateTimeKind.Local).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "Foreman",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 30, 14, 44, 33, 441, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "Leave",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "From", "To" },
                values: new object[] { new DateTime(2019, 11, 10, 14, 44, 33, 446, DateTimeKind.Local).AddTicks(3457), new DateTime(2019, 11, 26, 14, 44, 33, 446, DateTimeKind.Local).AddTicks(3930), new DateTime(2019, 12, 10, 14, 44, 33, 446, DateTimeKind.Local).AddTicks(4458) });

            migrationBuilder.UpdateData(
                table: "Leave",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "From", "To" },
                values: new object[] { new DateTime(2020, 2, 11, 14, 44, 33, 446, DateTimeKind.Local).AddTicks(5889), new DateTime(2020, 2, 18, 14, 44, 33, 446, DateTimeKind.Local).AddTicks(5907), new DateTime(2020, 4, 28, 14, 44, 33, 446, DateTimeKind.Local).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "Leave",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "From" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 44, 33, 446, DateTimeKind.Local).AddTicks(5936), new DateTime(2020, 5, 17, 14, 44, 33, 446, DateTimeKind.Local).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 9, 21, 14, 44, 33, 441, DateTimeKind.Local).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2019, 11, 10, 14, 44, 33, 441, DateTimeKind.Local).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "MedicalCheckup",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 9, 21, 14, 44, 33, 443, DateTimeKind.Local).AddTicks(5093), new DateTime(2018, 8, 15, 14, 44, 33, 443, DateTimeKind.Local).AddTicks(6766), new DateTime(2020, 8, 15, 14, 44, 33, 443, DateTimeKind.Local).AddTicks(7271) });

            migrationBuilder.UpdateData(
                table: "MedicalCheckup",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 10, 14, 44, 33, 443, DateTimeKind.Local).AddTicks(7722), new DateTime(2018, 8, 16, 14, 44, 33, 443, DateTimeKind.Local).AddTicks(7759), new DateTime(2020, 8, 16, 14, 44, 33, 443, DateTimeKind.Local).AddTicks(7773) });

            migrationBuilder.UpdateData(
                table: "MedicalCheckup",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 10, 14, 44, 33, 443, DateTimeKind.Local).AddTicks(7782), new DateTime(2018, 11, 9, 14, 44, 33, 443, DateTimeKind.Local).AddTicks(7785), new DateTime(2020, 11, 9, 14, 44, 33, 443, DateTimeKind.Local).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "MedicalCheckup",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 10, 14, 44, 33, 443, DateTimeKind.Local).AddTicks(7792), new DateTime(2019, 2, 17, 14, 44, 33, 443, DateTimeKind.Local).AddTicks(7795), new DateTime(2021, 2, 17, 14, 44, 33, 443, DateTimeKind.Local).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "Passport",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 10, 14, 44, 33, 445, DateTimeKind.Local).AddTicks(724), new DateTime(2010, 2, 17, 14, 44, 33, 445, DateTimeKind.Local).AddTicks(739), new DateTime(2020, 2, 18, 14, 44, 33, 445, DateTimeKind.Local).AddTicks(744) });

            migrationBuilder.UpdateData(
                table: "Passport",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 10, 14, 44, 33, 445, DateTimeKind.Local).AddTicks(762), new DateTime(2019, 7, 17, 14, 44, 33, 445, DateTimeKind.Local).AddTicks(765), new DateTime(2029, 7, 17, 14, 44, 33, 445, DateTimeKind.Local).AddTicks(768) });

            migrationBuilder.UpdateData(
                table: "Passport",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 2, 18, 14, 44, 33, 445, DateTimeKind.Local).AddTicks(772), new DateTime(2010, 8, 15, 14, 44, 33, 445, DateTimeKind.Local).AddTicks(775), new DateTime(2049, 7, 17, 14, 44, 33, 445, DateTimeKind.Local).AddTicks(777) });

            migrationBuilder.UpdateData(
                table: "Passport",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 4, 28, 14, 44, 33, 445, DateTimeKind.Local).AddTicks(780), new DateTime(2020, 4, 8, 14, 44, 33, 445, DateTimeKind.Local).AddTicks(783), new DateTime(2030, 4, 8, 14, 44, 33, 445, DateTimeKind.Local).AddTicks(786) });

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "Id", "ContractId", "CreatedBy", "CreatedOn", "GrossAmount", "NetAmount", "PaidOn" },
                values: new object[,]
                {
                    { 1, 11, "Administrator", new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5000m, 4300.00m, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 15, "Administrator", new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3000m, 2580.00m, new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 16, "Administrator", new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4000m, 3440.00m, new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 14, "Administrator", new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5000m, 4300.00m, new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 13, "Administrator", new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4000m, 3440.00m, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 12, "Administrator", new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3000m, 2580.00m, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "Permit",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 10, 14, 44, 33, 445, DateTimeKind.Local).AddTicks(9484), new DateTime(2019, 11, 10, 14, 44, 33, 445, DateTimeKind.Local).AddTicks(9956), new DateTime(2020, 2, 18, 14, 44, 33, 445, DateTimeKind.Local).AddTicks(9969) });

            migrationBuilder.UpdateData(
                table: "Permit",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 2, 18, 14, 44, 33, 445, DateTimeKind.Local).AddTicks(9986), new DateTime(2020, 2, 18, 14, 44, 33, 445, DateTimeKind.Local).AddTicks(9995), new DateTime(2025, 2, 17, 14, 44, 33, 445, DateTimeKind.Local).AddTicks(9997) });

            migrationBuilder.UpdateData(
                table: "Permit",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 2, 18, 14, 44, 33, 446, DateTimeKind.Local).AddTicks(2), new DateTime(2019, 8, 15, 14, 44, 33, 446, DateTimeKind.Local).AddTicks(5), new DateTime(2020, 8, 15, 14, 44, 33, 446, DateTimeKind.Local).AddTicks(8) });

            migrationBuilder.UpdateData(
                table: "Permit",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 4, 8, 14, 44, 33, 446, DateTimeKind.Local).AddTicks(11), new DateTime(2020, 4, 8, 14, 44, 33, 446, DateTimeKind.Local).AddTicks(14), new DateTime(2023, 4, 8, 14, 44, 33, 446, DateTimeKind.Local).AddTicks(16) });

            migrationBuilder.UpdateData(
                table: "SafetyTraining",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 9, 21, 14, 44, 33, 444, DateTimeKind.Local).AddTicks(2286), new DateTime(2019, 9, 21, 14, 44, 33, 444, DateTimeKind.Local).AddTicks(2302), new DateTime(2021, 9, 20, 14, 44, 33, 444, DateTimeKind.Local).AddTicks(2305) });

            migrationBuilder.UpdateData(
                table: "SafetyTraining",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 10, 14, 44, 33, 444, DateTimeKind.Local).AddTicks(2323), new DateTime(2019, 11, 10, 14, 44, 33, 444, DateTimeKind.Local).AddTicks(2327), new DateTime(2021, 11, 9, 14, 44, 33, 444, DateTimeKind.Local).AddTicks(2329) });

            migrationBuilder.UpdateData(
                table: "SafetyTraining",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 10, 14, 44, 33, 444, DateTimeKind.Local).AddTicks(2333), new DateTime(2019, 11, 10, 14, 44, 33, 444, DateTimeKind.Local).AddTicks(2336), new DateTime(2021, 11, 9, 14, 44, 33, 444, DateTimeKind.Local).AddTicks(2338) });

            migrationBuilder.UpdateData(
                table: "SafetyTraining",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 12, 30, 14, 44, 33, 444, DateTimeKind.Local).AddTicks(2341), new DateTime(2019, 12, 30, 14, 44, 33, 444, DateTimeKind.Local).AddTicks(2344), new DateTime(2020, 12, 29, 14, 44, 33, 444, DateTimeKind.Local).AddTicks(2346) });

            migrationBuilder.UpdateData(
                table: "SafetyTraining",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 12, 30, 14, 44, 33, 444, DateTimeKind.Local).AddTicks(2349), new DateTime(2020, 2, 18, 14, 44, 33, 444, DateTimeKind.Local).AddTicks(2352), new DateTime(2022, 2, 17, 14, 44, 33, 444, DateTimeKind.Local).AddTicks(2354) });

            migrationBuilder.UpdateData(
                table: "Visa",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 10, 14, 44, 33, 445, DateTimeKind.Local).AddTicks(5346), new DateTime(2019, 2, 17, 14, 44, 33, 445, DateTimeKind.Local).AddTicks(5375), new DateTime(2020, 2, 18, 14, 44, 33, 445, DateTimeKind.Local).AddTicks(5380) });

            migrationBuilder.UpdateData(
                table: "Visa",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 2, 18, 14, 44, 33, 445, DateTimeKind.Local).AddTicks(5409), new DateTime(2020, 2, 18, 14, 44, 33, 445, DateTimeKind.Local).AddTicks(5412), new DateTime(2021, 2, 17, 14, 44, 33, 445, DateTimeKind.Local).AddTicks(5415) });

            migrationBuilder.UpdateData(
                table: "Visa",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 2, 18, 14, 44, 33, 445, DateTimeKind.Local).AddTicks(5418), new DateTime(2019, 8, 15, 14, 44, 33, 445, DateTimeKind.Local).AddTicks(5421), new DateTime(2020, 8, 15, 14, 44, 33, 445, DateTimeKind.Local).AddTicks(5424) });

            migrationBuilder.UpdateData(
                table: "Visa",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 4, 28, 14, 44, 33, 445, DateTimeKind.Local).AddTicks(5427), new DateTime(2020, 4, 8, 14, 44, 33, 445, DateTimeKind.Local).AddTicks(5430), new DateTime(2021, 4, 8, 14, 44, 33, 445, DateTimeKind.Local).AddTicks(5433) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "GrossAmount",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "NetAmount",
                table: "Payment");

            migrationBuilder.AddColumn<decimal>(
                name: "PaidAmount",
                table: "Payment",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TaxAmount",
                table: "Payment",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalAmount",
                table: "Payment",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaidOn",
                table: "Advances",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 9, 21, 14, 15, 42, 48, DateTimeKind.Local).AddTicks(2879), new DateTime(2018, 7, 17, 14, 15, 42, 48, DateTimeKind.Local).AddTicks(2896), new DateTime(2023, 7, 17, 14, 15, 42, 48, DateTimeKind.Local).AddTicks(2901) });

            migrationBuilder.UpdateData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 12, 30, 14, 15, 42, 48, DateTimeKind.Local).AddTicks(2918), new DateTime(2019, 12, 30, 14, 15, 42, 48, DateTimeKind.Local).AddTicks(2921), new DateTime(2022, 12, 29, 14, 15, 42, 48, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 2, 18, 14, 15, 42, 48, DateTimeKind.Local).AddTicks(2928), new DateTime(2016, 2, 18, 14, 15, 42, 48, DateTimeKind.Local).AddTicks(2931), new DateTime(2020, 8, 15, 14, 15, 42, 48, DateTimeKind.Local).AddTicks(2934) });

            migrationBuilder.UpdateData(
                table: "ConfigurationPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 7, 17, 14, 15, 42, 43, DateTimeKind.Local).AddTicks(3052));

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 1,
                column: "ValidTo",
                value: new DateTime(2020, 2, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 2,
                column: "ValidTo",
                value: new DateTime(2020, 3, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(7872));

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 3,
                column: "ValidTo",
                value: new DateTime(2020, 3, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 4,
                column: "ValidTo",
                value: new DateTime(2020, 3, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 5,
                column: "ValidTo",
                value: new DateTime(2020, 4, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 6,
                column: "ValidTo",
                value: new DateTime(2020, 4, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 7,
                column: "ValidTo",
                value: new DateTime(2020, 4, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 8,
                column: "ValidTo",
                value: new DateTime(2020, 5, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 9,
                column: "ValidTo",
                value: new DateTime(2020, 5, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 10,
                column: "ValidTo",
                value: new DateTime(2020, 5, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 11,
                column: "ValidTo",
                value: new DateTime(2020, 6, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 12,
                column: "ValidTo",
                value: new DateTime(2020, 6, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 13,
                column: "ValidTo",
                value: new DateTime(2020, 6, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 14,
                column: "ValidTo",
                value: new DateTime(2020, 7, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 15,
                column: "ValidTo",
                value: new DateTime(2020, 7, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 16,
                column: "ValidTo",
                value: new DateTime(2020, 7, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsRealized", "ValidTo" },
                values: new object[] { true, new DateTime(2020, 8, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(8181) });

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsRealized", "ValidTo" },
                values: new object[] { true, new DateTime(2020, 8, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(8199) });

            migrationBuilder.UpdateData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsRealized", "ValidTo" },
                values: new object[] { true, new DateTime(2020, 8, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(8217) });

            migrationBuilder.UpdateData(
                table: "Credential",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 7, 17, 14, 15, 42, 39, DateTimeKind.Local).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "Credential",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 7, 17, 14, 15, 42, 42, DateTimeKind.Local).AddTicks(224));

            migrationBuilder.UpdateData(
                table: "Credential",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 7, 17, 14, 15, 42, 42, DateTimeKind.Local).AddTicks(289));

            migrationBuilder.UpdateData(
                table: "EmployeeAddress",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 9, 21, 14, 15, 42, 45, DateTimeKind.Local).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "EmployeeAddress",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2019, 11, 10, 14, 15, 42, 45, DateTimeKind.Local).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "EmployeeAddress",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2019, 11, 10, 14, 15, 42, 45, DateTimeKind.Local).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "EmployeeAddress",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 30, 14, 15, 42, 45, DateTimeKind.Local).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "EmployeeAddress",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2020, 2, 18, 14, 15, 42, 45, DateTimeKind.Local).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "EmployeeAddress",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2020, 4, 8, 14, 15, 42, 45, DateTimeKind.Local).AddTicks(9701));

            migrationBuilder.UpdateData(
                table: "EmployeeHistory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 9, 21, 14, 15, 42, 46, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "EmployeeHistory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2019, 11, 10, 14, 15, 42, 46, DateTimeKind.Local).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "EmployeeHistory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2019, 11, 10, 14, 15, 42, 46, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "EmployeeHistory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 30, 14, 15, 42, 46, DateTimeKind.Local).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "EmployeeHistory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2020, 2, 18, 14, 15, 42, 46, DateTimeKind.Local).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "EmployeeHistory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2020, 4, 8, 14, 15, 42, 46, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "Foreman",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 9, 21, 14, 15, 42, 45, DateTimeKind.Local).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "Foreman",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2019, 11, 10, 14, 15, 42, 45, DateTimeKind.Local).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "Foreman",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 30, 14, 15, 42, 45, DateTimeKind.Local).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "Leave",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "From", "To" },
                values: new object[] { new DateTime(2019, 11, 10, 14, 15, 42, 49, DateTimeKind.Local).AddTicks(9747), new DateTime(2019, 11, 26, 14, 15, 42, 50, DateTimeKind.Local).AddTicks(230), new DateTime(2019, 12, 10, 14, 15, 42, 50, DateTimeKind.Local).AddTicks(709) });

            migrationBuilder.UpdateData(
                table: "Leave",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "From", "To" },
                values: new object[] { new DateTime(2020, 2, 11, 14, 15, 42, 50, DateTimeKind.Local).AddTicks(2183), new DateTime(2020, 2, 18, 14, 15, 42, 50, DateTimeKind.Local).AddTicks(2201), new DateTime(2020, 4, 28, 14, 15, 42, 50, DateTimeKind.Local).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "Leave",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "From" },
                values: new object[] { new DateTime(2020, 5, 17, 14, 15, 42, 50, DateTimeKind.Local).AddTicks(2230), new DateTime(2020, 5, 17, 14, 15, 42, 50, DateTimeKind.Local).AddTicks(2233) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 9, 21, 14, 15, 42, 44, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2019, 11, 10, 14, 15, 42, 45, DateTimeKind.Local).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "MedicalCheckup",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 9, 21, 14, 15, 42, 47, DateTimeKind.Local).AddTicks(2081), new DateTime(2018, 8, 15, 14, 15, 42, 47, DateTimeKind.Local).AddTicks(3766), new DateTime(2020, 8, 15, 14, 15, 42, 47, DateTimeKind.Local).AddTicks(4279) });

            migrationBuilder.UpdateData(
                table: "MedicalCheckup",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 10, 14, 15, 42, 47, DateTimeKind.Local).AddTicks(4731), new DateTime(2018, 8, 16, 14, 15, 42, 47, DateTimeKind.Local).AddTicks(4768), new DateTime(2020, 8, 16, 14, 15, 42, 47, DateTimeKind.Local).AddTicks(4783) });

            migrationBuilder.UpdateData(
                table: "MedicalCheckup",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 10, 14, 15, 42, 47, DateTimeKind.Local).AddTicks(4792), new DateTime(2018, 11, 9, 14, 15, 42, 47, DateTimeKind.Local).AddTicks(4795), new DateTime(2020, 11, 9, 14, 15, 42, 47, DateTimeKind.Local).AddTicks(4799) });

            migrationBuilder.UpdateData(
                table: "MedicalCheckup",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 10, 14, 15, 42, 47, DateTimeKind.Local).AddTicks(4802), new DateTime(2019, 2, 17, 14, 15, 42, 47, DateTimeKind.Local).AddTicks(4805), new DateTime(2021, 2, 17, 14, 15, 42, 47, DateTimeKind.Local).AddTicks(4808) });

            migrationBuilder.UpdateData(
                table: "Passport",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 10, 14, 15, 42, 48, DateTimeKind.Local).AddTicks(6935), new DateTime(2010, 2, 17, 14, 15, 42, 48, DateTimeKind.Local).AddTicks(6952), new DateTime(2020, 2, 18, 14, 15, 42, 48, DateTimeKind.Local).AddTicks(6957) });

            migrationBuilder.UpdateData(
                table: "Passport",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 10, 14, 15, 42, 48, DateTimeKind.Local).AddTicks(6975), new DateTime(2019, 7, 17, 14, 15, 42, 48, DateTimeKind.Local).AddTicks(6978), new DateTime(2029, 7, 17, 14, 15, 42, 48, DateTimeKind.Local).AddTicks(6981) });

            migrationBuilder.UpdateData(
                table: "Passport",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 2, 18, 14, 15, 42, 48, DateTimeKind.Local).AddTicks(6985), new DateTime(2010, 8, 15, 14, 15, 42, 48, DateTimeKind.Local).AddTicks(6988), new DateTime(2049, 7, 17, 14, 15, 42, 48, DateTimeKind.Local).AddTicks(6991) });

            migrationBuilder.UpdateData(
                table: "Passport",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 4, 28, 14, 15, 42, 48, DateTimeKind.Local).AddTicks(6994), new DateTime(2020, 4, 8, 14, 15, 42, 48, DateTimeKind.Local).AddTicks(6997), new DateTime(2030, 4, 8, 14, 15, 42, 48, DateTimeKind.Local).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "Permit",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 10, 14, 15, 42, 49, DateTimeKind.Local).AddTicks(5789), new DateTime(2019, 11, 10, 14, 15, 42, 49, DateTimeKind.Local).AddTicks(6268), new DateTime(2020, 2, 18, 14, 15, 42, 49, DateTimeKind.Local).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "Permit",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 2, 18, 14, 15, 42, 49, DateTimeKind.Local).AddTicks(6298), new DateTime(2020, 2, 18, 14, 15, 42, 49, DateTimeKind.Local).AddTicks(6308), new DateTime(2025, 2, 17, 14, 15, 42, 49, DateTimeKind.Local).AddTicks(6311) });

            migrationBuilder.UpdateData(
                table: "Permit",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 2, 18, 14, 15, 42, 49, DateTimeKind.Local).AddTicks(6316), new DateTime(2019, 8, 15, 14, 15, 42, 49, DateTimeKind.Local).AddTicks(6319), new DateTime(2020, 8, 15, 14, 15, 42, 49, DateTimeKind.Local).AddTicks(6322) });

            migrationBuilder.UpdateData(
                table: "Permit",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 4, 8, 14, 15, 42, 49, DateTimeKind.Local).AddTicks(6325), new DateTime(2020, 4, 8, 14, 15, 42, 49, DateTimeKind.Local).AddTicks(6327), new DateTime(2023, 4, 8, 14, 15, 42, 49, DateTimeKind.Local).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "SafetyTraining",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 9, 21, 14, 15, 42, 47, DateTimeKind.Local).AddTicks(9455), new DateTime(2019, 9, 21, 14, 15, 42, 47, DateTimeKind.Local).AddTicks(9471), new DateTime(2021, 9, 20, 14, 15, 42, 47, DateTimeKind.Local).AddTicks(9474) });

            migrationBuilder.UpdateData(
                table: "SafetyTraining",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 10, 14, 15, 42, 47, DateTimeKind.Local).AddTicks(9494), new DateTime(2019, 11, 10, 14, 15, 42, 47, DateTimeKind.Local).AddTicks(9497), new DateTime(2021, 11, 9, 14, 15, 42, 47, DateTimeKind.Local).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "SafetyTraining",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 10, 14, 15, 42, 47, DateTimeKind.Local).AddTicks(9503), new DateTime(2019, 11, 10, 14, 15, 42, 47, DateTimeKind.Local).AddTicks(9507), new DateTime(2021, 11, 9, 14, 15, 42, 47, DateTimeKind.Local).AddTicks(9509) });

            migrationBuilder.UpdateData(
                table: "SafetyTraining",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 12, 30, 14, 15, 42, 47, DateTimeKind.Local).AddTicks(9512), new DateTime(2019, 12, 30, 14, 15, 42, 47, DateTimeKind.Local).AddTicks(9515), new DateTime(2020, 12, 29, 14, 15, 42, 47, DateTimeKind.Local).AddTicks(9517) });

            migrationBuilder.UpdateData(
                table: "SafetyTraining",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 12, 30, 14, 15, 42, 47, DateTimeKind.Local).AddTicks(9562), new DateTime(2020, 2, 18, 14, 15, 42, 47, DateTimeKind.Local).AddTicks(9565), new DateTime(2022, 2, 17, 14, 15, 42, 47, DateTimeKind.Local).AddTicks(9568) });

            migrationBuilder.UpdateData(
                table: "Visa",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 10, 14, 15, 42, 49, DateTimeKind.Local).AddTicks(1596), new DateTime(2019, 2, 17, 14, 15, 42, 49, DateTimeKind.Local).AddTicks(1626), new DateTime(2020, 2, 18, 14, 15, 42, 49, DateTimeKind.Local).AddTicks(1631) });

            migrationBuilder.UpdateData(
                table: "Visa",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 2, 18, 14, 15, 42, 49, DateTimeKind.Local).AddTicks(1667), new DateTime(2020, 2, 18, 14, 15, 42, 49, DateTimeKind.Local).AddTicks(1670), new DateTime(2021, 2, 17, 14, 15, 42, 49, DateTimeKind.Local).AddTicks(1673) });

            migrationBuilder.UpdateData(
                table: "Visa",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 2, 18, 14, 15, 42, 49, DateTimeKind.Local).AddTicks(1677), new DateTime(2019, 8, 15, 14, 15, 42, 49, DateTimeKind.Local).AddTicks(1680), new DateTime(2020, 8, 15, 14, 15, 42, 49, DateTimeKind.Local).AddTicks(1683) });

            migrationBuilder.UpdateData(
                table: "Visa",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 4, 28, 14, 15, 42, 49, DateTimeKind.Local).AddTicks(1686), new DateTime(2020, 4, 8, 14, 15, 42, 49, DateTimeKind.Local).AddTicks(1689), new DateTime(2021, 4, 8, 14, 15, 42, 49, DateTimeKind.Local).AddTicks(1692) });
        }
    }
}
