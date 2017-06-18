using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SytnerDashboard.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StaffReview",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Attendance = table.Column<int>(nullable: false),
                    CommunicationSkills = table.Column<int>(nullable: false),
                    Creativity = table.Column<int>(nullable: false),
                    DateOfReview = table.Column<DateTime>(nullable: false),
                    Forename = table.Column<string>(nullable: true),
                    Productivity = table.Column<int>(nullable: false),
                    Surenamename = table.Column<string>(nullable: true),
                    TechnicalSkills = table.Column<int>(nullable: false),
                    WorkQuality = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffReview", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StaffReview");
        }
    }
}
