using System.Collections.Generic;

namespace GhabzeTo.Application.Core.DTOs.BatchInsert
{
    public class BatchInsertResponseModel<T>
    {
        public T Item { get; set; }
        public bool Result { get; set; }
        public object Message { get; set; }
    }
}
