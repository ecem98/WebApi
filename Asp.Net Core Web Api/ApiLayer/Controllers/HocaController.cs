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
    public class HocaController : ControllerBase
    {
        HocaManager hocaManager = new HocaManager(new EfHocaRepository());

        [HttpGet]

        public List<Hoca> Get()
        {
            return hocaManager.GetList();

        }

        [HttpGet ("{id}")]

        public Hoca Get(int id)
        {
            return hocaManager.GetById(id);

        }

        [HttpPost]

        public List<Hoca> Post([FromBody] Hoca hoca)
        {
            hocaManager.TAdd(hoca);
            return hocaManager.GetList();

        }

        [HttpPut]

        public List<Hoca> Put ([FromBody] Hoca hoca)
        {
            hocaManager.TUpdate(hoca);
            return hocaManager.GetList();

        }

        [HttpDelete]

        public List<Hoca> Delete([FromBody] Hoca hoca)
        {
            hocaManager.TDelete(hoca);
            return hocaManager.GetList();

        }

    }
}
