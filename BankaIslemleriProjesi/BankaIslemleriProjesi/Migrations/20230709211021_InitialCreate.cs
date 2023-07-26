using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankaIslemleriProjesi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Islems",
                columns: table => new
                {
                    IslemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HesapNumarasi = table.Column<string>(type: "nvarchar(12)", nullable: false),
                    MusteriAdi = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    BankaAdi = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    SWIFTCode = table.Column<string>(type: "nvarchar(11)", nullable: false),
                    Tutar = table.Column<int>(type: "int", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Islems", x => x.IslemId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Islems");
        }
    }
}
