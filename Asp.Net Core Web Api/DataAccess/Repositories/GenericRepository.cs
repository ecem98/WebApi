using DataAccess.Abstract;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var c = new DatabaseContext();
            c.Remove(t);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            using var c = new DatabaseContext();
            return c.Set<T>().Find(id);
        }

        public List<T> GetList(Expression<Func<T, bool>> filter)
        {
            using var c = new DatabaseContext();
            return c.Set<T>().Where(filter).ToList();
        }

        public List<T> GetListAll()
        {
            using var c = new DatabaseContext();
            return c.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var c = new DatabaseContext();
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            using var c = new DatabaseContext();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
