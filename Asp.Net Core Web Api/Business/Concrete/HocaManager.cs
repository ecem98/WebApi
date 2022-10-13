using BusinessLayer.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HocaManager : IHocaService
    {
        IHocaDal hocaDal;

        public HocaManager(IHocaDal hocaDal)
        {
            this.hocaDal = hocaDal;
        }

        public Hoca GetById(int id)
        {
            return hocaDal.GetById(id);
        }

        public List<Hoca> GetList()
        {
            return hocaDal.GetListAll();
        }

        public void TAdd(Hoca t)
        {
            hocaDal.Insert(t);
        }

        public void TDelete(Hoca t)
        {
            hocaDal.Delete(t);
        }

        public void TUpdate(Hoca t)
        {
            hocaDal.Update(t);
        }
    }
}
