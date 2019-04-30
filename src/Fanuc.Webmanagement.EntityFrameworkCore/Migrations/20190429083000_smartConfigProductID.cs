using Microsoft.EntityFrameworkCore.Migrations;

namespace Fanuc.Webmanagement.Migrations
{
    public partial class smartConfigProductID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductID",
                table: "Smart_TaskConfig",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "Smart_TaskConfig");
        }
    }
}
