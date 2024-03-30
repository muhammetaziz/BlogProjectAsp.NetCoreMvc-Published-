using MvcBlogProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlogProject.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult VisualizeResult()
        {
            return Json(categorylist(), JsonRequestBehavior.AllowGet);

        }
        public List<Class1> categorylist()
        {
            List<Class1> c = new List<Class1>();
            c.Add(new Class1()
            {
                CategoryName = "Teknoloji",
                BlogCount = 14

            });
            c.Add(new Class1()
            {
                CategoryName = "Spor",
                BlogCount = 10
            });
            c.Add(new Class1()
            {
                CategoryName = "Tarih",
                BlogCount = 3
            });
            return c;
        }
    }
}