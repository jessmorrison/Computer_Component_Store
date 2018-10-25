using Microsoft.EntityFrameworkCore.Migrations;

namespace Computer_Component_Store.Data.Migrations
{
    public partial class ComputerUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ComputerComponentCartID",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ComputerComponentCartID",
                table: "AspNetUsers",
                column: "ComputerComponentCartID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ComputerComponentCarts_ComputerComponentCartID",
                table: "AspNetUsers",
                column: "ComputerComponentCartID",
                principalTable: "ComputerComponentCarts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ComputerComponentCarts_ComputerComponentCartID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ComputerComponentCartID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ComputerComponentCartID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");
        }
    }
}
