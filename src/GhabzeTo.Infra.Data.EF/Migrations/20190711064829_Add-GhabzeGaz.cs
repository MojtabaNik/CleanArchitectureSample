using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GhabzeTo.Infra.Data.EF.Migrations
{
    public partial class AddGhabzeGaz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GhabzeGaz",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    NameMohstarak = table.Column<string>(nullable: true),
                    Gorooh = table.Column<string>(nullable: true),
                    NoeMasraf = table.Column<string>(nullable: true),
                    Neshani = table.Column<string>(nullable: true),
                    CodePosti = table.Column<decimal>(nullable: false),
                    ShomareEshterak = table.Column<string>(nullable: true),
                    CodeAddress = table.Column<int>(nullable: false),
                    ShomareParvande = table.Column<int>(nullable: false),
                    ShomareSeri = table.Column<int>(nullable: false),
                    Zarfiat = table.Column<int>(nullable: false),
                    ShomareSerialKontor = table.Column<int>(nullable: false),
                    TarikheNasbeKontor = table.Column<DateTime>(nullable: false),
                    TedadeVahed = table.Column<int>(nullable: false),
                    TarikheGheratPishin = table.Column<DateTime>(nullable: false),
                    TarikheGherateFeli = table.Column<DateTime>(nullable: false),
                    RaghamePishineKontor = table.Column<int>(nullable: false),
                    RaghameFeliKontor = table.Column<int>(nullable: false),
                    KarKerdeKontor = table.Column<int>(nullable: false),
                    TedadeRoozhayeDore = table.Column<int>(nullable: false),
                    EshterakeGhadim = table.Column<string>(nullable: true),
                    BahayeGazeMasrafi = table.Column<int>(nullable: false),
                    AvarezVaMaliyat = table.Column<int>(nullable: false),
                    HazineKhadamteMostamar = table.Column<int>(nullable: false),
                    BedehiMotefareghe = table.Column<int>(nullable: false),
                    BedehiPishin = table.Column<int>(nullable: false),
                    TalabePishin = table.Column<int>(nullable: false),
                    AvarezeTosee = table.Column<int>(nullable: false),
                    Bime = table.Column<int>(nullable: false),
                    MandeBedehi = table.Column<int>(nullable: false),
                    Mande1000Rial = table.Column<int>(nullable: false),
                    Kasre1000Rial = table.Column<int>(nullable: false),
                    TedadeBedehi = table.Column<int>(nullable: false),
                    MablagheGhabelePardakht = table.Column<int>(nullable: false),
                    MohlatePardakht = table.Column<DateTime>(nullable: false),
                    ShenasePardakht = table.Column<decimal>(nullable: false),
                    ShenaseGhabz = table.Column<decimal>(nullable: false),
                    MablaghBeHoroof = table.Column<string>(nullable: true),
                    VaziateMasraf = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GhabzeGaz", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GhabzeGaz");
        }
    }
}
