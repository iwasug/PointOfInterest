using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfInterest.Migrations
{
    public partial class Rumah : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rumah",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nama = table.Column<string>(nullable: false),
                    Type = table.Column<string>(nullable: false),
                    Alamat = table.Column<string>(nullable: false),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    Create = table.Column<DateTime>(nullable: false),
                    Update = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rumah", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rumah");
        }
    }
}
