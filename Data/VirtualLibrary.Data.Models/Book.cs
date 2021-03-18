namespace VirtualLibrary.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    using VirtualLibrary.Data.Common.Models;

    public class Book : BaseDeletableModel<int>
    {
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }

        public string Image { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        public int AuthorId { get; set; }

        public virtual Author Author { get; set; }

        public ICollection<BookGenre> Genres { get; set; }
            = new HashSet<BookGenre>();
    }
}
