using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class mg1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hocas",
                columns: table => new
                {
                    HocaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HocaAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HocaSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hocas", x => x.HocaID);
                });

            migrationBuilder.CreateTable(
                name: "Ders",
                columns: table => new
                {
                    DersID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DersKontenjan = table.Column<int>(type: "int", nullable: false),
                    DersStatus = table.Column<bool>(type: "bit", nullable: false),
                    HocaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ders", x => x.DersID);
                    table.ForeignKey(
                        name: "FK_Ders_Hocas_HocaId",
                        column: x => x.HocaId,
                        principalTable: "Hocas",
                        principalColumn: "HocaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ogrencis",
                columns: table => new
                {
                    OgrenciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OgrenciSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OgrenciSınıf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OgrenciStatus = table.Column<bool>(type: "bit", nullable: false),
                    DersID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrencis", x => x.OgrenciID);
                    table.ForeignKey(
                        name: "FK_Ogrencis_Ders_DersID",
                        column: x => x.DersID,
                        principalTable: "Ders",
                        principalColumn: "DersID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ders_HocaId",
                table: "Ders",
                column: "HocaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrencis_DersID",
                table: "Ogrencis",
                column: "DersID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ogrencis");

            migrationBuilder.DropTable(
                name: "Ders");

            migrationBuilder.DropTable(
                name: "Hocas");
        }
    }
}
