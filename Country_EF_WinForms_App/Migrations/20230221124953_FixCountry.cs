using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Country_EF_WinForms_App.Migrations
{
    /// <inheritdoc />
    public partial class FixCountry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Cities_CapitalId",
                table: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Countries_CapitalId",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "CapitalId",
                table: "Countries");

            migrationBuilder.AddColumn<bool>(
                name: "IsCapital",
                table: "Cities",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCapital",
                table: "Cities");

            migrationBuilder.AddColumn<int>(
                name: "CapitalId",
                table: "Countries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CapitalId",
                table: "Countries",
                column: "CapitalId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Cities_CapitalId",
                table: "Countries",
                column: "CapitalId",
                principalTable: "Cities",
                principalColumn: "Id");
        }
    }
}
