using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DDA.Models;

namespace DDA.Controllers
{
    public class HomeController : Controller
    {
        DDAContext db = new DDAContext();

        public ActionResult Index()
        {
            IEnumerable<Category> categories = db.Categories;
            IEnumerable<User> users = db.Users;
            IEnumerable<Article> articles = db.Articles;
            IEnumerable<Publication> publications = db.Publications;

            ViewBag.Categories = categories;
            ViewBag.Users = users;
            ViewBag.Articles = articles;
            ViewBag.Publications = publications;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}