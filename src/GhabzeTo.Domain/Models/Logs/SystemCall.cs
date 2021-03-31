using System;
using System.Collections;
using System.Collections.Generic;
using GhabzeTo.Domain.Core;

namespace GhabzeTo.Domain.Models.Logs
{
    public class SystemCall : Entity<Guid>
    {
        public SystemCall()
        {
            Id = Guid.NewGuid();
            CreateDateTime = DateTime.Now;
        }

        public string InputWay { get; set; }
        public string InputData { get; set; }
        public string InputMetaData { get; set; }
        public string Output { get; set; }
        public DateTime CreateDateTime { get; set; }

        public virtual ICollection<SystemEventLog> SystemEventLogs { get; set; }
    }
}
