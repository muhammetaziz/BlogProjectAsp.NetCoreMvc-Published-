using BusinessLayer.Concrete;
using EntityLayer.Concrate;
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
        public PartialViewResult BlogDetailsCategoryList()
        {
            var categoryvalues = cm.GetAll(); 
            return PartialView(categoryvalues);
        }
        public ActionResult AdminCategoryList()
        {
            var categoryvalues = cm.GetAll();
            return View(categoryvalues);
        }
        [HttpGet]
        public ActionResult AdminCategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminCategoryAdd(Category p)
        {
            cm.AddCategory(p);
            return RedirectToAction("AdminCategoryList");
        }
    }
}