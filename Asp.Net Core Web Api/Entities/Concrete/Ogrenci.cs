using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Ogrenci
    {
        [Key]
        public int OgrenciID { get; set; }
        public string OgrenciAd{ get; set; }
        public string OgrenciSoyad { get; set; }
        public string OgrenciSınıf { get; set; }
        public bool OgrenciStatus{ get; set; }
        public int DersID { get; set; }
        public Ders Ders { get; set; }

    }
}
