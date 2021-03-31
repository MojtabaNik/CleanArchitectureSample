using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GhabzeTo.Infra.Data.EF.Migrations
{
    public partial class AddGhabzeTelephone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GhabzeTelephone",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    ShomareTelephone = table.Column<decimal>(nullable: false),
                    CodePosti = table.Column<decimal>(nullable: false),
                    Kafo = table.Column<int>(nullable: false),
                    Post = table.Column<int>(nullable: false),
                    ShahrestanMarkaz = table.Column<string>(nullable: true),
                    MoshtarakName = table.Column<string>(nullable: true),
                    NoeEshterak = table.Column<string>(nullable: true),
                    Dore = table.Column<string>(nullable: true),
                    AzTarikhe = table.Column<DateTime>(nullable: false),
                    TaTarikhe = table.Column<DateTime>(nullable: false),
                    TarikheShorooTozi = table.Column<DateTime>(nullable: false),
                    Neshani = table.Column<string>(nullable: true),
                    DakheleOstan = table.Column<int>(nullable: false),
                    KharejeOstan = table.Column<int>(nullable: false),
                    TelephoneHamrah = table.Column<int>(nullable: false),
                    BeinolMelal = table.Column<int>(nullable: false),
                    Abonman = table.Column<int>(nullable: false),
                    ADSL2020 = table.Column<int>(nullable: false),
                    InternetAsan = table.Column<int>(nullable: false),
                    EjareKanal = table.Column<int>(nullable: false),
                    MaroofiateMashaghel = table.Column<int>(nullable: false),
                    SayereKhadamat = table.Column<int>(nullable: false),
                    Tabdili = table.Column<int>(nullable: false),
                    ShabakeHooshmand = table.Column<int>(nullable: false),
                    ServiceGoroohe60 = table.Column<int>(nullable: false),
                    BeinolMelal020 = table.Column<int>(nullable: false),
                    HashtSetare = table.Column<int>(nullable: false),
                    Avarez = table.Column<int>(nullable: false),
                    Maliat = table.Column<int>(nullable: false),
                    SooratHesabeDore = table.Column<int>(nullable: false),
                    Bestankari = table.Column<int>(nullable: false),
                    BedehiGhabli = table.Column<int>(nullable: false),
                    Kasr1000Rial = table.Column<int>(nullable: false),
                    MohlatePardakht = table.Column<DateTime>(nullable: false),
                    ShenaseGhabz = table.Column<decimal>(nullable: false),
                    ShenasePardakht = table.Column<decimal>(nullable: false),
                    MablagheGhabelePardakht = table.Column<int>(nullable: false),
                    VaziatMasraf = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GhabzeTelephone", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GhabzeTelephone");
        }
    }
}
