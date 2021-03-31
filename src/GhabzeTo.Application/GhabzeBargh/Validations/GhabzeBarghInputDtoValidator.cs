using FluentValidation;
using GhabzeTo.Application.DTOs;
using GhabzeTo.Infra.Resources.Validations;

namespace GhabzeTo.Application.Validations
{
    public class GhabzeBarghInputDtoValidator : AbstractValidator<GhabzeBarghInputDto>
    {
        public GhabzeBarghInputDtoValidator()
        {
            RuleFor(item => item.NameMoshtarak);
            RuleFor(item => item.Neshani);
            RuleFor(item => item.CodePosti);
            RuleFor(item => item.Parvande);
            RuleFor(item => item.Eshterak);
            RuleFor(item => item.Shenasaei);
            RuleFor(item => item.TedadeKhanevar);
            RuleFor(item => item.OnvanVaCodeTarefe);
            RuleFor(item => item.NoeFaAliat);
            RuleFor(item => item.BadaneKontor);
            RuleFor(item => item.Faz);
            RuleFor(item => item.Amper);
            RuleFor(item => item.TarikheNasb);
            RuleFor(item => item.ArghameKontor);
            RuleFor(item => item.TarikheEnghezayeParvane);
            RuleFor(item => item.NahveGharateKontor);
            RuleFor(item => item.SodooreSooratHesab);
            RuleFor(item => item.MorajeBadi);
            RuleFor(item => item.MantagheBargh);
            RuleFor(item => item.NeshaniMarkazeMantaghe);
            RuleFor(item => item.VahedeHavadas);
            RuleFor(item => item.PasokhGooeiSooratHesab);
            RuleFor(item => item.ShomareHsab);
            RuleFor(item => item.MahalePardakht);
            RuleFor(item => item.SaleGozashte1);
            RuleFor(item => item.SaleGozashte2);
            RuleFor(item => item.SaleGozashte3);
            RuleFor(item => item.SaleGozashte4);
            RuleFor(item => item.SaleGozashte5);
            RuleFor(item => item.SaleGozashte6);
            RuleFor(item => item.SaleJari1);
            RuleFor(item => item.SaleJari2);
            RuleFor(item => item.SaleJari3);
            RuleFor(item => item.SaleJari4);
            RuleFor(item => item.SaleJari5);
            RuleFor(item => item.SaleJari6);
            RuleFor(item => item.VaziatPardakht);
            RuleFor(item => item.TarikheGharateKonooni);
            RuleFor(item => item.MianBariKonooni);
            RuleFor(item => item.OjeBariKonooni);
            RuleFor(item => item.KamBariKonooni);
            RuleFor(item => item.DoreKonooni);
            RuleFor(item => item.TarikheGharatePishin);
            RuleFor(item => item.MianBariGharatPishin);
            RuleFor(item => item.OjeBariGharatPishin);
            RuleFor(item => item.KamBariGharatPishin);
            RuleFor(item => item.MasrafeMianBari);
            RuleFor(item => item.MasrafeOjeBari);
            RuleFor(item => item.MasrafeKamBari);
            RuleFor(item => item.MasrafeKoleDore);
            RuleFor(item => item.MotevasateMasrafe30Rooze);
            RuleFor(item => item.TedadeRoozeDore);
            RuleFor(item => item.Masraf);
            RuleFor(item => item.Nerkh_0_100);
            RuleFor(item => item.Masrafe30Rooze_0_100);
            RuleFor(item => item.Mablaghe_0_100);
            RuleFor(item => item.Nerkh_100_200);
            RuleFor(item => item.Masrafe30Rooze_100_200);
            RuleFor(item => item.Mablaghe_100_200);
            RuleFor(item => item.Nerkh_200_300);
            RuleFor(item => item.Masrafe30Rooze_200_300);
            RuleFor(item => item.Mablaghe_200_300);
            RuleFor(item => item.Nerkh_300_400);
            RuleFor(item => item.Masrafe30Rooze_300_400);
            RuleFor(item => item.Mablaghe_300_400);
            RuleFor(item => item.Nerkh_400_500);
            RuleFor(item => item.Masrafe30Rooze_400_500);
            RuleFor(item => item.Mablaghe_400_500);
            RuleFor(item => item.Nerkh_500_600);
            RuleFor(item => item.Masrafe30Rooze_500_600);
            RuleFor(item => item.Mablaghe_500_600);
            RuleFor(item => item.NerkhMazad600);
            RuleFor(item => item.Masrafe30RoozeMazad600);
            RuleFor(item => item.MablagheMazad600);
            RuleFor(item => item.MablagheMasraf);
            RuleFor(item => item.EzafeHazineMasrafeOjeBar);
            RuleFor(item => item.TakhfifeMasrafeKamBari);

            RuleFor(item => item.ShenasePardakht).Must(x => x > 0)
                .WithMessage(ValidationResourceKeys.NotNull);

            RuleFor(item => item.ShenaseGhabz).Must(x => x > 0)
                .WithMessage(ValidationResourceKeys.NotNull);

            RuleFor(item => item.MohlatePardakht);
            RuleFor(item => item.HazineOjeBar);
            RuleFor(item => item.TakhfifeKamBari);
            RuleFor(item => item.AvarezeBargh);
            RuleFor(item => item.Abonman);
            RuleFor(item => item.PikeFasli);
            RuleFor(item => item.BimeVahedHayeTejari);
            RuleFor(item => item.MablagheDore);
            RuleFor(item => item.MaliatBarArzesheAfzoode);
            RuleFor(item => item.BedehiGhabli);
            RuleFor(item => item.KasreRiali);
            RuleFor(item => item.MablagheGhabelePardakht);
            RuleFor(item => item.VaziatMasraf);
        }
    }
}
