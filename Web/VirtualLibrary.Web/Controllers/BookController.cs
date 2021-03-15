﻿namespace VirtualLibrary.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using VirtualLibrary.Services.Data;

    using Microsoft.AspNetCore.Mvc;
    using VirtualLibrary.Web.ViewModels.Book;

    public class BookController : Controller
    {
        private IBooksService booksService;

        public BookController(IBooksService booksService)
        {
            this.booksService = booksService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(InputBookModel inputBookModel)
        {
            await this.booksService.CreateBook(inputBookModel.Title, inputBookModel.Description, inputBookModel.Image,
                inputBookModel.ReleaseDate, inputBookModel.AuthorName);

            // return this.View(inputBookModel);
            return this.Redirect("/");
        }

        public async Task<IActionResult> Create()
        {
            return this.View();
        }
    }
}
