using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using System.Net;
using c2cWebsite.Models;
using System.Data.Entity.Validation;
namespace c2cWebsite.Controllers
{
    public class HomeController : Controller
    {
        private c2cwebsiteEntities db = new c2cwebsiteEntities();
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
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult taikhoan()
        {
            return View();
        }

    }
}