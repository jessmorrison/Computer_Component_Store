using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Computer_Component_Store.Data.Migrations
{
    public partial class ComputerComponentOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ComputerComponentOrders",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    ContactEmail = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    ShippingStreet = table.Column<string>(nullable: true),
                    ShippingCity = table.Column<string>(nullable: true),
                    ShippingState = table.Column<string>(nullable: true),
                    ShippingPostalCode = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerComponentOrders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ComputerComponentOrderItems",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Quantity = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: true),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ProductPrice = table.Column<decimal>(nullable: true),
                    Created = table.Column<DateTime>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    ComputerComponentOrderID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerComponentOrderItems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ComputerComponentOrderItems_ComputerComponentOrders_ComputerComponentOrderID",
                        column: x => x.ComputerComponentOrderID,
                        principalTable: "ComputerComponentOrders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComputerComponentOrderItems_ComputerComponentOrderID",
                table: "ComputerComponentOrderItems",
                column: "ComputerComponentOrderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComputerComponentOrderItems");

            migrationBuilder.DropTable(
                name: "ComputerComponentOrders");
        }
    }
}
