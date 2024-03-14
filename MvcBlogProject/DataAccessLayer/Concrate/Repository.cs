using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrate
{
    public class Repository<T> : IRepository<T> where T : class
    {
        Context c = new Context();
        DbSet<T> _object;

        public Repository()
        {
            _object = c.Set<T>();
        }

        public int Delete(T p)
        {
            _object.Remove(p);
            return c.SaveChanges();
        }

        public T GetByID(int id)
        {
            return _object.Find(id);
        }

        public int Insert(T p)
        {
            _object.Add(p);
            return c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public int Update(T p)
        {
            return c.SaveChanges();
        }
    }
}
