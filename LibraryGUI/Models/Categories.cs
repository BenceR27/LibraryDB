using System;
using System.Collections.Generic;

namespace LibraryGUI.Models
{
    public partial class Categories
    {
        public Categories()
        {
            Books = new HashSet<Books>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Books> Books { get; set; }
    }
}
