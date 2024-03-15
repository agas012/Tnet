using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tnet.Migrations
{
    /// <inheritdoc />
    public partial class upd4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HablalenguaIndigena",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "PertenecegrupoEtnico",
                table: "Patients");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HablalenguaIndigena",
                table: "Patients",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PertenecegrupoEtnico",
                table: "Patients",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
