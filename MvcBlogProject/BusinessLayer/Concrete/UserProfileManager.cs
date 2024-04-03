using DataAccessLayer.Concrate;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserProfileManager
    {
        Repository<Author> repouser = new Repository<Author>();
        Repository<Blog> repouserblog = new Repository<Blog>();
        public List<Author> GetAuthorByMail(string p)
        {
            return repouser.List(x => x.AuthorMail == p);
        }
        public List<Blog> GetBlogByAuthor(int id)
        {
            return repouserblog.List(x => x.AuthorID == id);
        }
    }
}
