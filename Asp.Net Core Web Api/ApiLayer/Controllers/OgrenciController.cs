using BusinessLayer.Concrete;
using DataAccess.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLayer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OgrenciController : ControllerBase
    {
        OgrenciManager ogrenciManager = new OgrenciManager(new EfOgrenciRepository());

        [HttpGet]

        public List<Ogrenci> Get()
        {
            return ogrenciManager.GetList();

        }

        [HttpGet ("{id}")]

        public Ogrenci Get(int id)
        {
            return ogrenciManager.GetById(id);

        }

        [HttpPost]

        public List<Ogrenci> Post([FromBody] Ogrenci ogrenci)
        {
            ogrenciManager.TAdd(ogrenci);
            return ogrenciManager.GetList();

        }

        [HttpPut]

        public List<Ogrenci> Put ([FromBody] Ogrenci ogrenci)
        {
            ogrenciManager.TUpdate(ogrenci);
            return ogrenciManager.GetList();

        }

        [HttpDelete]

        public List<Ogrenci> Delete([FromBody] Ogrenci ogrenci)
        {
            ogrenciManager.TDelete(ogrenci);
            return ogrenciManager.GetList();

        }

    }
}
