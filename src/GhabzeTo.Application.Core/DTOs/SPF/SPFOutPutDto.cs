using System.Collections.Generic;

namespace GhabzeTo.Application.Core.DTOs.SPF
{
    public class SPFOutPutDto<T>
    {
        public long TotalRecord { get; set; }
        public long ShowRecord { get; set; }
        public IList<T> ResultList { get; set; } = new List<T>();
    }
}
