using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GhabzeTo.Infra.Data.EF.Migrations
{
    public partial class AddGhabzeAb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GhabzeAb",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    NameMoshtarak = table.Column<string>(nullable: true),
                    Gharardad = table.Column<long>(nullable: false),
                    Tarefe = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    CodePosti = table.Column<string>(nullable: true),
                    Shenasaei = table.Column<string>(nullable: true),
                    ShenaseGhabz = table.Column<decimal>(nullable: false),
                    ShenasePardakht = table.Column<decimal>(nullable: false),
                    Mantaghe = table.Column<int>(nullable: false),
                    SerialeKontor = table.Column<int>(nullable: false),
                    MohlatePardakht = table.Column<DateTime>(nullable: false),
                    ShomareGhabz = table.Column<string>(nullable: true),
                    JameDore = table.Column<int>(nullable: false),
                    JameKol = table.Column<int>(nullable: false),
                    TedadeVahed = table.Column<int>(nullable: false),
                    TedadeKhanevar = table.Column<int>(nullable: false),
                    GhotreEnsheab = table.Column<double>(nullable: false),
                    GhotreEnsheabeFazelab = table.Column<double>(nullable: false),
                    ZarfiatGharardadi = table.Column<int>(nullable: false),
                    TedadeDoreBedehi = table.Column<int>(nullable: false),
                    TarikheSodoor = table.Column<DateTime>(nullable: false),
                    TarikheFeli = table.Column<DateTime>(nullable: false),
                    TarikheGhabli = table.Column<DateTime>(nullable: false),
                    KontoreFeli = table.Column<int>(nullable: false),
                    KontoreGhabli = table.Column<int>(nullable: false),
                    MasrafeKol = table.Column<int>(nullable: false),
                    MasrafeMotevaset = table.Column<int>(nullable: false),
                    MasrafeEshteraki = table.Column<int>(nullable: false),
                    TedadeRoozeDore = table.Column<int>(nullable: false),
                    BahayeAbeMasrafi = table.Column<int>(nullable: false),
                    AboonmaneAb = table.Column<int>(nullable: false),
                    BahayeKhadamateDafeFazelab = table.Column<int>(nullable: false),
                    AboonmaneFazelab = table.Column<int>(nullable: false),
                    MaliatBarArzesheAfzoode = table.Column<int>(nullable: false),
                    TakalifeGhanooneBoodje = table.Column<int>(nullable: false),
                    HazineGharatVaTafkikeGhabz = table.Column<int>(nullable: false),
                    JameHazine = table.Column<int>(nullable: false),
                    BedehiTalab = table.Column<int>(nullable: false),
                    Kasre1000Rial = table.Column<int>(nullable: false),
                    VaziateMasraf = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GhabzeAb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SabegheMianGineMasraf",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Dore = table.Column<int>(nullable: false),
                    SaleGhabl = table.Column<string>(nullable: true),
                    SaleJari = table.Column<string>(nullable: true),
                    DarsadeAfzayeshYaKahesh = table.Column<int>(nullable: false),
                    GhabzeAbId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SabegheMianGineMasraf", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SabegheMianGineMasraf_GhabzeAb_GhabzeAbId",
                        column: x => x.GhabzeAbId,
                        principalTable: "GhabzeAb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SabegheMianGineMasraf_GhabzeAbId",
                table: "SabegheMianGineMasraf",
                column: "GhabzeAbId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SabegheMianGineMasraf");

            migrationBuilder.DropTable(
                name: "GhabzeAb");
        }
    }
}
