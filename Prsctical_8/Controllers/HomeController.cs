using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Prsctical_8.Models;
namespace Prsctical_8.Controllers
{
    public class HomeController : Controller
    {
        StudentContext db = new StudentContext();
        // GET: Home
        public ActionResult Index()
        {
            var data = db.Students.ToList();
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student obj)
        {
            if (ModelState.IsValid == true)
            {
                db.Students.Add(obj);
                int a = db.SaveChanges();
                if(a > 0)
                {
                    TempData["Message"] = "Data Inserted ヾ(≧▽≦*)o";
                    return RedirectToAction("Index");
                }
                
            }
            else
            {
                ViewBag.InsertMessage = "<script> alert('Data Not Inserted ( ´･･)ﾉ(._.`)')</script>";
            }
            return View();
        }
        public ActionResult Edit(int id)
        {
            var row = db.Students.Where(x => x.Id == id).FirstOrDefault();
            
            return View(row);
        }

        [HttpPost]
        public ActionResult Edit(Student obj)
        {
            if (ModelState.IsValid)
            {
                db.Entry(obj).State = EntityState.Modified;
                int a = db.SaveChanges();
                if (a > 0)
                {
                    TempData["Message"] = "Data Updated ヾ(≧▽≦*)o";
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.InsertMessage = "<script> alert('Data Not Updated ( ´･･)ﾉ(._.`)')</script>";
                }
            }
            return View();
        }
        public ActionResult Delete(Student obj)
        {
            db.Entry(obj).State = EntityState.Deleted;
            int a = db.SaveChanges();
            if (a > 0)
            {
                TempData["Message"] = "Data Row Deleted (* ￣︿￣)";
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}