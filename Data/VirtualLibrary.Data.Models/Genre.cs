namespace VirtualLibrary.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class Genre
    {
        [Key]
        public int GenreId { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        public ICollection<BookGenre> Books { get; set; }
            = new HashSet<BookGenre>();
    }
}
