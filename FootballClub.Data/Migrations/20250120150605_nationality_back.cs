using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballClub.Data.Migrations
{
    /// <inheritdoc />
    public partial class nationality_back : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Citizenship",
                table: "Players",
                newName: "Nationality");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nationality",
                table: "Players",
                newName: "Citizenship");
        }
    }
}
