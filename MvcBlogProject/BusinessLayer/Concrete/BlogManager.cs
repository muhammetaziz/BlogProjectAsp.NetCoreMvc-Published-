using DataAccessLayer.Concrate;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager
    {
        Repository<Blog> repoblog = new Repository<Blog>();
        public List<Blog> GetAll()
        {
            return repoblog.List();
        }
        public List<Blog> GetBlogByID(int id)
        {
            return repoblog.List(x => x.BlogID == id);
        }
        public List<Blog> GetBlogByAuthor(int id)
        {
            return repoblog.List(x => x.AuthorID == id);
        }
        public List<Blog> GetBlogByCategory(int id)
        {
            return repoblog.List(x => x.CategoryID == id);
        }
        public int BlogAddBL(Blog p)
        {
            if (p.blogImage==""||p.BlogContent==""||p.BlogTitle==""||p.BlogContent.Length<=200)
            {
                return -1;
            }
            return repoblog.Insert(p);
        }
        public int DeleteBlog(int p)
        {
            Blog blog = repoblog.Find(x => x.BlogID == p);
            return repoblog.Delete(blog);
        }
        public Blog FindBlog(int getid)
        {
            return repoblog.Find(x => x.BlogID == getid);
        }
        public int UpdateBlog(Blog p)
        {
            Blog blog = repoblog.Find(x => x.BlogID == p.BlogID);
            blog.BlogTitle = p.BlogTitle;
            blog.BlogContent = p.BlogContent;
            blog.blogImage = p.blogImage;
            blog.BlogDate = p.BlogDate;
            blog.AuthorID = p.AuthorID;
            blog.CategoryID = p.CategoryID;
            return repoblog.Update(blog);
        }
    }
}
