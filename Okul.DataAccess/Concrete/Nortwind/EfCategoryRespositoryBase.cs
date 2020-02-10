using Okul.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Okul.DataAccess.Concrete.Nortwind
{
    public class EfCategoryRespositoryBase<TEntitiy, TContext> : IEntitiyRepository<TEntitiy>
        where TEntitiy : class, new()
        where TContext : DbContext, new()
    {
        public void add(TEntitiy Entitiy)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntitiy Entitiy)
        {
            throw new NotImplementedException();
        }

        public List<TEntitiy> GetAll(Expression<Func<TEntitiy, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntitiy>().ToList() :
                    context.Set<TEntitiy>().Where(filter).ToList();
            }
        }

        public void Update(TEntitiy Entitiy)
        {
            throw new NotImplementedException();
        }
    }
}
