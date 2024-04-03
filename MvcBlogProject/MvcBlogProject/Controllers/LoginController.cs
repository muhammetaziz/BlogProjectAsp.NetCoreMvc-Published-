using DataAccessLayer.Concrate;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcBlogProject.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult AuthorLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AuthorLogin(Author p)
        {
            Context c = new Context();
            var userinfo = c.Authors.FirstOrDefault(x => x.AuthorMail == p.AuthorMail && x.AuthorPassword == p.AuthorPassword);
            if (userinfo!=null)
            {
                FormsAuthentication.SetAuthCookie(userinfo.AuthorMail , false);
                Session["AuthorMail"] = userinfo.AuthorMail.ToString();
                return RedirectToAction("Index", "User");
            }
            else
            {
                return RedirectToAction("AuthorLogin", "Login");
            }
           
        }
    }
}