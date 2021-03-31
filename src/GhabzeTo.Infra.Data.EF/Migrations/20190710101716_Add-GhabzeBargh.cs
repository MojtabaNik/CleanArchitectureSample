using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GhabzeTo.Infra.Data.EF.Migrations
{
    public partial class AddGhabzeBargh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Test");

            migrationBuilder.CreateTable(
                name: "GhabzeBargh",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    NameMoshtarak = table.Column<string>(nullable: true),
                    Neshani = table.Column<string>(nullable: true),
                    CodePosti = table.Column<decimal>(nullable: false),
                    Parvande = table.Column<decimal>(nullable: false),
                    Eshterak = table.Column<decimal>(nullable: false),
                    Shenasaei = table.Column<string>(nullable: true),
                    TedadeKhanevar = table.Column<long>(nullable: false),
                    OnvanVaCodeTarefe = table.Column<string>(nullable: true),
                    NoeFaAliat = table.Column<string>(nullable: true),
                    BadaneKontor = table.Column<int>(nullable: false),
                    Faz = table.Column<int>(nullable: false),
                    Amper = table.Column<int>(nullable: false),
                    TarikheNasb = table.Column<DateTime>(nullable: false),
                    ArghameKontor = table.Column<decimal>(nullable: false),
                    TarikheEnghezayeParvane = table.Column<DateTime>(nullable: false),
                    NahveGharateKontor = table.Column<string>(nullable: true),
                    SodooreSooratHesab = table.Column<DateTime>(nullable: false),
                    MorajeBadi = table.Column<DateTime>(nullable: false),
                    MantagheBargh = table.Column<short>(nullable: false),
                    NeshaniMarkazeMantaghe = table.Column<string>(nullable: true),
                    VahedeHavadas = table.Column<long>(nullable: false),
                    PasokhGooeiSooratHesab = table.Column<long>(nullable: false),
                    ShomareHsab = table.Column<string>(nullable: true),
                    MahalePardakht = table.Column<string>(nullable: true),
                    SaleGozashte1 = table.Column<int>(nullable: false),
                    SaleGozashte2 = table.Column<int>(nullable: false),
                    SaleGozashte3 = table.Column<int>(nullable: false),
                    SaleGozashte4 = table.Column<int>(nullable: false),
                    SaleGozashte5 = table.Column<int>(nullable: false),
                    SaleGozashte6 = table.Column<int>(nullable: false),
                    SaleJari1 = table.Column<int>(nullable: false),
                    SaleJari2 = table.Column<int>(nullable: false),
                    SaleJari3 = table.Column<int>(nullable: false),
                    SaleJari4 = table.Column<int>(nullable: false),
                    SaleJari5 = table.Column<int>(nullable: false),
                    SaleJari6 = table.Column<int>(nullable: false),
                    VaziatPardakht = table.Column<string>(nullable: true),
                    TarikheGharateKonooni = table.Column<DateTime>(nullable: false),
                    MianBariKonooni = table.Column<long>(nullable: false),
                    OjeBariKonooni = table.Column<long>(nullable: false),
                    KamBariKonooni = table.Column<long>(nullable: false),
                    DoreKonooni = table.Column<string>(nullable: true),
                    TarikheGharatePishin = table.Column<DateTime>(nullable: false),
                    MianBariGharatPishin = table.Column<long>(nullable: false),
                    OjeBariGharatPishin = table.Column<long>(nullable: false),
                    KamBariGharatPishin = table.Column<long>(nullable: false),
                    MasrafeMianBari = table.Column<long>(nullable: false),
                    MasrafeOjeBari = table.Column<long>(nullable: false),
                    MasrafeKamBari = table.Column<long>(nullable: false),
                    MasrafeKoleDore = table.Column<long>(nullable: false),
                    MotevasateMasrafe30Rooze = table.Column<long>(nullable: false),
                    TedadeRoozeDore = table.Column<long>(nullable: false),
                    Masraf = table.Column<long>(nullable: false),
                    Nerkh_0_100 = table.Column<long>(nullable: false),
                    Masrafe30Rooze_0_100 = table.Column<long>(nullable: false),
                    Mablaghe_0_100 = table.Column<decimal>(nullable: false),
                    Nerkh_100_200 = table.Column<decimal>(nullable: false),
                    Masrafe30Rooze_100_200 = table.Column<decimal>(nullable: false),
                    Mablaghe_100_200 = table.Column<decimal>(nullable: false),
                    Nerkh_200_300 = table.Column<decimal>(nullable: false),
                    Masrafe30Rooze_200_300 = table.Column<decimal>(nullable: false),
                    Mablaghe_200_300 = table.Column<decimal>(nullable: false),
                    Nerkh_300_400 = table.Column<decimal>(nullable: false),
                    Masrafe30Rooze_300_400 = table.Column<decimal>(nullable: false),
                    Mablaghe_300_400 = table.Column<decimal>(nullable: false),
                    Nerkh_400_500 = table.Column<decimal>(nullable: false),
                    Masrafe30Rooze_400_500 = table.Column<decimal>(nullable: false),
                    Mablaghe_400_500 = table.Column<decimal>(nullable: false),
                    Nerkh_500_600 = table.Column<decimal>(nullable: false),
                    Masrafe30Rooze_500_600 = table.Column<decimal>(nullable: false),
                    Mablaghe_500_600 = table.Column<decimal>(nullable: false),
                    NerkhMazad600 = table.Column<decimal>(nullable: false),
                    Masrafe30RoozeMazad600 = table.Column<decimal>(nullable: false),
                    MablagheMazad600 = table.Column<decimal>(nullable: false),
                    MablagheMasraf = table.Column<decimal>(nullable: false),
                    EzafeHazineMasrafeOjeBar = table.Column<decimal>(nullable: false),
                    TakhfifeMasrafeKamBari = table.Column<decimal>(nullable: false),
                    ShenasePardakht = table.Column<decimal>(nullable: false),
                    ShenaseGhabz = table.Column<decimal>(nullable: false),
                    MohlatePardakht = table.Column<DateTime>(nullable: false),
                    HazineOjeBar = table.Column<decimal>(nullable: false),
                    TakhfifeKamBari = table.Column<decimal>(nullable: false),
                    AvarezeBargh = table.Column<decimal>(nullable: false),
                    Abonman = table.Column<decimal>(nullable: false),
                    PikeFasli = table.Column<decimal>(nullable: false),
                    BimeVahedHayeTejari = table.Column<decimal>(nullable: false),
                    MablagheDore = table.Column<decimal>(nullable: false),
                    MaliatBarArzesheAfzoode = table.Column<decimal>(nullable: false),
                    BedehiGhabli = table.Column<decimal>(nullable: false),
                    KasreRiali = table.Column<decimal>(nullable: false),
                    MablagheGhabelePardakht = table.Column<decimal>(nullable: false),
                    VaziatMasraf = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GhabzeBargh", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GhabzeBargh");

            migrationBuilder.CreateTable(
                name: "Test",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Family = table.Column<string>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test", x => x.Id);
                });
        }
    }
}
