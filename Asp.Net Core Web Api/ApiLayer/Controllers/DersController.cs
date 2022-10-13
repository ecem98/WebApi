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
    public class DersController : ControllerBase
    {
        DersManager dersManager = new DersManager(new EfDersRepository());

        [HttpGet]

        public List<Ders> Get()
        {
            return dersManager.GetList();

        }

        [HttpGet ("{id}")]

        public Ders Get(int id)
        {
            return dersManager.GetById(id);

        }

        [HttpPost]

        public List<Ders> Post([FromBody] Ders ders)
        {
            dersManager.TAdd(ders);
            return dersManager.GetList();

        }

        [HttpPut]

        public List<Ders> Put ([FromBody]  Ders ders)
        {
            dersManager.TUpdate(ders);
            return dersManager.GetList();

        }

        [HttpDelete]

        public List<Ders> Delete([FromBody] Ders ders)
        {
            dersManager.TDelete(ders);
            return dersManager.GetList();

        }

    }
}
