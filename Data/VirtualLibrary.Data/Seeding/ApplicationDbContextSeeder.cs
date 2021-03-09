namespace VirtualLibrary.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;
    using VirtualLibrary.Data.Models;

    public class ApplicationDbContextSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            //dbContext.Genres.Add(new Genre
            //{
            //   Name = "Fantasy",
            //});
            //
            //dbContext.Authors.Add(new Author
            //{
            //    FirstName = "Joanne",
            //    LastName = "Rowling",
            //});
            //
            //dbContext.Books.Add(new Book
            //{
            //    Title = "Harry Potter and the Philosopher's Stone",
            //    Description = "It is a story about Harry Potter, an orphan brought up by " +
            //    "his aunt and uncle because his parents were killed when he was a baby. Harry is " +
            //    "unloved by his uncle and aunt but everything changes when he is invited to join " +
            //    "Hogwarts School of Witchcraft and Wizardry and he finds out he's a wizard.",
            //    ReleaseDate = new DateTime(1997, 6, 26),
            //    AuthorId = 7,
            //});
            //
            //dbContext.BookGenres.Add(new BookGenre
            //{
            //   BookId = 7,
            //   GenreId = 5,
            //});

            if (dbContext == null)
            {
                throw new ArgumentNullException(nameof(dbContext));
            }

            if (serviceProvider == null)
            {
                throw new ArgumentNullException(nameof(serviceProvider));
            }

            var logger = serviceProvider.GetService<ILoggerFactory>().CreateLogger(typeof(ApplicationDbContextSeeder));

            var seeders = new List<ISeeder>
                          {
                              new RolesSeeder(),
                              new SettingsSeeder(),
                          };

            foreach (var seeder in seeders)
            {
                await seeder.SeedAsync(dbContext, serviceProvider);
                await dbContext.SaveChangesAsync();
                logger.LogInformation($"Seeder {seeder.GetType().Name} done.");
            }
        }
    }
}
