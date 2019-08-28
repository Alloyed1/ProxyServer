using Microsoft.EntityFrameworkCore.Migrations;

namespace ProxyServer.Migrations
{
    public partial class fghfghf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Notify",
                table: "Subscribes",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notify",
                table: "Subscribes");
        }
    }
}
