using Microsoft.EntityFrameworkCore.Migrations;

namespace sprinklerschedulingservice.Migrations
{
    public partial class ContextUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_section_schedules_scheduleid",
                table: "section");

            migrationBuilder.DropPrimaryKey(
                name: "PK_section",
                table: "section");

            migrationBuilder.RenameTable(
                name: "section",
                newName: "sections");

            migrationBuilder.RenameIndex(
                name: "IX_section_scheduleid",
                table: "sections",
                newName: "IX_sections_scheduleid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_sections",
                table: "sections",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_sections_schedules_scheduleid",
                table: "sections",
                column: "scheduleid",
                principalTable: "schedules",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sections_schedules_scheduleid",
                table: "sections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_sections",
                table: "sections");

            migrationBuilder.RenameTable(
                name: "sections",
                newName: "section");

            migrationBuilder.RenameIndex(
                name: "IX_sections_scheduleid",
                table: "section",
                newName: "IX_section_scheduleid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_section",
                table: "section",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_section_schedules_scheduleid",
                table: "section",
                column: "scheduleid",
                principalTable: "schedules",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
