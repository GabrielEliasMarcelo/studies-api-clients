using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clients.Services.Migrations
{
    public partial class _27072022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    IdBirthCountry = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.IdBirthCountry);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    IdClient = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdNumber = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdBirthCountry = table.Column<int>(type: "int", nullable: false),
                    Excluded = table.Column<bool>(type: "bit", nullable: false),
                    RegistrationDt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.IdClient);
                    table.ForeignKey(
                        name: "FK_Clients_Countries_IdBirthCountry",
                        column: x => x.IdBirthCountry,
                        principalTable: "Countries",
                        principalColumn: "IdBirthCountry",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_IdBirthCountry",
                table: "Clients",
                column: "IdBirthCountry");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
