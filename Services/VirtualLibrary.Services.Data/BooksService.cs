namespace VirtualLibrary.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using VirtualLibrary.Data.Common.Repositories;
    using VirtualLibrary.Data.Models;
    using VirtualLibrary.Services.Mapping;
    using VirtualLibrary.Web.ViewModels.Book;

    public class BooksService : IBooksService
    {
        private IDeletableEntityRepository<Book> bookRepository;

        public BooksService(IDeletableEntityRepository<Book> bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public async Task CreateBook(string title, string description, string image, DateTime releaseDate)
        {
            var book = new Book
            {
                Title = title,
                Description = description,
                Image = image,
                ReleaseDate = releaseDate,
            };

            await this.bookRepository.AddAsync(book);

            await this.bookRepository.SaveChangesAsync();
        }

        public BookDetailsModel Details(int id)
        {
            var book = this.bookRepository
                .All()
                .Where(x => x.Id == id)
                .To<BookDetailsModel>()
                .FirstOrDefault();

            return book;
        }
    }
}
