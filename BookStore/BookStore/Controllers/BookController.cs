using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        // /book/getallbooks
        public string GetAllBooks()
        {
            return "All Books";
        }

        // /book/getbook/10
        public string GetBook(int id)
        {
            return $"book with id: {id}";
        }

        // /book/searchbooks?bookName=TESTE&authorName=AUTOR
        public string SearchBooks(string bookName, string authorName)
        {
            return $"Book with name: {bookName} and author: {authorName}";
        }
    }
}
