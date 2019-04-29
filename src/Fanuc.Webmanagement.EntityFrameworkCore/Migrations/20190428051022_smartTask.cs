using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fanuc.Webmanagement.Migrations
{
    public partial class smartTask : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Smart_Task",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductID = table.Column<string>(nullable: true),
                    LineID = table.Column<string>(nullable: true),
                    TaskName = table.Column<string>(nullable: true),
                    Num = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    FinishTime = table.Column<DateTime>(nullable: true),
                    Priority = table.Column<int>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Smart_Task", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Smart_TaskInfo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TaskID = table.Column<int>(nullable: false),
                    TaskName = table.Column<string>(nullable: true),
                    Priority = table.Column<int>(nullable: false),
                    IsSuccess = table.Column<bool>(nullable: false),
                    FinishTime = table.Column<DateTime>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Smart_TaskInfo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Smart_Task");

            migrationBuilder.DropTable(
                name: "Smart_TaskInfo");
        }
    }
}
