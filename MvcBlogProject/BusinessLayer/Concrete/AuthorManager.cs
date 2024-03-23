using DataAccessLayer.Concrate;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{

    public class AuthorManager
    {
        Repository<Author> repoauth = new Repository<Author>();
        public List<Author> GetAll()
        {
            return repoauth.List();
        }
    }
}
