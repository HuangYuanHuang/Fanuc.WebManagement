using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fanuc.Webmanagement.Migrations
{
    public partial class smartconfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Smart_TaskConfig",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    TaskName = table.Column<string>(nullable: true),
                    TaskTag = table.Column<string>(nullable: true),
                    CMD = table.Column<string>(nullable: true),
                    Parms = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Smart_TaskConfig", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Smart_TaskConfig");
        }
    }
}
