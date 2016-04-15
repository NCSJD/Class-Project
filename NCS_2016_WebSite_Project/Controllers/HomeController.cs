using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NCS_2016_WebSite_Project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Information";

            return View();
        }
        public ActionResult Videos()
        {
            ViewBag.Message = "Message: Interesting videos.";
            ViewBag.Title = "Videos";
            ViewBag.Description = "This page is designed to organize videos...";

            return View();
        }
        public ActionResult Links()
        {
            ViewBag.Title = "Links";
            return View();
        }
        public ActionResult Logic()
        {
            ViewBag.Message = "Logical thinking";
            ViewBag.Title = "Logic";
            return View();
        }
    }
}