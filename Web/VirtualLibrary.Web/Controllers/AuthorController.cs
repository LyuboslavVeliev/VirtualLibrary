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
    using VirtualLibrary.Web.ViewModels.Author;

    public class AuthorController : Controller
    {
        private IAuthorsService authorsService;

        public AuthorController(IAuthorsService authorsService)
        {
            this.authorsService = authorsService;
        }

        [HttpPost]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> Create(InputAuthorModel inputAuthorModel)
        {
            await this.authorsService.Create(inputAuthorModel.FirstName, inputAuthorModel.LastName);

            // return this.View(inputAuthorModel);
            return this.Redirect("/");
        }

        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> Create()
        {
            return this.View();
        }
    }
}
