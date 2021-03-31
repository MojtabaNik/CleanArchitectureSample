using FluentValidation;
using GhabzeTo.Application.DTOs;
using GhabzeTo.Infra.Resources.Validations;

namespace GhabzeTo.Application.Validations
{
    public class GhabzeGazInputDtoValidator : AbstractValidator<GhabzeGazInputDto>
    {
        public GhabzeGazInputDtoValidator()
        {
            RuleFor(item => item.NameMohstarak);
		RuleFor(item => item.Gorooh);
		RuleFor(item => item.NoeMasraf);
		RuleFor(item => item.Neshani);
		RuleFor(item => item.CodePosti);
		RuleFor(item => item.ShomareEshterak);
		RuleFor(item => item.CodeAddress);
		RuleFor(item => item.ShomareParvande);
		RuleFor(item => item.ShomareSeri);
		RuleFor(item => item.Zarfiat);
		RuleFor(item => item.ShomareSerialKontor);
		RuleFor(item => item.TarikheNasbeKontor);
		RuleFor(item => item.TedadeVahed);
		RuleFor(item => item.TarikheGheratPishin);
		RuleFor(item => item.TarikheGherateFeli);
		RuleFor(item => item.RaghamePishineKontor);
		RuleFor(item => item.RaghameFeliKontor);
		RuleFor(item => item.KarKerdeKontor);
		RuleFor(item => item.TedadeRoozhayeDore);
		RuleFor(item => item.EshterakeGhadim);
		RuleFor(item => item.BahayeGazeMasrafi);
		RuleFor(item => item.AvarezVaMaliyat);
		RuleFor(item => item.HazineKhadamteMostamar);
		RuleFor(item => item.BedehiMotefareghe);
		RuleFor(item => item.BedehiPishin);
		RuleFor(item => item.TalabePishin);
		RuleFor(item => item.AvarezeTosee);
		RuleFor(item => item.Bime);
		RuleFor(item => item.MandeBedehi);
		RuleFor(item => item.Mande1000Rial);
		RuleFor(item => item.Kasre1000Rial);
		RuleFor(item => item.TedadeBedehi);
		RuleFor(item => item.MablagheGhabelePardakht);
		RuleFor(item => item.MohlatePardakht);
		RuleFor(item => item.ShenasePardakht);
		RuleFor(item => item.ShenaseGhabz);
		RuleFor(item => item.MablaghBeHoroof);
		RuleFor(item => item.VaziateMasraf);
        }
    }
}
