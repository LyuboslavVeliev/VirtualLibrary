namespace VirtualLibrary.Web.Controllers
{
    using System.Linq;
    using System.Diagnostics;

    using Microsoft.AspNetCore.Mvc;
    using VirtualLibrary.Services.Data;
    using VirtualLibrary.Web.ViewModels;
    using VirtualLibrary.Data.Common.Repositories;
    using VirtualLibrary.Data.Models;
    using VirtualLibrary.Web.ViewModels.Book;
    using VirtualLibrary.Services.Mapping;

    public class HomeController : BaseController
    {
        private readonly IDeletableEntityRepository<Book> bookrep;

        public HomeController(IDeletableEntityRepository<Book> bookrep)
        {
            this.bookrep = bookrep;
        }

        public IActionResult Index()
        {
            var books = this.bookrep.All().To<DisplayBookModel>().ToList();

            //var books = this.bookrep.All().Select(b => new DisplayBookModel
            //{
            //    Title = b.Title,
            //    Image = b.Image,
            //}).ToList();

            return this.View(books);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
