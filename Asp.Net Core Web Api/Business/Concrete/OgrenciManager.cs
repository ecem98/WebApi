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
    public class OgrenciManager:IOgrenciService
    {
        IOgrenciDal ogrenciDal;

        public OgrenciManager(IOgrenciDal ogrenciDal)
        {
            this.ogrenciDal = ogrenciDal;
        }

        public Ogrenci GetById(int id)
        {
            return ogrenciDal.GetById(id);
        }

        public List<Ogrenci> GetList()
        {
            return ogrenciDal.GetListAll();
        }

        public void TAdd(Ogrenci t)
        {
            ogrenciDal.Insert(t);
        }

        public void TDelete(Ogrenci t)
        {
            ogrenciDal.Delete(t);
        }

        public void TUpdate(Ogrenci t)
        {
            ogrenciDal.Update(t);
        }
    }
}
