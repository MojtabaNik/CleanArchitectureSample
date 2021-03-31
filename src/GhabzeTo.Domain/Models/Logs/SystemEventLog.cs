using System;
using System.Collections.Generic;
using System.Text;
using GhabzeTo.Domain.Core;

namespace GhabzeTo.Domain.Models.Logs
{
    public class SystemEventLog : Entity<Guid>
    {
        public SystemEventLog()
        {
            Id = Guid.NewGuid();
        }

        public string FirstCallerInfo { get; set; }
        public string Info { get; set; }
        public string Data { get; set; }
        public DateTime CreateDateTime { get; set; }
        public SystemEventLogType SystemEventLogType { get; set; }

        public Guid SystemCallId { get; set; }
        public virtual SystemCall SystemCall { get; set; }
    }

    public enum SystemEventLogType
    {
        Info,
        Warn,
        Error
    }
}
