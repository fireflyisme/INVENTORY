using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class AspNetUsers_ProgramId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Program",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "ProgramId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ProgramId",
                table: "AspNetUsers",
                column: "ProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Programs_ProgramId",
                table: "AspNetUsers",
                column: "ProgramId",
                principalTable: "Programs",
                principalColumn: "ProgramId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Programs_ProgramId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ProgramId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProgramId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "Program",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
