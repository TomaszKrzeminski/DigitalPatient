using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Digital_Patient.Data.Migrations
{
    public partial class One : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IntervalDatas_TasksToDo_TaskToDoId",
                table: "IntervalDatas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IntervalDatas",
                table: "IntervalDatas");

            migrationBuilder.RenameTable(
                name: "IntervalDatas",
                newName: "IntervalData");

            migrationBuilder.RenameIndex(
                name: "IX_IntervalDatas_TaskToDoId",
                table: "IntervalData",
                newName: "IX_IntervalData_TaskToDoId");

            migrationBuilder.AddColumn<int>(
                name: "TaskToDoId",
                table: "Measurements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Dateofbirth",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HouseNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserImagePath",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "sex",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_IntervalData",
                table: "IntervalData",
                column: "IntervalDataId");

            migrationBuilder.CreateIndex(
                name: "IX_Measurements_TaskToDoId",
                table: "Measurements",
                column: "TaskToDoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_IntervalData_TasksToDo_TaskToDoId",
                table: "IntervalData",
                column: "TaskToDoId",
                principalTable: "TasksToDo",
                principalColumn: "TaskToDoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Measurements_TasksToDo_TaskToDoId",
                table: "Measurements",
                column: "TaskToDoId",
                principalTable: "TasksToDo",
                principalColumn: "TaskToDoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IntervalData_TasksToDo_TaskToDoId",
                table: "IntervalData");

            migrationBuilder.DropForeignKey(
                name: "FK_Measurements_TasksToDo_TaskToDoId",
                table: "Measurements");

            migrationBuilder.DropIndex(
                name: "IX_Measurements_TaskToDoId",
                table: "Measurements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IntervalData",
                table: "IntervalData");

            migrationBuilder.DropColumn(
                name: "TaskToDoId",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Dateofbirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "HouseNumber",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserImagePath",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "sex",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "IntervalData",
                newName: "IntervalDatas");

            migrationBuilder.RenameIndex(
                name: "IX_IntervalData_TaskToDoId",
                table: "IntervalDatas",
                newName: "IX_IntervalDatas_TaskToDoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IntervalDatas",
                table: "IntervalDatas",
                column: "IntervalDataId");

            migrationBuilder.AddForeignKey(
                name: "FK_IntervalDatas_TasksToDo_TaskToDoId",
                table: "IntervalDatas",
                column: "TaskToDoId",
                principalTable: "TasksToDo",
                principalColumn: "TaskToDoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
