using Microsoft.EntityFrameworkCore.Migrations;

namespace TreatTracker.Migrations
{
    public partial class AuthorizationAllClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Treats",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "TreatFlavor",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Treats_UserId",
                table: "Treats",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TreatFlavor_UserId",
                table: "TreatFlavor",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TreatFlavor_AspNetUsers_UserId",
                table: "TreatFlavor",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Treats_AspNetUsers_UserId",
                table: "Treats",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TreatFlavor_AspNetUsers_UserId",
                table: "TreatFlavor");

            migrationBuilder.DropForeignKey(
                name: "FK_Treats_AspNetUsers_UserId",
                table: "Treats");

            migrationBuilder.DropIndex(
                name: "IX_Treats_UserId",
                table: "Treats");

            migrationBuilder.DropIndex(
                name: "IX_TreatFlavor_UserId",
                table: "TreatFlavor");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Treats");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "TreatFlavor");
        }
    }
}
