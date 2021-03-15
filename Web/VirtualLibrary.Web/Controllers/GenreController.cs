namespace VirtualLibrary.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using VirtualLibrary.Services.Data;
    using VirtualLibrary.Web.ViewModels.Genre;

    public class GenreController : Controller
    {
        private IGenresService genresService;

        public GenreController(IGenresService genresService)
        {
            this.genresService = genresService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(InputGenreModel inputGenreModel)
        {
            await this.genresService.Create(inputGenreModel.Name);

            // return this.View(inputGenreModel);
            return this.Redirect("/");
        }

        public async Task<IActionResult> Create()
        {
            return this.View();
        }
    }
}
