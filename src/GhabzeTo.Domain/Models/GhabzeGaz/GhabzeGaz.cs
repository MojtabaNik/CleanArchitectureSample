using GhabzeTo.Domain.Core;
using System;

namespace GhabzeTo.Domain.Models.GhabzeGaz
{
    public class GhabzeGaz : AuditableEntity<Guid>
    {
        public string NameMohstarak { get; set; }
        public string Gorooh { get; set; }
        public string NoeMasraf { get; set; }
        public string Neshani { get; set; }
        public ulong CodePosti { get; set; }
        public string ShomareEshterak { get; set; }
        public int CodeAddress { get; set; }
        public int ShomareParvande { get; set; }
        public int ShomareSeri { get; set; }
        public int Zarfiat { get; set; }
        public int ShomareSerialKontor { get; set; }
        public DateTime TarikheNasbeKontor { get; set; }
        public int TedadeVahed { get; set; }
        public DateTime TarikheGheratPishin { get; set; }
        public DateTime TarikheGherateFeli { get; set; }
        public int RaghamePishineKontor { get; set; }
        public int RaghameFeliKontor { get; set; }
        public int KarKerdeKontor { get; set; }
        public int TedadeRoozhayeDore { get; set; }
        public string EshterakeGhadim { get; set; }
        public int BahayeGazeMasrafi { get; set; }
        public int AvarezVaMaliyat { get; set; }
        public int HazineKhadamteMostamar { get; set; }
        public int BedehiMotefareghe { get; set; }
        public int BedehiPishin { get; set; }
        public int TalabePishin { get; set; }
        public int AvarezeTosee { get; set; }
        public int Bime { get; set; }
        public int MandeBedehi { get; set; }
        public int Mande1000Rial { get; set; }
        public int Kasre1000Rial { get; set; }
        public int TedadeBedehi { get; set; }
        public int MablagheGhabelePardakht { get; set; }
        public DateTime MohlatePardakht { get; set; }
        public ulong ShenasePardakht { get; set; }
        public ulong ShenaseGhabz { get; set; }
        public string MablaghBeHoroof { get; set; }
        public string VaziateMasraf { get; set; }
    }
}
