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

        public BookController(IBooksService booksService, IGenresService genresService)
        {
            this.booksService = booksService;
            this.genresService = genresService;
        }

        [HttpPost]
        // [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> Create(InputBookModel inputBookModel)
        {
            if (!this.ModelState.IsValid)
            {
                inputBookModel.Genre = this.genresService.GetList();
                return this.View(inputBookModel);
            }

            await this.booksService.CreateBook(inputBookModel.Title, inputBookModel.Description, inputBookModel.Image,
                inputBookModel.ReleaseDate, inputBookModel.AuthorName);

            // return this.View(inputBookModel);
            return this.Redirect("/");
        }

        // [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> Create()
        {
            var book = new InputBookModel
            {
                Genre = this.genresService.GetList(),
            };

            return this.View(book);
        }
    }
}
