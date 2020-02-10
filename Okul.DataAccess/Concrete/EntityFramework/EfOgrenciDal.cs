using Okul.DataAccess.Concrete.EntitiyFramework;
using Okul.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Okul.DataAccess.Abstract;
using System.Linq.Expressions;

namespace Okul.DataAccess.Concrete.EntityFramework
{
    public class EfOgrenciDal : EfEntityRepositoryBase<Ogrenci, OgrenciContext>, IOgrenciDal
    {
    }
}
