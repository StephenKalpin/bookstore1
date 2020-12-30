using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webgentle.bookstore.Models;

namespace webgentle.bookstore.Controllers
{
    public class HomeController : Controller
    {
        [ViewData]
        public string CustomProperty { get; set; }
        [ViewData]
        public string Title { get; set; }
        [ViewData]
        public BookModel Book { get; set; }

        public ViewResult Index()
        {
            ViewData["property1"] = "something to pass to view";
            ViewData["book"] = new BookModel() { Author = "Nitish", Id = 1 };

            Title = "Home Page From Controller";
            CustomProperty = "Custom Value";
            Book = new BookModel() { Id = 1, Title = "Asp.Net Core Tutorial" };

            ViewBag.Title = "Nitish";
            return View();
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
