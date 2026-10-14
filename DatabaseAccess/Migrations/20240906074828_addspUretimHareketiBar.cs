using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseAccess.Migrations
{
    /// <inheritdoc />
    public partial class addspUretimHareketiBar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "spurturetimhareketibar",
                columns: table => new
                {
                    nUserID = table.Column<int>(type: "int", nullable: false),
                    lMiktar = table.Column<int>(type: "int", nullable: false),
                    dteKayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_spurturetimhareketibar", x => x.nUserID);
                    table.ForeignKey(
                        name: "FK_spurturetimhareketibar_spurtuser_nUserID",
                        column: x => x.nUserID,
                        principalTable: "spurtuser",
                        principalColumn: "nUserID",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "spurturetimhareketibar");
        }
    }
}
