using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Okul.Entities.Concrete;

namespace Okul.DataAccess.Concrete.Nortwind
{
    public class NortwindContext:DbContext
    {
        DbSet<Category> Categories { get; set; }
    }
}
