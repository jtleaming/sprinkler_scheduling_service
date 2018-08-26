using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace sprinklerschedulingservice.Migrations
{
    public partial class AnotherMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "starttime",
                table: "section",
                nullable: true,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "starttime",
                table: "section",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
