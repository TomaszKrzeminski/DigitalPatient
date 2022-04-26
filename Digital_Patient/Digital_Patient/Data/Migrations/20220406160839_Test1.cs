using Microsoft.EntityFrameworkCore.Migrations;

namespace Digital_Patient.Data.Migrations
{
    public partial class Test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Last",
                table: "IntervalData",
                newName: "EndTime");

            migrationBuilder.RenameColumn(
                name: "Inverval",
                table: "IntervalData",
                newName: "Interval");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TasksToDo",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "TasksToDo");

            migrationBuilder.RenameColumn(
                name: "Interval",
                table: "IntervalData",
                newName: "Inverval");

            migrationBuilder.RenameColumn(
                name: "EndTime",
                table: "IntervalData",
                newName: "Last");
        }
    }
}
