using System;
using System.Linq;
using LibraryGUI.Models;

namespace LibraryGUI.Datas
{
    internal class UpdateDelete
    {
        private readonly LibraryResults _libraryResults = new LibraryResults();

        public LibraryResults UpdateBookAuthorCategory(int bookId, int newAuthorId, int newCategoryId, DateTime newPublishDate)
        {
            using (var context = new librarydbContext())
            {
                var book = context.Books.FirstOrDefault(b => b.BookId == bookId);
                if (book == null)
                {
                    _libraryResults.Message = "A könyv nem található.";
                    _libraryResults.Result = null;
                    return _libraryResults;
                }

                book.AuthorId = newAuthorId;
                book.CategoryId = newCategoryId;
                book.PublishDate = newPublishDate;

                context.SaveChanges();

                _libraryResults.Message = "Sikeres módosítás.";
                _libraryResults.Result = book;
                return _libraryResults;
            }
        }

        public LibraryResults DeleteBook(int bookId)
        {
            using (var context = new librarydbContext())
            {
                var book = context.Books.FirstOrDefault(b => b.BookId == bookId);
                if (book == null)
                {
                    _libraryResults.Message = "A könyv nem található.";
                    _libraryResults.Result = null;
                    return _libraryResults;
                }

                context.Books.Remove(book);
                context.SaveChanges();

                _libraryResults.Message = "A könyv törölve lett.";
                _libraryResults.Result = bookId;
                return _libraryResults;


            }
        }
    }
}