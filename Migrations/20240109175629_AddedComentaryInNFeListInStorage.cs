using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeitorNfe.Migrations
{
    /// <inheritdoc />
    public partial class AddedComentaryInNFeListInStorage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "directory",
                table: "NFesInStorage",
                newName: "Directory");

            migrationBuilder.AddColumn<string>(
                name: "Comentary",
                table: "NFesInStorage",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comentary",
                table: "NFesInStorage");

            migrationBuilder.RenameColumn(
                name: "Directory",
                table: "NFesInStorage",
                newName: "directory");
        }
    }
}
