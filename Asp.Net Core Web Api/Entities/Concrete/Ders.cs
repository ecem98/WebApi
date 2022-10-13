using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Ders
    {
        [Key]
        public int DersID { get; set; }
        public string DersAd { get; set; }
        public int DersKontenjan { get; set; }
        public bool DersStatus { get; set; }
        public Hoca Hoca { get; set; }
        public int HocaId { get; set; }
        public List<Ogrenci> Ogrencis { get; set; }
       
    }
}
