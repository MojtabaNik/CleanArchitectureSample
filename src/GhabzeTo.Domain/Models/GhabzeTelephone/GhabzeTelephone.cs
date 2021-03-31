using GhabzeTo.Domain.Core;
using System;

namespace GhabzeTo.Domain.Models.GhabzeTelephone
{
    public class GhabzeTelephone : AuditableEntity<Guid>
    {
        /// <summary>
        /// شماره تلفن
        /// </summary>
        public ulong ShomareTelephone { get; set; }

        /// <summary>
        /// کد پستی
        /// </summary>
        public string CodePosti { get; set; }

        /// <summary>
        /// کافو
        /// </summary>
        public int Kafo { get; set; }

        /// <summary>
        /// پست
        /// </summary>
        public int Post { get; set; }

        /// <summary>
        /// شهرستان مرکز
        /// </summary>
        public string ShahrestanMarkaz { get; set; }

        /// <summary>
        /// نام مشترک
        /// </summary>
        public string MoshtarakName { get; set; }

        /// <summary>
        /// نوع اشتراک
        /// </summary>
        public string NoeEshterak { get; set; }

        /// <summary>
        /// دوره
        /// </summary>
        public string Dore { get; set; }

        /// <summary>
        /// از تاریخ
        /// </summary>
        public DateTime AzTarikhe { get; set; }

        /// <summary>
        /// تا تاریخ
        /// </summary>
        public DateTime TaTarikhe { get; set; }

        /// <summary>
        /// تاریخ شروع توزیع
        /// </summary>
        public DateTime TarikheShorooTozi { get; set; }

        /// <summary>
        /// نشانی
        /// </summary>
        public string Neshani { get; set; }

        /// <summary>
        /// داخل استان
        /// </summary>
        public int DakheleOstan { get; set; }

        /// <summary>
        /// خارج استان
        /// </summary>
        public int KharejeOstan { get; set; }

        /// <summary>
        /// تلفن همراه
        /// </summary>
        public int TelephoneHamrah { get; set; }

        /// <summary>
        /// بین الملل
        /// </summary>
        public int BeinolMelal { get; set; }

        /// <summary>
        /// آبونمان
        /// </summary>
        public int Abonman { get; set; }

        /// <summary>
        /// ADSL 2020
        /// </summary>
        public int ADSL2020 { get; set; }

        /// <summary>
        /// اینترنت آسان
        /// </summary>
        public int InternetAsan { get; set; }

        /// <summary>
        /// اجاره کانال
        /// </summary>
        public int EjareKanal { get; set; }

        /// <summary>
        /// معروفیت مشاغل
        /// </summary>
        public int MaroofiateMashaghel { get; set; }

        /// <summary>
        /// سایر خدمات
        /// </summary>
        public int SayereKhadamat { get; set; }

        /// <summary>
        /// تبدیلی
        /// </summary>
        public int Tabdili { get; set; }

        /// <summary>
        /// شبکه هوشمند
        /// </summary>
        public int ShabakeHooshmand { get; set; }

        /// <summary>
        /// سرویس گروه 60
        /// </summary>
        public int ServiceGoroohe60 { get; set; }

        /// <summary>
        /// بین الملل 020
        /// </summary>
        public int BeinolMelal020 { get; set; }

        /// <summary>
        /// هشت ستاره
        /// </summary>
        public int HashtSetare { get; set; }

        /// <summary>
        /// عوارض
        /// </summary>
        public int Avarez { get; set; }

        /// <summary>
        /// مالیات
        /// </summary>
        public int Maliat { get; set; }

        /// <summary>
        /// صورت حساب
        /// </summary>
        public int SooratHesabeDore { get; set; }


        /// <summary>
        /// بستانکاری
        /// </summary>
        public int Bestankari { get; set; }

        /// <summary>
        /// بدهی قبلی
        /// </summary>
        public int BedehiGhabli { get; set; }

        /// <summary>
        /// کسر 1000 ریال
        /// </summary>
        public int Kasr1000Rial { get; set; }

        /// <summary>
        /// مهلت پرداخت
        /// </summary>
        public DateTime MohlatePardakht { get; set; }

        /// <summary>
        /// شناسه قبض
        /// </summary>
        public ulong ShenaseGhabz { get; set; }

        /// <summary>
        /// شناسه پرداخت
        /// </summary>
        public ulong ShenasePardakht { get; set; }

        /// <summary>
        /// مبلغ قابل پرداخت
        /// </summary>
        public int MablagheGhabelePardakht { get; set; }

        /// <summary>
        /// وضعیت مصرف
        /// </summary>
        public string VaziatMasraf { get; set; }
    }
}
