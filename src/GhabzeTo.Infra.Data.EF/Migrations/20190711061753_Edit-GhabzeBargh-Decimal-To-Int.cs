using Microsoft.EntityFrameworkCore.Migrations;

namespace GhabzeTo.Infra.Data.EF.Migrations
{
    public partial class EditGhabzeBarghDecimalToInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TakhfifeMasrafeKamBari",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "TakhfifeKamBari",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "PikeFasli",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "Nerkh_500_600",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "Nerkh_400_500",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "Nerkh_300_400",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "Nerkh_200_300",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "Nerkh_100_200",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "NerkhMazad600",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "Masrafe30Rooze_500_600",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "Masrafe30Rooze_400_500",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "Masrafe30Rooze_300_400",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "Masrafe30Rooze_200_300",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "Masrafe30Rooze_100_200",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "Masrafe30RoozeMazad600",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "MaliatBarArzesheAfzoode",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "Mablaghe_500_600",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "Mablaghe_400_500",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "Mablaghe_300_400",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "Mablaghe_200_300",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "Mablaghe_100_200",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "Mablaghe_0_100",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "MablagheMazad600",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "MablagheMasraf",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "MablagheGhabelePardakht",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "MablagheDore",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "KasreRiali",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "HazineOjeBar",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "EzafeHazineMasrafeOjeBar",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "BimeVahedHayeTejari",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "BedehiGhabli",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "AvarezeBargh",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "Abonman",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(decimal));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TakhfifeMasrafeKamBari",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "TakhfifeKamBari",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "PikeFasli",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "Nerkh_500_600",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "Nerkh_400_500",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "Nerkh_300_400",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "Nerkh_200_300",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "Nerkh_100_200",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "NerkhMazad600",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "Masrafe30Rooze_500_600",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "Masrafe30Rooze_400_500",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "Masrafe30Rooze_300_400",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "Masrafe30Rooze_200_300",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "Masrafe30Rooze_100_200",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "Masrafe30RoozeMazad600",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "MaliatBarArzesheAfzoode",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "Mablaghe_500_600",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "Mablaghe_400_500",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "Mablaghe_300_400",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "Mablaghe_200_300",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "Mablaghe_100_200",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "Mablaghe_0_100",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "MablagheMazad600",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "MablagheMasraf",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "MablagheGhabelePardakht",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "MablagheDore",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "KasreRiali",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "HazineOjeBar",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "EzafeHazineMasrafeOjeBar",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "BimeVahedHayeTejari",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "BedehiGhabli",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "AvarezeBargh",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "Abonman",
                table: "GhabzeBargh",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
