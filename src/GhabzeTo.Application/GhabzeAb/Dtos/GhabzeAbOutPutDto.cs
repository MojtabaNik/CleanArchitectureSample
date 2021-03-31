using System;
using System.Collections.Generic;

namespace GhabzeTo.Application.Dtos
{
    public class GhabzeAbOutPutDto
    {
        /// <summary>
        /// شناسه سیستم
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// نام مشترک
        /// </summary>
        public string NameMoshtarak { get; set; }

        /// <summary>
        /// قرارداد
        /// </summary>
        public long Gharardad { get; set; }

        /// <summary>
        /// تعرفه
        /// </summary>
        public string Tarefe { get; set; }

        /// <summary>
        /// نشانی
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// کد پستی
        /// </summary>
        public string CodePosti { get; set; }

        /// <summary>
        /// شناسایی
        /// </summary>
        public string Shenasaei { get; set; }

        /// <summary>
        /// شناسه قبض
        /// </summary>
        public ulong ShenaseGhabz { get; set; }

        /// <summary>
        /// شناسه پرداخت
        /// </summary>
        public ulong ShenasePardakht { get; set; }

        /// <summary>
        /// منطقه
        /// </summary>
        public int Mantaghe { get; set; }

        /// <summary>
        /// سریال کنتر
        /// </summary>
        public int SerialeKontor { get; set; }

        /// <summary>
        /// مهلت پرداخت
        /// </summary>
        public DateTime MohlatePardakht { get; set; }

        /// <summary>
        /// شماره قبض
        /// </summary>
        public string ShomareGhabz { get; set; }

        /// <summary>
        /// جمع دوره
        /// </summary>
        public int JameDore { get; set; }

        /// <summary>
        /// جمع کل
        /// </summary>
        public int JameKol { get; set; }

        /// <summary>
        /// تعداد واحد
        /// </summary>
        public int TedadeVahed { get; set; }

        /// <summary>
        /// تعداد خانوار
        /// </summary>
        public int TedadeKhanevar { get; set; }

        /// <summary>
        /// قطر انشعاب آب
        /// </summary>
        public double GhotreEnsheab { get; set; }

        /// <summary>
        /// قطر انشعاب فاضلاب
        /// </summary>
        public double GhotreEnsheabeFazelab { get; set; }

        /// <summary>
        /// ظرفیت قراردادی
        /// </summary>
        public int ZarfiatGharardadi { get; set; }

        /// <summary>
        /// تعداد دوره بدهی
        /// </summary>
        public int TedadeDoreBedehi { get; set; }

        /// <summary>
        /// تاریخ صدور
        /// </summary>
        public DateTime TarikheSodoor { get; set; }

        /// <summary>
        /// تاریخ فعلی
        /// </summary>
        public DateTime TarikheFeli { get; set; }

        /// <summary>
        /// تاریخ قبلی
        /// </summary>
        public DateTime TarikheGhabli { get; set; }

        /// <summary>
        /// کنتور فعلی
        /// </summary>
        public int KontoreFeli { get; set; }

        /// <summary>
        /// کنتور قبلی
        /// </summary>
        public int KontoreGhabli { get; set; }

        /// <summary>
        /// مصرف کل
        /// </summary>
        public int MasrafeKol { get; set; }

        /// <summary>
        /// مصرف متوسط
        /// </summary>
        public int MasrafeMotevaset { get; set; }

        /// <summary>
        /// مصرف اشتراکی
        /// </summary>
        public int MasrafeEshteraki { get; set; }

        /// <summary>
        /// تعداد روز دوره
        /// </summary>
        public int TedadeRoozeDore { get; set; }

        /// <summary>
        /// بهای آب مصرفی
        /// </summary>
        public int BahayeAbeMasrafi { get; set; }

        /// <summary>
        /// آبونمان آب
        /// </summary>
        public int AboonmaneAb { get; set; }

        /// <summary>
        /// بهای خدمات دفع فاضلاب
        /// </summary>
        public int BahayeKhadamateDafeFazelab { get; set; }

        /// <summary>
        /// آبونمان فاضلاب
        /// </summary>
        public int AboonmaneFazelab { get; set; }

        /// <summary>
        /// مالیات بر ارزش افزوده
        /// </summary>
        public int MaliatBarArzesheAfzoode { get; set; }

        /// <summary>
        /// تکالیف قانون بودجه
        /// </summary>
        public int TakalifeGhanooneBoodje { get; set; }

        /// <summary>
        /// هزینه قرائت و تفکیک قبض
        /// </summary>
        public int HazineGharatVaTafkikeGhabz { get; set; }

        /// <summary>
        /// جمع هزینه
        /// </summary>
        public int JameHazine { get; set; }

        /// <summary>
        /// بدهی/طلب
        /// </summary>
        public int BedehiTalab { get; set; }

        /// <summary>
        /// کسر 1000 ریال
        /// </summary>
        public int Kasre1000Rial { get; set; }

        /// <summary>
        /// وضعیت مصرف
        /// </summary>
        public string VaziateMasraf { get; set; }

        /// <summary>
        /// سابقه میانگین مصرف
        /// </summary>
        public List<SabegheMianGineMasrafOutPutDto> SabegheMianGineMasrafs { get; set; }
    }
}
