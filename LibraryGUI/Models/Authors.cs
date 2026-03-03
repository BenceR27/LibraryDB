using System;
using System.Collections.Generic;

namespace LibraryGUI.Models
{
    public partial class Authors
    {
        public Authors()
        {
            Books = new HashSet<Books>();
        }

        public int AuthorId { get; set; }
        public string AuthorName { get; set; }

        public virtual ICollection<Books> Books { get; set; }
    }
}
