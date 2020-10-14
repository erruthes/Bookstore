using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }

        // /book/getallbooks
        public List<BookModel> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }

        // /book/getbook/10
        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
        }

        // /book/searchbooks?bookName=TESTE&authorName=AUTOR
        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            return _bookRepository.SearchBook(bookName, authorName);
        }
    }
}
