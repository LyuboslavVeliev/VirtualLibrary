namespace VirtualLibrary.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using VirtualLibrary.Common;
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
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> Create(InputGenreModel inputGenreModel)
        {
            await this.genresService.Create(inputGenreModel.Name);

            return this.Redirect("/");
        }

        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> Create()
        {
            return this.View();
        }
    }
}
