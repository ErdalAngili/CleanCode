using Okul.DataAccess.Abstract;
using Okul.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.DataAccess.Concrete.Nortwind
{
    public class EfCategoryDal :EfCategoryRespositoryBase<Category,NortwindContext>,ICategoryDal
    {
    }
}
