using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BolgeMahalles",
                columns: table => new
                {
                    BolgeMahalleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BolgeMahalleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BolgeMahalles", x => x.BolgeMahalleID);
                });

            migrationBuilder.CreateTable(
                name: "Emlaks",
                columns: table => new
                {
                    EmlakID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmlakName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmlakOda = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmlakMetreKare = table.Column<int>(type: "int", nullable: false),
                    EmlakKat = table.Column<int>(type: "int", nullable: false),
                    EmlakAsansor = table.Column<bool>(type: "bit", nullable: false),
                    EmlakOtopark = table.Column<bool>(type: "bit", nullable: false),
                    EmlakIsitma = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmlakEsya = table.Column<bool>(type: "bit", nullable: false),
                    EmlakYayinda = table.Column<bool>(type: "bit", nullable: false),
                    EmlakAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emlaks", x => x.EmlakID);
                });

            migrationBuilder.CreateTable(
                name: "EmlakTips",
                columns: table => new
                {
                    EmlakTipID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmlakTipName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmlakTips", x => x.EmlakTipID);
                });

            migrationBuilder.CreateTable(
                name: "EmlakTurs",
                columns: table => new
                {
                    EmlakTurID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmlakTurName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmlakTurs", x => x.EmlakTurID);
                });

            migrationBuilder.CreateTable(
                name: "Yoneticis",
                columns: table => new
                {
                    YoneticiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YoneticiAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YoneticiSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YoneticiTel = table.Column<int>(type: "int", nullable: false),
                    YoneticiMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YoneticiUnvan = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yoneticis", x => x.YoneticiID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BolgeMahalles");

            migrationBuilder.DropTable(
                name: "Emlaks");

            migrationBuilder.DropTable(
                name: "EmlakTips");

            migrationBuilder.DropTable(
                name: "EmlakTurs");

            migrationBuilder.DropTable(
                name: "Yoneticis");
        }
    }
}
