using GhabzeTo.Domain.Core;
using System;

namespace GhabzeTo.Domain.Models.GhabzeBargh
{
    public class GhabzeBargh : AuditableEntity<Guid>
    {
        /// <summary>
        /// مشترک محترم
        /// </summary>
        public string NameMoshtarak { get; set; }

        /// <summary>
        /// نشانی
        /// </summary>
        public string Neshani { get; set; }

        /// <summary>
        /// کد پستی
        /// </summary>
        public string CodePosti { get; set; }

        /// <summary>
        /// پرونده
        /// </summary>
        public ulong Parvande { get; set; }

        /// <summary>
        /// اشتراک
        /// </summary>
        public ulong Eshterak { get; set; }

        /// <summary>
        /// شناسایی
        /// </summary>
        public string Shenasaei { get; set; }

        /// <summary>
        /// تعداد خانوار
        /// </summary>
        public uint TedadeKhanevar { get; set; }

        /// <summary>
        /// عنوان و کد تعرفه
        /// </summary>
        public string OnvanVaCodeTarefe { get; set; }

        /// <summary>
        /// نوع فعالیت
        /// </summary>
        public string NoeFaAliat { get; set; }

        /// <summary>
        /// بدنه کنتور
        /// </summary>
        public int BadaneKontor { get; set; }

        /// <summary>
        /// فاز
        /// </summary>
        public int Faz { get; set; }

        /// <summary>
        /// آمپر
        /// </summary>
        public int Amper { get; set; }

        /// <summary>
        /// تاریخ نصب
        /// </summary>
        public DateTime TarikheNasb { get; set; }

        /// <summary>
        /// ارقام کنتور
        /// </summary>
        public ulong ArghameKontor { get; set; }

        /// <summary>
        /// تاریح انقضای پروانه
        /// </summary>
        public DateTime TarikheEnghezayeParvane { get; set; }

        /// <summary>
        /// نحوه قرائت کنتور
        /// </summary>
        public string NahveGharateKontor { get; set; }

        /// <summary>
        /// صدور صورتحساب
        /// </summary>
        public DateTime SodooreSooratHesab { get; set; }

        /// <summary>
        /// مراجعه بعدی
        /// </summary>
        public DateTime MorajeBadi { get; set; }

        /// <summary>
        /// منطقه برق
        /// </summary>
        public short MantagheBargh { get; set; }

        /// <summary>
        /// نشانی مرکز منطقه
        /// </summary>
        public string NeshaniMarkazeMantaghe { get; set; }

        /// <summary>
        /// واحد حوادث
        /// </summary>
        public uint VahedeHavadas { get; set; }

        /// <summary>
        /// پاسخگویی صورتحساب
        /// </summary>
        public uint PasokhGooeiSooratHesab { get; set; }

        /// <summary>
        /// شماره حساب
        /// </summary>
        public string ShomareHsab { get; set; }

        /// <summary>
        /// محل پرداخت
        /// </summary>
        public string MahalePardakht { get; set; }

        /// <summary>
        /// سال گذشته 1
        /// </summary>
        public int SaleGozashte1 { get; set; }

        /// <summary>
        /// سال گذشته 2
        /// </summary>
        public int SaleGozashte2 { get; set; }

        /// <summary>
        /// سال گذشته 3
        /// </summary>
        public int SaleGozashte3 { get; set; }

        /// <summary>
        /// سال گذشته 4
        /// </summary>
        public int SaleGozashte4 { get; set; }

        /// <summary>
        /// سال گذشته 5
        /// </summary>
        public int SaleGozashte5 { get; set; }

        /// <summary>
        /// سال گذشته 6
        /// </summary>
        public int SaleGozashte6 { get; set; }

        /// <summary>
        /// سال جاری 1
        /// </summary>
        public int SaleJari1 { get; set; }

        /// <summary>
        /// سال جاری 2
        /// </summary>
        public int SaleJari2 { get; set; }

        /// <summary>
        /// سال جاری 3
        /// </summary>
        public int SaleJari3 { get; set; }

        /// <summary>
        /// سال جاری 4
        /// </summary>
        public int SaleJari4 { get; set; }

        /// <summary>
        /// سال جاری 5
        /// </summary>
        public int SaleJari5 { get; set; }

        /// <summary>
        /// سال جاری 6
        /// </summary>
        public int SaleJari6 { get; set; }

        /// <summary>
        /// وضعیت پرداخت
        /// </summary>
        public string VaziatPardakht { get; set; }

        /// <summary>
        /// تاریخ قرائت کنونی
        /// </summary>
        public DateTime TarikheGharateKonooni { get; set; }

        /// <summary>
        /// میان باری کنونی
        /// </summary>
        public uint MianBariKonooni { get; set; }

        /// <summary>
        /// اوج باری کنونی
        /// </summary>
        public uint OjeBariKonooni { get; set; }

        /// <summary>
        /// کم باری کنونی
        /// </summary>
        public uint KamBariKonooni { get; set; }

        /// <summary>
        /// دوره کنونی
        /// </summary>
        public string DoreKonooni { get; set; }

        /// <summary>
        /// تاریخ قرائت پیشین
        /// </summary>
        public DateTime TarikheGharatePishin { get; set; }

        /// <summary>
        /// میان باری قرائت پیشین
        /// </summary>
        public uint MianBariGharatPishin { get; set; }

        /// <summary>
        /// اوج باری قرائت پیشین
        /// </summary>
        public uint OjeBariGharatPishin { get; set; }

        /// <summary>
        /// کم باری قرائت پیشین
        /// </summary>
        public uint KamBariGharatPishin { get; set; }


