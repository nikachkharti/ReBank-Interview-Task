using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetworkManagmentAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class RelationshipEnabled : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DistributorId",
                table: "PersonalIdentifiers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DistributorId",
                table: "ContactInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DistributorId",
                table: "Addresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PersonalIdentifiers_DistributorId",
                table: "PersonalIdentifiers",
                column: "DistributorId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactInfos_DistributorId",
                table: "ContactInfos",
                column: "DistributorId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_DistributorId",
                table: "Addresses",
                column: "DistributorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Distributors_DistributorId",
                table: "Addresses",
                column: "DistributorId",
                principalTable: "Distributors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactInfos_Distributors_DistributorId",
                table: "ContactInfos",
                column: "DistributorId",
                principalTable: "Distributors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalIdentifiers_Distributors_DistributorId",
                table: "PersonalIdentifiers",
                column: "DistributorId",
                principalTable: "Distributors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Distributors_DistributorId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactInfos_Distributors_DistributorId",
                table: "ContactInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonalIdentifiers_Distributors_DistributorId",
                table: "PersonalIdentifiers");

            migrationBuilder.DropIndex(
                name: "IX_PersonalIdentifiers_DistributorId",
                table: "PersonalIdentifiers");

            migrationBuilder.DropIndex(
                name: "IX_ContactInfos_DistributorId",
                table: "ContactInfos");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_DistributorId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "DistributorId",
                table: "PersonalIdentifiers");

            migrationBuilder.DropColumn(
                name: "DistributorId",
                table: "ContactInfos");

            migrationBuilder.DropColumn(
                name: "DistributorId",
                table: "Addresses");
        }
    }
}
