using DataAccessLayer.Concrate;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    //Tüm yazar listesi getirme
    public class AuthorManager
    {
        Repository<Author> repoauth = new Repository<Author>();
        public List<Author> GetAll()
        {
            return repoauth.List();
        }
        //Yeni Yazar ekleme
        public int AddAuthorBL(Author p)
        {
            //parametreye gore geçerlilik sağlama
            if (p.AuthorAbout == "" || p.AuthorImage == "" || p.AuthorPassword == "" || p.AuthorName == "" || p.AuthorMail == "" || p.AuthorPhone == "" || p.AuthorTitle == "" || p.AuthorShotAbout == "")
            {
                return -1;
            }
            return repoauth.Insert(p);
        }

        //Yazarı ID degerine gore edit sayfasına tasımak 
        public Author FindAuthor(int id)
        {
            return repoauth.Find(x => x.AuthorID == id);
        }
        
        public int EditAuthor(Author p)
        {
            Author author = repoauth.Find(x => x.AuthorID == p.AuthorID);
            author.AuthorName = p.AuthorName;
            author.AuthorImage = p.AuthorImage;
            author.AuthorAbout  = p.AuthorAbout;
            author.AuthorPhone = p.AuthorPhone;
            author.AuthorTitle = p.AuthorTitle;
            author.AuthorShotAbout = p.AuthorShotAbout;
            author.AuthorPassword = p.AuthorPassword;
            author.AuthorMail = p.AuthorMail;
            return repoauth.Update(author);

        }
    }
}
