using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace sprinklerschedulingservice.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "schedules",
                columns: table => new
                {
                    run = table.Column<bool>(nullable: false),
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_schedules", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "section",
                columns: table => new
                {
                    starttime = table.Column<DateTime>(nullable: false),
                    duration = table.Column<int>(nullable: false),
                    days = table.Column<List<string>>(nullable: true),
                    zonenumber = table.Column<int>(nullable: false),
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    scheduleid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_section", x => x.id);
                    table.ForeignKey(
                        name: "FK_section_schedules_scheduleid",
                        column: x => x.scheduleid,
                        principalTable: "schedules",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_section_scheduleid",
                table: "section",
                column: "scheduleid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "section");

            migrationBuilder.DropTable(
                name: "schedules");
        }
    }
}
