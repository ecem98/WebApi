using BusinessLayer.Abstract;
using DataAccess.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DersManager:IDersService
    {
        IDersDal dersDal;

        public DersManager(IDersDal dersDal)
        {
            this.dersDal = dersDal;
        }

        public Ders GetById(int id)
        {
            return dersDal.GetById(id);
        }

        public List<Ders> GetList()
        {
            return dersDal.GetListAll();
        }

        public void TAdd(Ders t)
        {
            dersDal.Insert(t);
        }

        public void TDelete(Ders t)
        {
            dersDal.Delete(t);
        }

        public void TUpdate(Ders t)
        {
            dersDal.Update(t);
        }
    }
}
