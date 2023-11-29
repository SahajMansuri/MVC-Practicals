using Practical_7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical_7.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Student obj)
        {
            if (ModelState.IsValid)
            {
                return View("dataAdd");
            }
            return View();
        }
        public ActionResult dataAdd()
        {
            return View();
        }
    }
}