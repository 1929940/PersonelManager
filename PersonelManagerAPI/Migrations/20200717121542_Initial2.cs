using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Contract",
                columns: new[] { "Id", "ContractSubject", "CreatedBy", "CreatedOn", "EmployeeId", "HourlySalary", "IsRealized", "IssuedBy", "Number", "PaymentId", "TaxPercent", "Title", "ValidFrom", "ValidTo", "Value" },
                values: new object[,]
                {
                    { 19, "Montaż barierek ochronnych na jednostce NB231", "Administrator", new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 20m, true, null, "3/07/2020", null, 14.0m, "Umowa za lipiec", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(8217), 4000m },
                    { 18, "Oszlifowanie wręgów zbiorników wody pitnej P12-P32", "Administrator", new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 15m, true, null, "2/07/2020", null, 14.0m, "Umowa za lipiec", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(8199), 3000m },
                    { 17, "Przyspawanie sekcji okętowych NW23-NW24", "Administrator", new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 25m, true, null, "1/07/2020", null, 14.0m, "Umowa za lipiec", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(8181), 5000m },
                    { 16, "Montaż barierek ochronnych na jednostce NB231", "Administrator", new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 20m, true, null, "3/06/2020", null, 14.0m, "Umowa za czerwiec", new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(8162), 4000m },
                    { 15, "Oszlifowanie wręgów zbiorników wody pitnej P12-P32", "Administrator", new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 15m, true, null, "2/06/2020", null, 14.0m, "Umowa za czerwiec", new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(8143), 3000m },
                    { 14, "Przyspawanie sekcji okętowych NW23-NW24", "Administrator", new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 25m, true, null, "1/06/2020", null, 14.0m, "Umowa za czerwiec", new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(8123), 5000m },
                    { 13, "Montaż trapu na jednostce NB231", "Administrator", new DateTime(2020, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 20m, true, null, "3/05/2020", null, 14.0m, "Umowa za maj", new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(8104), 4000m },
                    { 1, "Montaż obarierowania ochronnego na jednostce NB230", "Administrator", new DateTime(2019, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 20m, true, null, "1/01/2020", null, 14.0m, "Umowa za styczeń", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(6544), 4000m },
                    { 11, "Przyspawanie haków technocznych do płatu P12", "Administrator", new DateTime(2020, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 25m, true, null, "1/05/2020", null, 14.0m, "Umowa za maj", new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(8063), 5000m },
                    { 12, "Oszlifowanie wręgów 11-201 na jednostce NB231", "Administrator", new DateTime(2020, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 15m, true, null, "2/05/2020", null, 14.0m, "Umowa za maj", new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(8084), 3000m },
                    { 3, "Oszlifowanie trapa na jednostce NB230", "Administrator", new DateTime(2020, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 15m, true, null, "2/02/2020", null, 14.0m, "Umowa za luty", new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(7909), 3000m },
                    { 2, "Przyspawanie wręgów 11-201 na jednostce WZ211", "Administrator", new DateTime(2020, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 25m, true, null, "1/02/2020", null, 14.0m, "Umowa za luty", new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(7872), 5000m },
                    { 5, "Przyspawanie wręgów 201-421 na jednostce WZ211", "Administrator", new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 25m, true, null, "1/03/2020", null, 14.0m, "Umowa za marzec", new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(7948), 5000m },
                    { 4, "Oszlifowanie zbiornika ZL15", "Administrator", new DateTime(2020, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 15m, true, null, "3/02/2020", null, 14.0m, "Umowa za luty", new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(7929), 3000m },
                    { 7, "Wypalenie otworu technicznego 23 na jednostce NB230", "Administrator", new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 20m, true, null, "3/03/2020", null, 14.0m, "Umowa za marzec", new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(7986), 4000m },
                    { 8, "Przyspawanie haków technocznych do płatu P11", "Administrator", new DateTime(2020, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 25m, true, null, "1/04/2020", null, 14.0m, "Umowa za kwiecień", new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(8005), 5000m },
                    { 9, "Oszlifowanie wręgów 11-201 na jednostce NB230", "Administrator", new DateTime(2020, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 15m, true, null, "2/04/2020", null, 14.0m, "Umowa za kwiecień", new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(8024), 3000m },
                    { 10, "Montaż trapu na jednostce NB230", "Administrator", new DateTime(2020, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 20m, true, null, "3/04/2020", null, 14.0m, "Umowa za kwiecień", new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(8044), 4000m },
                    { 6, "Oszlifowanie schodów na jednostce NB230", "Administrator", new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 15m, true, null, "2/03/2020", null, 14.0m, "Umowa za marzec", new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 16, 14, 15, 42, 54, DateTimeKind.Local).AddTicks(7967), 3000m }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.UpdateData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 9, 21, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(3102), new DateTime(2018, 7, 17, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(3119), new DateTime(2023, 7, 17, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(3123) });

            migrationBuilder.UpdateData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 12, 30, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(3141), new DateTime(2019, 12, 30, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(3144), new DateTime(2022, 12, 29, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(3147) });

            migrationBuilder.UpdateData(
                table: "Certificate",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 2, 18, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(3151), new DateTime(2016, 2, 18, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(3154), new DateTime(2020, 8, 15, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(3157) });

            migrationBuilder.UpdateData(
                table: "ConfigurationPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 7, 17, 12, 0, 26, 134, DateTimeKind.Local).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "Credential",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 7, 17, 12, 0, 26, 130, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "Credential",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 7, 17, 12, 0, 26, 133, DateTimeKind.Local).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "Credential",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2020, 7, 17, 12, 0, 26, 133, DateTimeKind.Local).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "EmployeeAddress",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 9, 21, 12, 0, 26, 137, DateTimeKind.Local).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "EmployeeAddress",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2019, 11, 10, 12, 0, 26, 137, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "EmployeeAddress",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2019, 11, 10, 12, 0, 26, 137, DateTimeKind.Local).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "EmployeeAddress",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 30, 12, 0, 26, 137, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "EmployeeAddress",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2020, 2, 18, 12, 0, 26, 137, DateTimeKind.Local).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "EmployeeAddress",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2020, 4, 8, 12, 0, 26, 137, DateTimeKind.Local).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "EmployeeHistory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 9, 21, 12, 0, 26, 137, DateTimeKind.Local).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "EmployeeHistory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2019, 11, 10, 12, 0, 26, 137, DateTimeKind.Local).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "EmployeeHistory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2019, 11, 10, 12, 0, 26, 137, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "EmployeeHistory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 30, 12, 0, 26, 137, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "EmployeeHistory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2020, 2, 18, 12, 0, 26, 137, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "EmployeeHistory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2020, 4, 8, 12, 0, 26, 137, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "Foreman",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 9, 21, 12, 0, 26, 136, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "Foreman",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2019, 11, 10, 12, 0, 26, 136, DateTimeKind.Local).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "Foreman",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2019, 12, 30, 12, 0, 26, 136, DateTimeKind.Local).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "Leave",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "From", "To" },
                values: new object[] { new DateTime(2019, 11, 10, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(9485), new DateTime(2019, 11, 26, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(9937), new DateTime(2019, 12, 10, 12, 0, 26, 141, DateTimeKind.Local).AddTicks(391) });

            migrationBuilder.UpdateData(
                table: "Leave",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "From", "To" },
                values: new object[] { new DateTime(2020, 2, 11, 12, 0, 26, 141, DateTimeKind.Local).AddTicks(1743), new DateTime(2020, 2, 18, 12, 0, 26, 141, DateTimeKind.Local).AddTicks(1763), new DateTime(2020, 4, 28, 12, 0, 26, 141, DateTimeKind.Local).AddTicks(1772) });

            migrationBuilder.UpdateData(
                table: "Leave",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "From" },
                values: new object[] { new DateTime(2020, 5, 17, 12, 0, 26, 141, DateTimeKind.Local).AddTicks(1792), new DateTime(2020, 5, 17, 12, 0, 26, 141, DateTimeKind.Local).AddTicks(1794) });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2019, 9, 21, 12, 0, 26, 135, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2019, 11, 10, 12, 0, 26, 136, DateTimeKind.Local).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "MedicalCheckup",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 9, 21, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(2792), new DateTime(2018, 8, 15, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(4367), new DateTime(2020, 8, 15, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(4856) });

            migrationBuilder.UpdateData(
                table: "MedicalCheckup",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 10, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(5289), new DateTime(2018, 8, 16, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(5327), new DateTime(2020, 8, 16, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(5341) });

            migrationBuilder.UpdateData(
                table: "MedicalCheckup",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 10, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(5350), new DateTime(2018, 11, 9, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(5354), new DateTime(2020, 11, 9, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(5357) });

            migrationBuilder.UpdateData(
                table: "MedicalCheckup",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 10, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(5361), new DateTime(2019, 2, 17, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(5363), new DateTime(2021, 2, 17, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(5366) });

            migrationBuilder.UpdateData(
                table: "Passport",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 10, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(6945), new DateTime(2010, 2, 17, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(6974), new DateTime(2020, 2, 18, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(6979) });

            migrationBuilder.UpdateData(
                table: "Passport",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 10, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(6996), new DateTime(2019, 7, 17, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(6999), new DateTime(2029, 7, 17, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(7002) });

            migrationBuilder.UpdateData(
                table: "Passport",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 2, 18, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(7006), new DateTime(2010, 8, 15, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(7009), new DateTime(2049, 7, 17, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(7012) });

            migrationBuilder.UpdateData(
                table: "Passport",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 4, 28, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(7015), new DateTime(2020, 4, 8, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(7018), new DateTime(2030, 4, 8, 12, 0, 26, 139, DateTimeKind.Local).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "Permit",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 10, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(5632), new DateTime(2019, 11, 10, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(6085), new DateTime(2020, 2, 18, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(6098) });

            migrationBuilder.UpdateData(
                table: "Permit",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 2, 18, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(6114), new DateTime(2020, 2, 18, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(6123), new DateTime(2025, 2, 17, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(6126) });

            migrationBuilder.UpdateData(
                table: "Permit",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 2, 18, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(6131), new DateTime(2019, 8, 15, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(6134), new DateTime(2020, 8, 15, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(6137) });

            migrationBuilder.UpdateData(
                table: "Permit",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 4, 8, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(6140), new DateTime(2020, 4, 8, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(6143), new DateTime(2023, 4, 8, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(6145) });

            migrationBuilder.UpdateData(
                table: "SafetyTraining",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 9, 21, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(9849), new DateTime(2019, 9, 21, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(9866), new DateTime(2021, 9, 20, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(9869) });

            migrationBuilder.UpdateData(
                table: "SafetyTraining",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 10, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(9886), new DateTime(2019, 11, 10, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(9890), new DateTime(2021, 11, 9, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(9892) });

            migrationBuilder.UpdateData(
                table: "SafetyTraining",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 10, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(9896), new DateTime(2019, 11, 10, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(9899), new DateTime(2021, 11, 9, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(9901) });

            migrationBuilder.UpdateData(
                table: "SafetyTraining",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 12, 30, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(9905), new DateTime(2019, 12, 30, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(9908), new DateTime(2020, 12, 29, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "SafetyTraining",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 12, 30, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(9913), new DateTime(2020, 2, 18, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(9916), new DateTime(2022, 2, 17, 12, 0, 26, 138, DateTimeKind.Local).AddTicks(9919) });

            migrationBuilder.UpdateData(
                table: "Visa",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2019, 11, 10, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(1497), new DateTime(2019, 2, 17, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(1527), new DateTime(2020, 2, 18, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(1532) });

            migrationBuilder.UpdateData(
                table: "Visa",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 2, 18, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(1563), new DateTime(2020, 2, 18, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(1567), new DateTime(2021, 2, 17, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(1569) });

            migrationBuilder.UpdateData(
                table: "Visa",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 2, 18, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(1573), new DateTime(2019, 8, 15, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(1576), new DateTime(2020, 8, 15, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(1579) });

            migrationBuilder.UpdateData(
                table: "Visa",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2020, 4, 28, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(1582), new DateTime(2020, 4, 8, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(1585), new DateTime(2021, 4, 8, 12, 0, 26, 140, DateTimeKind.Local).AddTicks(1587) });
        }
    }
}
