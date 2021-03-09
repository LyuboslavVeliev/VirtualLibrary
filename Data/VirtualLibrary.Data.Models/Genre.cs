namespace VirtualLibrary.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    using VirtualLibrary.Data.Common.Models;

    public class Genre : BaseDeletableModel<int>
    {
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        public ICollection<BookGenre> Books { get; set; }
            = new HashSet<BookGenre>();
    }
}
