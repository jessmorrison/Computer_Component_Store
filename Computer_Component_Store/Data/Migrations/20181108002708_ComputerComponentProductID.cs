using Microsoft.EntityFrameworkCore.Migrations;

namespace Computer_Component_Store.Data.Migrations
{
    public partial class ComputerComponentProductID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComputerComponentCartItems_ComputerComponentProducts_ComputerComponentProductID",
                table: "ComputerComponentCartItems");

            migrationBuilder.DropIndex(
                name: "IX_ComputerComponentCartItems_ComputerComponentProductID",
                table: "ComputerComponentCartItems");

            migrationBuilder.DropColumn(
                name: "CableIDHardcore",
                table: "ComputerComponentProducts");

            migrationBuilder.DropColumn(
                name: "CoolingSystemIDHardcore",
                table: "ComputerComponentProducts");

            migrationBuilder.DropColumn(
                name: "MotherboardIDHardcore",
                table: "ComputerComponentProducts");

            migrationBuilder.DropColumn(
                name: "CableIDHardcore",
                table: "ComputerComponentCarts");

            migrationBuilder.DropColumn(
                name: "CoolingSystemIDHardcore",
                table: "ComputerComponentCarts");

            migrationBuilder.DropColumn(
                name: "MotherboardIDHardcore",
                table: "ComputerComponentCarts");

            migrationBuilder.DropColumn(
                name: "CableIDHardcore",
                table: "ComputerComponentCartItems");

            migrationBuilder.DropColumn(
                name: "ComputerComponentProductID",
                table: "ComputerComponentCartItems");

            migrationBuilder.DropColumn(
                name: "CoolingSystemIDHardcore",
                table: "ComputerComponentCartItems");

            migrationBuilder.RenameColumn(
                name: "MotherboardIDHardcore",
                table: "ComputerComponentCartItems",
                newName: "ComputerComponentProductID1");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerComponentCartItems_ComputerComponentProductID1",
                table: "ComputerComponentCartItems",
                column: "ComputerComponentProductID1");

            migrationBuilder.AddForeignKey(
                name: "FK_ComputerComponentCartItems_ComputerComponentProducts_ComputerComponentProductID1",
                table: "ComputerComponentCartItems",
                column: "ComputerComponentProductID1",
                principalTable: "ComputerComponentProducts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComputerComponentCartItems_ComputerComponentProducts_ComputerComponentProductID1",
                table: "ComputerComponentCartItems");

            migrationBuilder.DropIndex(
                name: "IX_ComputerComponentCartItems_ComputerComponentProductID1",
                table: "ComputerComponentCartItems");

            migrationBuilder.RenameColumn(
                name: "ComputerComponentProductID1",
                table: "ComputerComponentCartItems",
                newName: "MotherboardIDHardcore");

            migrationBuilder.AddColumn<int>(
                name: "CableIDHardcore",
                table: "ComputerComponentProducts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CoolingSystemIDHardcore",
                table: "ComputerComponentProducts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MotherboardIDHardcore",
                table: "ComputerComponentProducts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CableIDHardcore",
                table: "ComputerComponentCarts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CoolingSystemIDHardcore",
                table: "ComputerComponentCarts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MotherboardIDHardcore",
                table: "ComputerComponentCarts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CableIDHardcore",
                table: "ComputerComponentCartItems",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ComputerComponentProductID",
                table: "ComputerComponentCartItems",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CoolingSystemIDHardcore",
                table: "ComputerComponentCartItems",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ComputerComponentCartItems_ComputerComponentProductID",
                table: "ComputerComponentCartItems",
                column: "ComputerComponentProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_ComputerComponentCartItems_ComputerComponentProducts_ComputerComponentProductID",
                table: "ComputerComponentCartItems",
                column: "ComputerComponentProductID",
                principalTable: "ComputerComponentProducts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
