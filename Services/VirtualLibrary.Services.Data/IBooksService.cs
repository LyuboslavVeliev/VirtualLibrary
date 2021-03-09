namespace VirtualLibrary.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public interface IBooksService
    {
        Task CreateBook(string title, string description, DateTime releaseDate, string authorLastName);
    }
}
