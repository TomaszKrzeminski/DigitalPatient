using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Digital_Patient.Data.Migrations
{
    public partial class Start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "MeasurementCategories",
                columns: table => new
                {
                    MeasurementCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeasurementCategories", x => x.MeasurementCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "TaskCategories",
                columns: table => new
                {
                    TaskToDoCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskCategories", x => x.TaskToDoCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Measurements",
                columns: table => new
                {
                    MeasurementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MeasurementCategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Measurements", x => x.MeasurementId);
                    table.ForeignKey(
                        name: "FK_Measurements_MeasurementCategories_MeasurementCategoryId",
                        column: x => x.MeasurementCategoryId,
                        principalTable: "MeasurementCategories",
                        principalColumn: "MeasurementCategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TasksToDo",
                columns: table => new
                {
                    TaskToDoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TaskToDoCategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TasksToDo", x => x.TaskToDoId);
                    table.ForeignKey(
                        name: "FK_TasksToDo_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TasksToDo_TaskCategories_TaskToDoCategoryId",
                        column: x => x.TaskToDoCategoryId,
                        principalTable: "TaskCategories",
                        principalColumn: "TaskToDoCategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MeasurementPairs",
                columns: table => new
                {
                    MeasurementPairId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeasurementText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeasurementNumber = table.Column<double>(type: "float", nullable: false),
                    MeasurementId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeasurementPairs", x => x.MeasurementPairId);
                    table.ForeignKey(
                        name: "FK_MeasurementPairs_Measurements_MeasurementId",
                        column: x => x.MeasurementId,
                        principalTable: "Measurements",
                        principalColumn: "MeasurementId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    NoteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Important = table.Column<bool>(type: "bit", nullable: false),
                    MeasurementId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.NoteId);
                    table.ForeignKey(
                        name: "FK_Notes_Measurements_MeasurementId",
                        column: x => x.MeasurementId,
                        principalTable: "Measurements",
                        principalColumn: "MeasurementId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IntervalDatas",
                columns: table => new
                {
                    IntervalDataId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Inverval = table.Column<TimeSpan>(type: "time", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Last = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Weekends = table.Column<bool>(type: "bit", nullable: false),
                    Holidays = table.Column<bool>(type: "bit", nullable: false),
                    Morning = table.Column<bool>(type: "bit", nullable: false),
                    Afternoon = table.Column<bool>(type: "bit", nullable: false),
                    Night = table.Column<bool>(type: "bit", nullable: false),
                    Breakfast = table.Column<bool>(type: "bit", nullable: false),
                    Lunch = table.Column<bool>(type: "bit", nullable: false),
                    Supper = table.Column<bool>(type: "bit", nullable: false),
                    TaskToDoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntervalDatas", x => x.IntervalDataId);
                    table.ForeignKey(
                        name: "FK_IntervalDatas_TasksToDo_TaskToDoId",
                        column: x => x.TaskToDoId,
                        principalTable: "TasksToDo",
                        principalColumn: "TaskToDoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IntervalDatas_TaskToDoId",
                table: "IntervalDatas",
                column: "TaskToDoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MeasurementPairs_MeasurementId",
                table: "MeasurementPairs",
                column: "MeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_Measurements_MeasurementCategoryId",
                table: "Measurements",
                column: "MeasurementCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_MeasurementId",
                table: "Notes",
                column: "MeasurementId",
                unique: true,
                filter: "[MeasurementId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TasksToDo_ApplicationUserId",
                table: "TasksToDo",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TasksToDo_TaskToDoCategoryId",
                table: "TasksToDo",
                column: "TaskToDoCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IntervalDatas");

            migrationBuilder.DropTable(
                name: "MeasurementPairs");

            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "TasksToDo");

            migrationBuilder.DropTable(
                name: "Measurements");

            migrationBuilder.DropTable(
                name: "TaskCategories");

            migrationBuilder.DropTable(
                name: "MeasurementCategories");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");
        }
    }
}
