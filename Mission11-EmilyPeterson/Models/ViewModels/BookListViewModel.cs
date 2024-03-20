namespace Mission11_EmilyPeterson.Models.ViewModels
{
    public class BookListViewModel
    {

        public IQueryable<Book> Books { get; set; }

        public PaginationBooks PaginationBooks { get; set; } = new PaginationBooks();
    }
}
