namespace VirtualLibrary.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using VirtualLibrary.Data.Common.Models;

    public class BookGenre : BaseDeletableModel<int>
    {
        public int BookId { get; set; }

        public Book Book { get; set; }

        public int GenreId { get; set; }

        public Genre Genre { get; set; }
    }
}
