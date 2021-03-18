namespace VirtualLibrary.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Web.Mvc;
    using VirtualLibrary.Data.Common.Repositories;
    using VirtualLibrary.Data.Models;

    public class BooksService : IBooksService
    {
        private IDeletableEntityRepository<Author> authorRepository;
        private IDeletableEntityRepository<Book> bookRepository;

        public BooksService(IDeletableEntityRepository<Book> bookRepository, IDeletableEntityRepository<Author> authorRepository)
        {
            this.bookRepository = bookRepository;
            this.authorRepository = authorRepository;
        }

        public async Task CreateBook(string title, string description, string image, DateTime releaseDate, string authorLastName)
        {
            var book = new Book
            {
                Title = title,
                Description = description,
                Image = image,
                ReleaseDate = releaseDate,
                Author = this.authorRepository.All().FirstOrDefault(a => a.LastName == authorLastName),
            };

            await this.bookRepository.AddAsync(book);

            await this.bookRepository.SaveChangesAsync();
        }
    }
}
