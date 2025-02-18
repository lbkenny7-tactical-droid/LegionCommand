using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LegionCommand.Migrations
{
    /// <inheritdoc />
    public partial class Faction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Faction",
                table: "Unit",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Faction",
                table: "Unit");
        }
    }
}
