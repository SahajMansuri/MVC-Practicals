using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical_6.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login(string username, string password)
        {
            if(username == "Sahaj" && password == "1006")
            {
                HttpCookie ck = new HttpCookie("user", "Sahaj");
                Response.Cookies.Add(ck);
                ck.Expires = DateTime.Now.AddSeconds(200);
                return RedirectToAction("Index");
            }
            else if (username == "sahaj" && password == "3004")
            {
                Session["user"] = "SahajMansuri";
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
                
        }

        public ActionResult Logout()
        {
            Session.Clear();

            return RedirectToAction("Login");
        }
    }
}