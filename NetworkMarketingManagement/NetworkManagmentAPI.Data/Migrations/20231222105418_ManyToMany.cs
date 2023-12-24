using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetworkManagmentAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class ManyToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "DistributorAddressContactPersonalIdentifiers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistributorId = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    ContactInfoId = table.Column<int>(type: "int", nullable: false),
                    PersonalIdentifierId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistributorAddressContactPersonalIdentifiers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DistributorAddressContactPersonalIdentifiers_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DistributorAddressContactPersonalIdentifiers_ContactInfos_ContactInfoId",
                        column: x => x.ContactInfoId,
                        principalTable: "ContactInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DistributorAddressContactPersonalIdentifiers_Distributors_DistributorId",
                        column: x => x.DistributorId,
                        principalTable: "Distributors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DistributorAddressContactPersonalIdentifiers_PersonalIdentifiers_PersonalIdentifierId",
                        column: x => x.PersonalIdentifierId,
                        principalTable: "PersonalIdentifiers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DistributorAddressContactPersonalIdentifiers_AddressId",
                table: "DistributorAddressContactPersonalIdentifiers",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_DistributorAddressContactPersonalIdentifiers_ContactInfoId",
                table: "DistributorAddressContactPersonalIdentifiers",
                column: "ContactInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_DistributorAddressContactPersonalIdentifiers_DistributorId",
                table: "DistributorAddressContactPersonalIdentifiers",
                column: "DistributorId");

            migrationBuilder.CreateIndex(
                name: "IX_DistributorAddressContactPersonalIdentifiers_PersonalIdentifierId",
                table: "DistributorAddressContactPersonalIdentifiers",
                column: "PersonalIdentifierId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DistributorAddressContactPersonalIdentifiers");

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
    }
}
