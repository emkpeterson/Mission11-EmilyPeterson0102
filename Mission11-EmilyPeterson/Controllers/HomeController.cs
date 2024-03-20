using Microsoft.AspNetCore.Mvc;
using Mission11_EmilyPeterson.Models;
using Mission11_EmilyPeterson.Models.ViewModels;
using System.Diagnostics;

namespace Mission11_EmilyPeterson.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _repo;

        public HomeController(IBookRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;

            var blah = new BookListViewModel
            {
                Books = _repo.Books
                .OrderBy(x => x.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PaginationBooks = new PaginationBooks
                {
                    currentPage = pageNum,
                    itemsPerPage = pageSize,
                    totalItems = _repo.Books.Count()
                }
            };
            return View(blah);
        }
    }
}
