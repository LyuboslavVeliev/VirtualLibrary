namespace VirtualLibrary.Web.ViewModels.Book
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Microsoft.AspNetCore.Mvc.Rendering;

    public class InputBookModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public DateTime ReleaseDate { get; set; }

        public List<int> AuthorId { get; set; }

        public IEnumerable<SelectListItem> Author { get; set; }

        public List<int> GenresId { get; set; }

        public IEnumerable<SelectListItem> Genre { get; set; }
    }
}
