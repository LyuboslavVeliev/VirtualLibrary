namespace VirtualLibrary.Services.Data
{
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using VirtualLibrary.Web.ViewModels.Book;

    public interface IBooksService
    {
        Task CreateBook(string title, string description, string image, DateTime releaseDate);

        BookDetailsModel Details(int id);
    }
}