        /// <summary>
        /// مصرف میان باری
        /// </summary>
        public uint MasrafeMianBari { get; set; }

        /// <summary>
        /// مصرف اوج باری
        /// </summary>
        public uint MasrafeOjeBari { get; set; }

        /// <summary>
        /// مصرف کم باری
        /// </summary>
        public uint MasrafeKamBari { get; set; }

        /// <summary>
        /// مصرف کل دوره
        /// </summary>
        public uint MasrafeKoleDore { get; set; }

        /// <summary>
        /// متوسط مصرف 30 روزه
        /// </summary>
        public uint MotevasateMasrafe30Rooze { get; set; }

        /// <summary>
        /// تعداد روز دوره
        /// </summary>
        public uint TedadeRoozeDore { get; set; }

        /// <summary>
        /// مصرف
        /// </summary>
        public uint Masraf { get; set; }

        /// <summary>
        /// نرخ 0-100
        /// </summary>
        public uint Nerkh_0_100 { get; set; }

        /// <summary>
        /// مصرف 30 روزه 0-100
        /// </summary>
        public uint Masrafe30Rooze_0_100 { get; set; }

        /// <summary>
        /// مبلغ 0-100
        /// </summary>
        public int Mablaghe_0_100 { get; set; }

        /// <summary>
        /// نرخ 100-200
        /// </summary>
        public int Nerkh_100_200 { get; set; }

        /// <summary>
        /// مصرف 30 روزه 100-200
        /// </summary>
        public int Masrafe30Rooze_100_200 { get; set; }

        /// <summary>
        /// مبلغ 100-200
        /// </summary>
        public int Mablaghe_100_200 { get; set; }

        /// <summary>
        /// نرخ 200-300
        /// </summary>
        public int Nerkh_200_300 { get; set; }

        /// <summary>
        /// مصرف 30 روزه 200-300
        /// </summary>
        public int Masrafe30Rooze_200_300 { get; set; }

        /// <summary>
        /// مبلغ 200-300
        /// </summary>
        public int Mablaghe_200_300 { get; set; }

        /// <summary>
        /// نرخ 300-400
        /// </summary>
        public int Nerkh_300_400 { get; set; }

        /// <summary>
        /// مصرف 30 روزه 300-400
        /// </summary>
        public int Masrafe30Rooze_300_400 { get; set; }

        /// <summary>
        /// مبلغ 300-400
        /// </summary>
        public int Mablaghe_300_400 { get; set; }

        /// <summary>
        /// نرخ 400-500
        /// </summary>
        public int Nerkh_400_500 { get; set; }

        /// <summary>
        /// مصرف 30 روزه 400-500
        /// </summary>
        public int Masrafe30Rooze_400_500 { get; set; }

        /// <summary>
        /// مبلغ 400-500
        /// </summary>
        public int Mablaghe_400_500 { get; set; }

        /// <summary>
        /// نرخ 500-600
        /// </summary>
        public int Nerkh_500_600 { get; set; }

        /// <summary>
        /// مصرف 30 روزه 500-600
        /// </summary>
        public int Masrafe30Rooze_500_600 { get; set; }

        /// <summary>
        /// مبلغ 500-600
        /// </summary>
        public int Mablaghe_500_600 { get; set; }

        /// <summary>
        /// نرخ مازاد 600
        /// </summary>
        public int NerkhMazad600 { get; set; }

        /// <summary>
        /// مصرف 30 روزه مازاد 600
        /// </summary>
        public int Masrafe30RoozeMazad600 { get; set; }

        /// <summary>
        /// مبلغ مازاد 600
        /// </summary>
        public int MablagheMazad600 { get; set; }

        /// <summary>
        /// مبلغ مصرف
        /// </summary>
        public int MablagheMasraf { get; set; }

        /// <summary>
        /// اضافه هزینه مصرف اوج بار
        /// </summary>
        public int EzafeHazineMasrafeOjeBar { get; set; }

        /// <summary>
        /// تخفیف مصرف کم باری
        /// </summary>
        public int TakhfifeMasrafeKamBari { get; set; }

        /// <summary>
        /// شناسه پرداخت
        /// </summary>
        public ulong ShenasePardakht { get; set; }

        /// <summary>
        /// شناسه قبض
        /// </summary>
        public ulong ShenaseGhabz { get; set; }

        /// <summary>
        /// مهلت پرداخت
        /// </summary>
        public DateTime MohlatePardakht { get; set; }


        /// <summary>
        /// هزینه اوج بار
        /// </summary>
        public int HazineOjeBar { get; set; }

        /// <summary>
        /// تخفیف کم باری
        /// </summary>
        public int TakhfifeKamBari { get; set; }

        /// <summary>
        /// عوارض برق
        /// </summary>
        public int AvarezeBargh { get; set; }

        /// <summary>
        /// آبنمان
        /// </summary>
        public int Abonman { get; set; }

        /// <summary>
        /// پیک فصلی
        /// </summary>
        public int PikeFasli { get; set; }

        /// <summary>
        /// بیمه واحد های تجاری
        /// </summary>
        public int BimeVahedHayeTejari { get; set; }

        /// <summary>
        /// مبلغ دوره
        /// </summary>
        public int MablagheDore { get; set; }

        /// <summary>
        /// مالیات بر ارزش افزوده
        /// </summary>
        public int MaliatBarArzesheAfzoode { get; set; }

        /// <summary>
        /// بدهی قبلی
        /// </summary>
        public int BedehiGhabli { get; set; }

        /// <summary>
        /// کسر ریالی
        /// </summary>
        public int KasreRiali { get; set; }

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
