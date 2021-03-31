namespace GhabzeTo.Application.Core.DTOs.SPF
{
    public class SPFInputDto
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public string SortColumnName { get; set; }
        public SortType SortType { get; set; }
        public string SearchTerm { get; set; }
    }


    public enum SortType : short
    {
        Asc = 10,
        Desc = 20
    }
}
