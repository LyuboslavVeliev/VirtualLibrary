namespace VirtualLibrary.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using VirtualLibrary.Services.Data;

    using Microsoft.AspNetCore.Mvc;
    using VirtualLibrary.Web.ViewModels.Book;
    using VirtualLibrary.Common;
    using Microsoft.AspNetCore.Authorization;

    public class BookController : Controller
    {
        private IBooksService booksService;
        private IGenresService genresService;
        private IAuthorsService authorsService;

        public BookController(IBooksService booksService, IGenresService genresService, IAuthorsService authorsService)
        {
            this.booksService = booksService;
            this.genresService = genresService;
            this.authorsService = authorsService;
        }

        [HttpPost]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> Create(InputBookModel inputBookModel)
        {
            if (!this.ModelState.IsValid)
            {
                inputBookModel.Author = this.authorsService.GetList();
                inputBookModel.Genre = this.genresService.GetList();
                return this.View(inputBookModel);
            }

            await this.booksService.CreateBook(inputBookModel.Title, inputBookModel.Description, inputBookModel.Image,
                inputBookModel.ReleaseDate);

            return this.Redirect("/");
        }

        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> Create()
        {
            var book = new InputBookModel
            {
                Author = this.authorsService.GetList(),
                Genre = this.genresService.GetList(),
            };

            return this.View(book);
        }

        [Route("/Book/Details/{id:int}")]
        public async Task<IActionResult> Details(int id)
        {
            return this.View(this.booksService.Details(id));
        }
    }
}
