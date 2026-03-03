using LibraryGUI.Models;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryGUI.Datas
{
    internal class Create
    {
        LibraryResults libraryResults = new LibraryResults();
        public LibraryResults CreateAuthor(string name)
        {
            using (var context = new librarydbContext())
            {
                var author = new Authors
                {
                    AuthorName = name
                };

                context.Authors.Add(author);
                context.SaveChanges();
                libraryResults.Message = "Sikeres szerző felvétel";
                libraryResults.Result = author.AuthorName;


                return libraryResults;
            }

        }

        public LibraryResults CreateCategory(string categoryName)
        {
            using (var context = new librarydbContext())
            {
                var category = new Categories
                {
                    CategoryName = categoryName
                };

                context.Categories.Add(category);
                context.SaveChanges();
                libraryResults.Message = "Sikeres kategória felvétel";
                libraryResults.Result = category.CategoryName;


                return libraryResults;
            }

        }

        public LibraryResults CreateBooks(string title, DateTime date, int authId, int categoryId)
        {
            using (var context = new librarydbContext())
            {
                var book = new Books
                {
                    Title = title,
                    PublishDate = date,
                    AuthorId = authId,
                    CategoryId = categoryId
                };

                context.Books.Add(book);
                context.SaveChanges();
                libraryResults.Message = "Sikeres könyv felvétel";
                libraryResults.Result = book;


                return libraryResults;
            }

        }
    }
}