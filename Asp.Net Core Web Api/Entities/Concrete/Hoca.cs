using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Hoca
    {
        [Key]
        public int HocaID { get; set; }
        public string HocaAd { get; set; }
        public string HocaSoyad { get; set; }
        public List<Ders> Ders { get; set; }
    }
}
