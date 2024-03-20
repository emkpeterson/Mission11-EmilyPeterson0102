namespace Mission11_EmilyPeterson.Models.ViewModels
{
    public class PaginationBooks
    {

        public int totalItems { get; set; }
        public int itemsPerPage { get; set; }
        public int currentPage { get; set; }
        public int totalPages => (int) (Math.Ceiling((decimal) totalItems / itemsPerPage));
    }
}
