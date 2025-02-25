﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KYS.WebUI.Migrations
{
    /// <inheritdoc />
    public partial class AddFirmaKoduToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirmaKodu",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirmaKodu",
                table: "AspNetUsers");
        }
    }
}
