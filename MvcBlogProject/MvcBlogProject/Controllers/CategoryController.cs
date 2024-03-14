using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlogProject.Controllers
{
    public class CategoryController : Controller
    {

         
        CategoryManager cm = new CategoryManager();
        public ActionResult Index()
        {
            var categoryvalues = cm.GetAll();
            return View(categoryvalues);


        }
    }
}