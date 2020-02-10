using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Okul.Entities.Concrete;

namespace Okul.DataAccess.Concrete.EntitiyFramework
{
    public class OgrenciContext:DbContext
    {
        public DbSet<Ogrenci> ogrencis { get; set; }
    }
}
