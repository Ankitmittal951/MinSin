using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyProfile_Portfolio_MPP.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Display()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            List<string> items = new List<string>();
            items.Add("Product1");
            items.Add("Product2");
            items.Add("Product3");

            ViewBag.Items = items;
            return View();
        }
    }
}