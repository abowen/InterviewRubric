using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InterviewRubric.Server.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RubricQuestions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Question = table.Column<string>(nullable: true),
                    Category = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Difficulty = table.Column<int>(nullable: false),
                    Low = table.Column<string>(nullable: true),
                    Medium = table.Column<string>(nullable: true),
                    High = table.Column<string>(nullable: true),
                    Minutes = table.Column<int>(nullable: false),
                    Technology = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RubricQuestions", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RubricQuestions");
        }
    }
}
