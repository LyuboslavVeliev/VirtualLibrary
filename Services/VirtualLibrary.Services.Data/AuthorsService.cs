namespace VirtualLibrary.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using VirtualLibrary.Data.Common.Repositories;
    using VirtualLibrary.Data.Models;

    public class AuthorsService : IAuthorsService
    {
        private IDeletableEntityRepository<Author> authorRepository;

        public AuthorsService(IDeletableEntityRepository<Author> authorRepository)
        {
            this.authorRepository = authorRepository;
        }

        public async Task Create(string firstName, string lastName)
        {
            var author = new Author
            {
                FirstName = firstName,
                LastName = lastName,
            };

            await this.authorRepository.AddAsync(author);

            await this.authorRepository.SaveChangesAsync();
        }
    }
}
