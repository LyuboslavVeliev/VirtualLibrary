namespace VirtualLibrary.Services.Data
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System;
    using System.Collections.Generic;
    using System.Linq;
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

        public IEnumerable<SelectListItem> GetList()
        {
            return this.authorRepository.All().Select(x => new SelectListItem
            {
                Text = x.FirstName + " " + x.LastName,
                Value = x.Id.ToString(),
            });
        }
    }
}
