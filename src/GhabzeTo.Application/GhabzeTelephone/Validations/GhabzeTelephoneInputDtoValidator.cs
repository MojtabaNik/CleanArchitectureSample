using FluentValidation;
using GhabzeTo.Application.DTOs;
using GhabzeTo.Infra.Resources.Validations;

namespace GhabzeTo.Application.Validations
{
    public class GhabzeTelephoneInputDtoValidator : AbstractValidator<GhabzeTelephoneInputDto>
    {
        public GhabzeTelephoneInputDtoValidator()
        {
            RuleFor(item => item.ShomareTelephone);
		RuleFor(item => item.CodePosti);
		RuleFor(item => item.Kafo);
		RuleFor(item => item.Post);
		RuleFor(item => item.ShahrestanMarkaz);
		RuleFor(item => item.MoshtarakName);
		RuleFor(item => item.NoeEshterak);
		RuleFor(item => item.Dore);
		RuleFor(item => item.AzTarikhe);
		RuleFor(item => item.TaTarikhe);
		RuleFor(item => item.TarikheShorooTozi);
		RuleFor(item => item.Neshani);
		RuleFor(item => item.DakheleOstan);
		RuleFor(item => item.KharejeOstan);
		RuleFor(item => item.TelephoneHamrah);
		RuleFor(item => item.BeinolMelal);
		RuleFor(item => item.Abonman);
		RuleFor(item => item.ADSL2020);
		RuleFor(item => item.InternetAsan);
		RuleFor(item => item.EjareKanal);
		RuleFor(item => item.MaroofiateMashaghel);
		RuleFor(item => item.SayereKhadamat);
		RuleFor(item => item.Tabdili);
		RuleFor(item => item.ShabakeHooshmand);
		RuleFor(item => item.ServiceGoroohe60);
		RuleFor(item => item.BeinolMelal020);
		RuleFor(item => item.HashtSetare);
		RuleFor(item => item.Avarez);
		RuleFor(item => item.Maliat);
		RuleFor(item => item.SooratHesabeDore);
		RuleFor(item => item.Bestankari);
		RuleFor(item => item.BedehiGhabli);
		RuleFor(item => item.Kasr1000Rial);
		RuleFor(item => item.MohlatePardakht);
		RuleFor(item => item.ShenaseGhabz);
		RuleFor(item => item.ShenasePardakht);
		RuleFor(item => item.MablagheGhabelePardakht);
		RuleFor(item => item.VaziatMasraf);
        }
    }
}
