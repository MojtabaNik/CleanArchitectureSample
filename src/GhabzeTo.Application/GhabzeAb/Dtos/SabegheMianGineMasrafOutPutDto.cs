using System;
using System.Collections.Generic;
using System.Text;

namespace GhabzeTo.Application.Dtos
{
    public class SabegheMianGineMasrafOutPutDto
    {
        /// <summary>
        /// شناسه سیستم
        /// </summary>
        public Guid Id { get; set; }

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

        /// <summary>
        /// شناسه سیستمی قبض
        /// </summary>
        public Guid GhabzeAbId { get; set; }
    }
}
