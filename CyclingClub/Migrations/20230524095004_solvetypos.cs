using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CyclingClub.Migrations
{
    /// <inheritdoc />
    public partial class solvetypos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AddessSecondLine",
                table: "Users",
                newName: "AddressSecondLine");

            migrationBuilder.RenameColumn(
                name: "AddessFirstLine",
                table: "Users",
                newName: "AddressFirstLine");

            migrationBuilder.RenameColumn(
                name: "AddessCity",
                table: "Users",
                newName: "AddressCity");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AddressSecondLine",
                table: "Users",
                newName: "AddessSecondLine");

            migrationBuilder.RenameColumn(
                name: "AddressFirstLine",
                table: "Users",
                newName: "AddessFirstLine");

            migrationBuilder.RenameColumn(
                name: "AddressCity",
                table: "Users",
                newName: "AddessCity");
        }
    }
}
