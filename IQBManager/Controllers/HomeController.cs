using IQBManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IQBManager.Controllers
{
    public class HomeController : Controller
    {
        private QBDbContext db = new QBDbContext();

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

        public ActionResult Login()
        {
            var users = from u in db.UserInfoList where u.LoginID == "Test" select u;

            return View();
        }

    }
}