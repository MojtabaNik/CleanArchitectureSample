using System;

namespace GhabzeTo.Application.Dtos
{
    public class SabegheMianGineMasrafInputDto
    {


        /// <summary>
        /// دوره
        /// </summary>
        public int Dore { get; set; }

        /// <summary>
        /// سال قبل
        /// </summary>
        public string SaleGhabl { get; set; }

        /// <summary>
        /// سال جاری
        /// </summary>
        public string SaleJari { get; set; }

        /// <summary>
        /// درصد افزایش یا کاهش
        /// </summary>
        public int DarsadeAfzayeshYaKahesh { get; set; }
    }
}
