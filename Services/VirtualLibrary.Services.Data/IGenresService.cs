namespace VirtualLibrary.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc.Rendering;

    public interface IGenresService
    {
        Task Create(string name);

        IEnumerable<SelectListItem> GetList();
    }
}
