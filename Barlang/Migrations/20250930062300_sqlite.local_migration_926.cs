using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Barlang.Migrations
{
    /// <inheritdoc />
    public partial class sqlitelocal_migration_926 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Barlangok",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nev = table.Column<string>(type: "TEXT", nullable: false),
                    hossz = table.Column<int>(type: "INTEGER", nullable: false),
                    kiterjedes = table.Column<int>(type: "INTEGER", nullable: false),
                    melyseg = table.Column<int>(type: "INTEGER", nullable: false),
                    magassag = table.Column<int>(type: "INTEGER", nullable: false),
                    telepules = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barlangok", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Barlangok");
        }
    }
}
