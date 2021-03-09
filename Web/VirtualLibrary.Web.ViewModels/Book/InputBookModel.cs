namespace VirtualLibrary.Web.ViewModels.Book
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class InputBookModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string AuthorName { get; set; }

        public string Genre { get; set; }
    }
}
