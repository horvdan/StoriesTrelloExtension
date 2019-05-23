using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StoriesTrelloExtension.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Epics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Epics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Releases",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Releases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Steps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    EpicId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Steps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Steps_Epics_EpicId",
                        column: x => x.EpicId,
                        principalTable: "Epics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    StepId = table.Column<int>(nullable: true),
                    ReleaseId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_Releases_ReleaseId",
                        column: x => x.ReleaseId,
                        principalTable: "Releases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tasks_Steps_StepId",
                        column: x => x.StepId,
                        principalTable: "Steps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Epics",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Epic 1" },
                    { 2, "Epic 2" },
                    { 3, "Epic 3" },
                    { 4, "Epic 4" }
                });

            migrationBuilder.InsertData(
                table: "Releases",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Release 1" },
                    { 2, "Release 2" }
                });

            migrationBuilder.InsertData(
                table: "Steps",
                columns: new[] { "Id", "EpicId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Step 1" },
                    { 2, 1, "Step 2" },
                    { 3, 1, "Step 3" },
                    { 4, 2, "Step 4" },
                    { 5, 3, "Step 5" },
                    { 6, 3, "Step 6" },
                    { 7, 3, "Step 7" },
                    { 8, 4, "Step 8" },
                    { 9, 4, "Step 9" }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Name", "ReleaseId", "StepId" },
                values: new object[,]
                {
                    { 8, "Task 8", 1, 2 },
                    { 15, "Task 15", 2, 7 },
                    { 4, "Task 4", 2, 7 },
                    { 17, "Task 17", 1, 6 },
                    { 11, "Task 11", 2, 6 },
                    { 7, "Task 7", 2, 6 },
                    { 16, "Task 16", 1, 5 },
                    { 13, "Task 13", 2, 5 },
                    { 6, "Task 6", 1, 5 },
                    { 2, "Task 2", 2, 5 },
                    { 1, "Task 1", 1, 5 },
                    { 14, "Task 14", 2, 4 },
                    { 12, "Task 12", 2, 4 },
                    { 5, "Task 5", 1, 4 },
                    { 3, "Task 3", 2, 4 },
                    { 18, "Task 18", 1, 3 },
                    { 9, "Task 9", 1, 8 },
                    { 10, "Task 10", 1, 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Steps_EpicId",
                table: "Steps",
                column: "EpicId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_ReleaseId",
                table: "Tasks",
                column: "ReleaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_StepId",
                table: "Tasks",
                column: "StepId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Releases");

            migrationBuilder.DropTable(
                name: "Steps");

            migrationBuilder.DropTable(
                name: "Epics");
        }
    }
}
