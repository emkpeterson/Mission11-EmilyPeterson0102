namespace Mission11_EmilyPeterson.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
