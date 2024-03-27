using DataAccessLayer.Concrate;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {

        Repository<Category> repocategory = new Repository<Category>();
        public List<Category> GetAll()
        {
            return repocategory.List();
        }
        public int AddCategory(Category p)
        {
            //parametreye gore geçerlilik sağlama
            if (p.CategoryName == "" || p.CategoryDescription == ""  )
            {
                return -1;
            }
            return repocategory.Insert(p);
        }


    }
}
