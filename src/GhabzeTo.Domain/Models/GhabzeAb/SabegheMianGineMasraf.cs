using GhabzeTo.Domain.Core;
using System;

namespace GhabzeTo.Domain.Models.GhabzeAb
{
    /// <summary>
    /// سابقه میانگین مصرف
    /// </summary>
    public class SabegheMianGineMasraf : AuditableEntity<Guid>
    {
        #region Ctor
        public SabegheMianGineMasraf()
        {
            this.Id = Guid.NewGuid();
        }
        #endregion

        #region Props
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
        #endregion

        #region relations
        public Guid GhabzeAbId { get; set; }
        public virtual GhabzeAb GhabzeAb { get; set; }
        #endregion
    }
}
