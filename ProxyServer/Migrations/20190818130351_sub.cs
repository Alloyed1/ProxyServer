using Microsoft.EntityFrameworkCore.Migrations;

namespace ProxyServer.Migrations
{
    public partial class sub : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountProxy",
                table: "Subscribes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountProxy",
                table: "Subscribes");
        }
    }
}
