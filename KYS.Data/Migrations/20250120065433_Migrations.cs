using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KYS.Data.Migrations
{
    /// <inheritdoc />
    public partial class Migrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AracBilgileri_Personeller_PersonelID",
                table: "AracBilgileri");

            migrationBuilder.DropIndex(
                name: "IX_AracBilgileri_PersonelID",
                table: "AracBilgileri");

            migrationBuilder.DropColumn(
                name: "PersonelID",
                table: "AracBilgileri");

            migrationBuilder.CreateIndex(
                name: "IX_AracBilgileri_KayitAcanId",
                table: "AracBilgileri",
                column: "KayitAcanId");

            migrationBuilder.AddForeignKey(
                name: "FK_AracBilgileri_Personeller_KayitAcanId",
                table: "AracBilgileri",
                column: "KayitAcanId",
                principalTable: "Personeller",
                principalColumn: "PersonelID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AracBilgileri_Personeller_KayitAcanId",
                table: "AracBilgileri");

            migrationBuilder.DropIndex(
                name: "IX_AracBilgileri_KayitAcanId",
                table: "AracBilgileri");

            migrationBuilder.AddColumn<int>(
                name: "PersonelID",
                table: "AracBilgileri",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AracBilgileri_PersonelID",
                table: "AracBilgileri",
                column: "PersonelID");

            migrationBuilder.AddForeignKey(
                name: "FK_AracBilgileri_Personeller_PersonelID",
                table: "AracBilgileri",
                column: "PersonelID",
                principalTable: "Personeller",
                principalColumn: "PersonelID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
