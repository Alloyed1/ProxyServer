using Microsoft.EntityFrameworkCore.Migrations;

namespace ProxyServer.Migrations
{
    public partial class dfgdfgh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "BitcoinPayments",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BitcoinPayments_UserId",
                table: "BitcoinPayments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BitcoinPayments_AspNetUsers_UserId",
                table: "BitcoinPayments",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BitcoinPayments_AspNetUsers_UserId",
                table: "BitcoinPayments");

            migrationBuilder.DropIndex(
                name: "IX_BitcoinPayments_UserId",
                table: "BitcoinPayments");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "BitcoinPayments",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
