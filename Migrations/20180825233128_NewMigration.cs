using Microsoft.EntityFrameworkCore.Migrations;

namespace sprinklerschedulingservice.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Section_Schedules_ScheduleId",
                table: "Section");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Section",
                table: "Section");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Schedules",
                table: "Schedules");

            migrationBuilder.RenameTable(
                name: "Section",
                newName: "section");

            migrationBuilder.RenameTable(
                name: "Schedules",
                newName: "schedules");

            migrationBuilder.RenameColumn(
                name: "ZoneNumber",
                table: "section",
                newName: "zonenumber");

            migrationBuilder.RenameColumn(
                name: "StartTime",
                table: "section",
                newName: "starttime");

            migrationBuilder.RenameColumn(
                name: "ScheduleId",
                table: "section",
                newName: "scheduleid");

            migrationBuilder.RenameColumn(
                name: "Duration",
                table: "section",
                newName: "duration");

            migrationBuilder.RenameColumn(
                name: "Days",
                table: "section",
                newName: "days");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "section",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Section_ScheduleId",
                table: "section",
                newName: "IX_section_scheduleid");

            migrationBuilder.RenameColumn(
                name: "Run",
                table: "schedules",
                newName: "run");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "schedules",
                newName: "id");

            migrationBuilder.AlterColumn<int>(
                name: "scheduleid",
                table: "section",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_section",
                table: "section",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_schedules",
                table: "schedules",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_section_schedules_scheduleid",
                table: "section",
                column: "scheduleid",
                principalTable: "schedules",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_section_schedules_scheduleid",
                table: "section");

            migrationBuilder.DropPrimaryKey(
                name: "PK_section",
                table: "section");

            migrationBuilder.DropPrimaryKey(
                name: "PK_schedules",
                table: "schedules");

            migrationBuilder.RenameTable(
                name: "section",
                newName: "Section");

            migrationBuilder.RenameTable(
                name: "schedules",
                newName: "Schedules");

            migrationBuilder.RenameColumn(
                name: "zonenumber",
                table: "Section",
                newName: "ZoneNumber");

            migrationBuilder.RenameColumn(
                name: "starttime",
                table: "Section",
                newName: "StartTime");

            migrationBuilder.RenameColumn(
                name: "scheduleid",
                table: "Section",
                newName: "ScheduleId");

            migrationBuilder.RenameColumn(
                name: "duration",
                table: "Section",
                newName: "Duration");

            migrationBuilder.RenameColumn(
                name: "days",
                table: "Section",
                newName: "Days");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Section",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_section_scheduleid",
                table: "Section",
                newName: "IX_Section_ScheduleId");

            migrationBuilder.RenameColumn(
                name: "run",
                table: "Schedules",
                newName: "Run");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Schedules",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "ScheduleId",
                table: "Section",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Section",
                table: "Section",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Schedules",
                table: "Schedules",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Section_Schedules_ScheduleId",
                table: "Section",
                column: "ScheduleId",
                principalTable: "Schedules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
