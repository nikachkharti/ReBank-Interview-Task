using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetworkManagmentAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class OneToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DistributorAddressContactPersonalIdentifiers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DistributorAddressContactPersonalIdentifiers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    ContactInfoId = table.Column<int>(type: "int", nullable: false),
                    DistributorId = table.Column<int>(type: "int", nullable: false),
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
    }
}
