namespace VirtualLibrary.Data.Seeding
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using VirtualLibrary.Common;
    using VirtualLibrary.Data.Models;

    public class UserSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            if (dbContext.Users.Any())
            {
                return;
            }

            ApplicationUser user1 = new ApplicationUser
            {
                UserName = "Lyuboslav",
                PasswordHash = "L%123456789",
                Email = "lub.veliev@abv.bg",
            };

            ApplicationUser user2 = new ApplicationUser
            {
                UserName = "Kristiyan",
                PasswordHash = "K%1234567890",
                Email = "simov.kris@abv.bg",
            };

            await userManager.CreateAsync(user1, user1.PasswordHash);
            await userManager.CreateAsync(user2, user2.PasswordHash);

            await userManager.AddToRoleAsync(user1, GlobalConstants.AdministratorRoleName);
            await userManager.AddToRoleAsync(user2, GlobalConstants.AdministratorRoleName);
        }
    }
}
