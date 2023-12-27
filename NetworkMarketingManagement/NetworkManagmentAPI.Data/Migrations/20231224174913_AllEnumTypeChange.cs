using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetworkManagmentAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class AllEnumTypeChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DocumentType",
                table: "PersonalIdentifiers",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Distributors",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ContactType",
                table: "ContactInfos",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ContactType",
                value: "Telephone");

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ContactType",
                value: "Email");

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 3,
                column: "ContactType",
                value: "Email");

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 4,
                column: "ContactType",
                value: "Mobile");

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 5,
                column: "ContactType",
                value: "Mobile");

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 6,
                column: "ContactType",
                value: "Email");

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 7,
                column: "ContactType",
                value: "Fax");

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 1,
                column: "SellDate",
                value: new DateTime(2023, 12, 24, 21, 49, 13, 293, DateTimeKind.Local).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 2,
                column: "SellDate",
                value: new DateTime(2023, 12, 24, 21, 49, 13, 293, DateTimeKind.Local).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 3,
                column: "SellDate",
                value: new DateTime(2023, 12, 24, 21, 49, 13, 293, DateTimeKind.Local).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 4,
                column: "SellDate",
                value: new DateTime(2023, 12, 24, 21, 49, 13, 293, DateTimeKind.Local).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "Distributors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Gender",
                value: "Male");

            migrationBuilder.UpdateData(
                table: "Distributors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Gender",
                value: "Male");

            migrationBuilder.UpdateData(
                table: "Distributors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Gender",
                value: "Female");

            migrationBuilder.UpdateData(
                table: "PersonalIdentifiers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DocumentType",
                value: "IDCard");

            migrationBuilder.UpdateData(
                table: "PersonalIdentifiers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DocumentType",
                value: "Passport");

            migrationBuilder.UpdateData(
                table: "PersonalIdentifiers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DocumentType",
                value: "IDCard");

            migrationBuilder.UpdateData(
                table: "PersonalIdentifiers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DocumentType",
                value: "Passport");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Code",
                value: "3e2004e7-ddfb-4634-8f5a-10418588be41");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Code",
                value: "d65141d4-fa67-49e6-b41e-21103490e27b");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Code",
                value: "6848964f-b790-4129-bfe2-b001e6f8ebb7");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Code",
                value: "c3210dd9-fee5-4703-bbfd-3333cf7a6514");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DocumentType",
                table: "PersonalIdentifiers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "Distributors",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<int>(
                name: "ContactType",
                table: "ContactInfos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ContactType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ContactType",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 3,
                column: "ContactType",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 4,
                column: "ContactType",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 5,
                column: "ContactType",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 6,
                column: "ContactType",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 7,
                column: "ContactType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 1,
                column: "SellDate",
                value: new DateTime(2023, 12, 24, 21, 42, 8, 281, DateTimeKind.Local).AddTicks(9905));

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 2,
                column: "SellDate",
                value: new DateTime(2023, 12, 24, 21, 42, 8, 281, DateTimeKind.Local).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 3,
                column: "SellDate",
                value: new DateTime(2023, 12, 24, 21, 42, 8, 281, DateTimeKind.Local).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 4,
                column: "SellDate",
                value: new DateTime(2023, 12, 24, 21, 42, 8, 281, DateTimeKind.Local).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "Distributors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Gender",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Distributors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Gender",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Distributors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Gender",
                value: 2);

            migrationBuilder.UpdateData(
                table: "PersonalIdentifiers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DocumentType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "PersonalIdentifiers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DocumentType",
                value: 2);

            migrationBuilder.UpdateData(
                table: "PersonalIdentifiers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DocumentType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "PersonalIdentifiers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DocumentType",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Code",
                value: "9eb96c40-63c3-4ccf-bc58-272ce3987a54");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Code",
                value: "10991c1c-20bc-4ac4-9dbe-5bab286917c7");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Code",
                value: "5ff7d734-e13e-4751-8bfa-5583c5c1b8c0");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Code",
                value: "8fff07dc-3fb9-4854-b62b-2cab475be2a9");
        }
    }
}
