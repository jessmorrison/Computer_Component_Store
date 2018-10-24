using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Computer_Component_Store.Data.Migrations
{
    public partial class CartAndCartItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ComputerComponentCarts",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CookieID = table.Column<Guid>(nullable: true),
                    Created = table.Column<DateTime>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerComponentCarts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ComputerComponentCartItems",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ComputerComponentCartID = table.Column<int>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    ComputerComponentProductID = table.Column<int>(nullable: true),
                    Created = table.Column<DateTime>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerComponentCartItems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ComputerComponentCartItems_ComputerComponentCarts_ComputerComponentCartID",
                        column: x => x.ComputerComponentCartID,
                        principalTable: "ComputerComponentCarts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ComputerComponentCartItems_ComputerComponentProducts_ComputerComponentProductID",
                        column: x => x.ComputerComponentProductID,
                        principalTable: "ComputerComponentProducts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComputerComponentCartItems_ComputerComponentCartID",
                table: "ComputerComponentCartItems",
                column: "ComputerComponentCartID");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerComponentCartItems_ComputerComponentProductID",
                table: "ComputerComponentCartItems",
                column: "ComputerComponentProductID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComputerComponentCartItems");

            migrationBuilder.DropTable(
                name: "ComputerComponentCarts");
        }
    }
}
