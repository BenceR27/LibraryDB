using LibraryGUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryGUI.Datas
{
    internal class Read
    {
        public List<Authors> ReadAuthors()
        {
			using (var context = new librarydbContext())
			{
				var users = context.Authors.ToList();
				return users;
			}
        }
        public List<Books> ReadBooks()
        {
            using (var context = new librarydbContext())
            {
                var books = context.Books.ToList();
                return books;
            }
        }
        public List<Categories> ReadCategories()
        {
            using (var context = new librarydbContext())
            {
                var categories = context.Categories.ToList();
                return categories;
            }
        }
    }
}
