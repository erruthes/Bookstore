using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();

            //var obj = new { id = 1, Name = "Nitish" };
            //return View("AboutUs", obj);

            //return View("TempView/Nitish.cshtml");
            //return View("../../TempView/Nitish");

        }

        public ViewResult AboutUs()
        {
            return View();
        }

        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
