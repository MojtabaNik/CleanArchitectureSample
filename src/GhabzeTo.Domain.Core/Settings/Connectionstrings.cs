namespace GhabzeTo.Domain.Core.Settings
{
    public class Connectionstrings
    {
        public SqlServer SqlServer { get; set; }
        public Localdb LocalDb { get; set; }
        public PostgreSQL PostgreSQL { get; set; }
    }
}