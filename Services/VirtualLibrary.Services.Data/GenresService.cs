namespace VirtualLibrary.Services.Data
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;
    using System.Web.Mvc;
    using VirtualLibrary.Data.Common.Repositories;
    using VirtualLibrary.Data.Models;
    using System.Threading.Tasks;

    public class GenresService : IGenresService
    {
        private IDeletableEntityRepository<Genre> genreRepository;

        public GenresService(IDeletableEntityRepository<Genre> genreRepository)
        {
            this.genreRepository = genreRepository;
        }

        public async Task Create(string name)
        {
            var genre = new Genre
            {
                Name = name,
            };

            await this.genreRepository.AddAsync(genre);

            await this.genreRepository.SaveChangesAsync();
        }

        public IEnumerable<SelectListItem> GetList()
        {
            return this.genreRepository.All().Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString(),
            });
        }
    }
}
