using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class DatabaseContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);


            optionsBuilder.UseSqlServer("server=DESKTOP-TQH9F97; database=OkulDb; trusted_connection=true;");
            
        }

        public DbSet<Ogrenci> Ogrencis  { get; set; }
        public DbSet<Hoca> Hocas { get; set; }
        public DbSet<Ders> Ders { get; set; }

    }
}
