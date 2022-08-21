using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotsite.Migrations
{
    public partial class createDatabase3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InteresseId",
                table: "dica",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_dica_InteresseId",
                table: "dica",
                column: "InteresseId");

            migrationBuilder.AddForeignKey(
                name: "FK_dica_Interesses_InteresseId",
                table: "dica",
                column: "InteresseId",
                principalTable: "Interesses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dica_Interesses_InteresseId",
                table: "dica");

            migrationBuilder.DropIndex(
                name: "IX_dica_InteresseId",
                table: "dica");

            migrationBuilder.DropColumn(
                name: "InteresseId",
                table: "dica");
        }
    }
}
