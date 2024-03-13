using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tnet.Migrations
{
    /// <inheritdoc />
    public partial class upd2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Frágil_FuertePersonas",
                table: "Patients",
                newName: "Fragil_FuertePersonas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Fragil_FuertePersonas",
                table: "Patients",
                newName: "Frágil_FuertePersonas");
        }
    }
}
