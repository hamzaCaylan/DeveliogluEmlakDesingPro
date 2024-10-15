using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BolgeMahalleID",
                table: "Emlaks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Emlaks_BolgeMahalleID",
                table: "Emlaks",
                column: "BolgeMahalleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Emlaks_BolgeMahalles_BolgeMahalleID",
                table: "Emlaks",
                column: "BolgeMahalleID",
                principalTable: "BolgeMahalles",
                principalColumn: "BolgeMahalleID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emlaks_BolgeMahalles_BolgeMahalleID",
                table: "Emlaks");

            migrationBuilder.DropIndex(
                name: "IX_Emlaks_BolgeMahalleID",
                table: "Emlaks");

            migrationBuilder.DropColumn(
                name: "BolgeMahalleID",
                table: "Emlaks");
        }
    }
}
