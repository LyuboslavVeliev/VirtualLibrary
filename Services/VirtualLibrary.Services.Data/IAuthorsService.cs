namespace VirtualLibrary.Services.Data
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public interface IAuthorsService
    {
        Task Create(string firstName, string lastName);

        IEnumerable<SelectListItem> GetList();
    }
}
