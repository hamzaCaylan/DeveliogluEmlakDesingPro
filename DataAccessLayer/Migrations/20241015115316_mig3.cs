using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmlakTipID",
                table: "Emlaks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmlakTurID",
                table: "Emlaks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "YoneticiID",
                table: "Emlaks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Emlaks_EmlakTipID",
                table: "Emlaks",
                column: "EmlakTipID");

            migrationBuilder.CreateIndex(
                name: "IX_Emlaks_EmlakTurID",
                table: "Emlaks",
                column: "EmlakTurID");

            migrationBuilder.CreateIndex(
                name: "IX_Emlaks_YoneticiID",
                table: "Emlaks",
                column: "YoneticiID");

            migrationBuilder.AddForeignKey(
                name: "FK_Emlaks_EmlakTips_EmlakTipID",
                table: "Emlaks",
                column: "EmlakTipID",
                principalTable: "EmlakTips",
                principalColumn: "EmlakTipID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Emlaks_EmlakTurs_EmlakTurID",
                table: "Emlaks",
                column: "EmlakTurID",
                principalTable: "EmlakTurs",
                principalColumn: "EmlakTurID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Emlaks_Yoneticis_YoneticiID",
                table: "Emlaks",
                column: "YoneticiID",
                principalTable: "Yoneticis",
                principalColumn: "YoneticiID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emlaks_EmlakTips_EmlakTipID",
                table: "Emlaks");

            migrationBuilder.DropForeignKey(
                name: "FK_Emlaks_EmlakTurs_EmlakTurID",
                table: "Emlaks");

            migrationBuilder.DropForeignKey(
                name: "FK_Emlaks_Yoneticis_YoneticiID",
                table: "Emlaks");

            migrationBuilder.DropIndex(
                name: "IX_Emlaks_EmlakTipID",
                table: "Emlaks");

            migrationBuilder.DropIndex(
                name: "IX_Emlaks_EmlakTurID",
                table: "Emlaks");

            migrationBuilder.DropIndex(
                name: "IX_Emlaks_YoneticiID",
                table: "Emlaks");

            migrationBuilder.DropColumn(
                name: "EmlakTipID",
                table: "Emlaks");

            migrationBuilder.DropColumn(
                name: "EmlakTurID",
                table: "Emlaks");

            migrationBuilder.DropColumn(
                name: "YoneticiID",
                table: "Emlaks");
        }
    }
}
