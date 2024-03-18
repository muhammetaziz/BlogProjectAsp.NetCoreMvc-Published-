using BusinessLayer.Concrete;
using System;
using PagedList;
using PagedList.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlogProject.Controllers
{
    public class BlogController : Controller
    {

        // GET: Blog
        BlogManager bm = new BlogManager();


        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult BlogList(int page=1)
        {
            var bloglist = bm.GetAll().ToPagedList(page,6);
            return PartialView(bloglist);
        }
        public PartialViewResult FeaturedPosts()
        {

            //1.Post
            #region
            var postTitle1 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 1).Select(y => y.BlogTitle).FirstOrDefault();
            var postImage1 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 1).Select(y => y.blogImage).FirstOrDefault();
            var postDate1 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 1).Select(y => y.BlogDate).FirstOrDefault();


            ViewBag.postTitle1 = postTitle1;
            ViewBag.postImage1 = postImage1;
            ViewBag.postDate1 = postDate1;
            #endregion

            //2.Post
            #region
            var postTitle2 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 2).Select(y => y.BlogTitle).FirstOrDefault();
            var postImage2 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 2).Select(y => y.blogImage).FirstOrDefault();
            var postDate2 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 2).Select(y => y.BlogDate).FirstOrDefault();

            ViewBag.postTitle2 = postTitle2;
            ViewBag.postImage2 = postImage2;
            ViewBag.postDate2 = postDate2;
            #endregion

            //3.Post
            #region
            var postTitle3 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 3).Select(y => y.BlogTitle).FirstOrDefault();
            var postImage3 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 3).Select(y => y.blogImage).FirstOrDefault();
            var postDate3 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 3).Select(y => y.BlogDate).FirstOrDefault();

            ViewBag.postTitle3 = postTitle3;
            ViewBag.postImage3 = postImage3;
            ViewBag.postDate3 = postDate3;
            #endregion

            //4.Post
            #region
            var postTitle4 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 4).Select(y => y.BlogTitle).FirstOrDefault();
            var postImage4 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 4).Select(y => y.blogImage).FirstOrDefault();
            var postDate4 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 4).Select(y => y.BlogDate).FirstOrDefault();

            ViewBag.postTitle4 = postTitle4;
            ViewBag.postImage4 = postImage4;
            ViewBag.postDate4 = postDate4;
            #endregion
            
            //5.Post
            #region
            var postTitle5 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 5).Select(y => y.BlogTitle).FirstOrDefault();
            var postImage5 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 5).Select(y => y.blogImage).FirstOrDefault();
            var postDate5 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 5).Select(y => y.BlogDate).FirstOrDefault();

            ViewBag.postTitle5 = postTitle5;
            ViewBag.postImage5 = postImage5;
            ViewBag.postDate5 = postDate5;
            #endregion
            return PartialView();
        }

        public PartialViewResult OtherFeaturedPosts()
        {
            return PartialView();
        }
        public PartialViewResult MailSubscribe()
        {
            return PartialView();
        }
        public ActionResult BlogDetails()
        {
            return View();
        }
        public PartialViewResult BlogCover()
        {
            return PartialView();
        }
        public PartialViewResult BlogReadAll()
        {
            return PartialView();
        }
        public ActionResult BlogByCategory()
        {
            return View();
        }

    }
}