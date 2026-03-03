using System;
using System.Collections.Generic;


namespace LibraryGUI.Models
{
    public partial class Books
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public DateTime? PublishDate { get; set; }
        public int? AuthorId { get; set; }
        public int? CategoryId { get; set; }

        public virtual Authors Author { get; set; }
        public virtual Categories Category { get; set; }
    }
}
