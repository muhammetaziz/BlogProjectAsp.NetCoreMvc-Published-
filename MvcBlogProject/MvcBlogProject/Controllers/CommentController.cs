using BusinessLayer.Concrete;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlogProject.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager();
        // GET: Comment
        public PartialViewResult CommentList(int id)
        {
            var commentlist = cm.CommentByBlog(id);
            return PartialView(commentlist);
        }
        [HttpGet]
        public PartialViewResult LeaveComment(int id)
        {
            ViewBag.id = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult LeaveComment(Comment c)
        {
            cm.CommentAdd(c);
            return PartialView();
        }
    }
}