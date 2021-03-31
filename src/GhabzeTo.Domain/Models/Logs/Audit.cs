using System;
using GhabzeTo.Domain.Core;

namespace GhabzeTo.Domain.Models.Logs
{
    public class Audit : Entity<Guid>
    {
        public Audit()
        {
            this.Id = Guid.NewGuid();
        }

        public string TableName { get; set; }
        public DateTime DateTime { get; set; }
        public string KeyValues { get; set; }
        public string OldValues { get; set; }
        public string NewValues { get; set; }
    }
}
