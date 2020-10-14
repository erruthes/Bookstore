using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(w => w.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string bookName, string authorName)
        {
            return DataSource().Where(w => (!string.IsNullOrEmpty(bookName) && w.Title.Contains(bookName))
                                        || (!string.IsNullOrEmpty(authorName) && w.Author.Contains(authorName))
                                ).ToList();
        }

        private List<BookModel> DataSource()
        {
            int i = 1;

            return new List<BookModel>()
            {
                new BookModel(){ Id = i++, Title = "MVC", Author = "Nitish" },
                new BookModel(){ Id = i++, Title = ".NET Core", Author = "Nitish" },
                new BookModel(){ Id = i++, Title = "C#", Author = "Monika" },
                new BookModel(){ Id = i++, Title = "Java", Author = "WebGentle" },
                new BookModel(){ Id = i++, Title = "PHP", Author = "WebGentle" },
            };
        }
    }
}
