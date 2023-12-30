using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetworkManagmentAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class BonusEarned : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "BonusEarned",
                table: "Distributors",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 1,
                column: "SellDate",
                value: new DateTime(2023, 12, 29, 23, 25, 28, 488, DateTimeKind.Local).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 2,
                column: "SellDate",
                value: new DateTime(2023, 12, 29, 23, 25, 28, 488, DateTimeKind.Local).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 3,
                column: "SellDate",
                value: new DateTime(2023, 12, 29, 23, 25, 28, 488, DateTimeKind.Local).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 4,
                column: "SellDate",
                value: new DateTime(2023, 12, 29, 23, 25, 28, 488, DateTimeKind.Local).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "Distributors",
                keyColumn: "Id",
                keyValue: 1,
                column: "BonusEarned",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Distributors",
                keyColumn: "Id",
                keyValue: 2,
                column: "BonusEarned",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Distributors",
                keyColumn: "Id",
                keyValue: 3,
                column: "BonusEarned",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Code",
                value: "c71b0e20-a2c2-4262-9251-769e6e2830d5");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Code",
                value: "b2052e4e-6572-4317-a82c-8047ca67856d");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Code",
                value: "bd00471c-df8f-4db3-be04-89578489a535");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Code",
                value: "5dd22e6f-4c0e-4b4b-b8e5-f87487b97862");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BonusEarned",
                table: "Distributors");

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 1,
                column: "SellDate",
                value: new DateTime(2023, 12, 29, 22, 45, 24, 828, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 2,
                column: "SellDate",
                value: new DateTime(2023, 12, 29, 22, 45, 24, 828, DateTimeKind.Local).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 3,
                column: "SellDate",
                value: new DateTime(2023, 12, 29, 22, 45, 24, 828, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 4,
                column: "SellDate",
                value: new DateTime(2023, 12, 29, 22, 45, 24, 828, DateTimeKind.Local).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Code",
                value: "2fb3504a-433a-4890-9aa5-4f2a577e1416");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Code",
                value: "53eac4c6-fe06-4039-8ed8-fbd7bd4dbc15");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Code",
                value: "36057f25-ff58-4a3b-9736-f3beee1d7eca");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Code",
                value: "59ccede5-befd-4460-b56b-a5e12cbf5340");
        }
    }
}
