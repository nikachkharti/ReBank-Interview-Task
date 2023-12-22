using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NetworkManagmentAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class DataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "PersonalIdentifiers",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpireDate",
                table: "PersonalIdentifiers",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Distributors",
                columns: new[] { "Id", "BirthDate", "FirstName", "Gender", "Image", "LastName", "RecomendationsCount", "RecomendatorId" },
                values: new object[,]
                {
                    { 1, new DateTime(1995, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Giorgi", 1, null, "Giorgadze", 0, 0 },
                    { 2, new DateTime(2000, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Davit", 1, null, "Davitidze", 0, 0 },
                    { 3, new DateTime(1997, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anano", 2, null, "Ananiashvili", 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AddressName", "AddressType", "DistributorId" },
                values: new object[,]
                {
                    { 1, "Rustaveli 5", 1, 1 },
                    { 2, "Rustaveli 6", 2, 1 },
                    { 3, "Pekini 21", 1, 2 },
                    { 4, "Kostava 13", 1, 3 },
                    { 5, "Tsereteli 5", 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "ContactInfos",
                columns: new[] { "Id", "ContactNumber", "ContactType", "DistributorId" },
                values: new object[,]
                {
                    { 1, "555338877", 1, 1 },
                    { 2, "giorgigiorgadze@gmail.com", 3, 1 },
                    { 3, "davit123@gmail.com", 3, 2 },
                    { 4, "551448877", 2, 2 },
                    { 5, "558776932", 2, 3 },
                    { 6, "anano@yahoo.com", 3, 3 },
                    { 7, "123879", 4, 3 }
                });

            migrationBuilder.InsertData(
                table: "PersonalIdentifiers",
                columns: new[] { "Id", "DistributorId", "DocumentNumber", "DocumentSeries", "DocumentType", "ExpireDate", "IssuingAuthority", "PersonalNumber", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, 1, "123", "12345678", 1, new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Justice house", "0102487452", new DateTime(2016, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, "332", "115632", 2, new DateTime(2015, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Justice house", "012589632", new DateTime(2010, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 2, "125", "115633", 1, new DateTime(2015, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Justice house", "41587463983", new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 3, "658", "215633", 2, new DateTime(2015, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Justice house", "158965822", new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PersonalIdentifiers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PersonalIdentifiers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PersonalIdentifiers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PersonalIdentifiers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Distributors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Distributors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Distributors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "PersonalIdentifiers",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpireDate",
                table: "PersonalIdentifiers",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");
        }
    }
}
