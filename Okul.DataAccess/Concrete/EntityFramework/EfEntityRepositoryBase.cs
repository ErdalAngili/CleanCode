using Okul.DataAccess.Abstract;
using Okul.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Okul.DataAccess.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntitiyRepository<TEntity>
        where TEntity : class, new()
        where TContext : DbContext, new()
    {
        public void add(TEntity Entitiy)
        {
            using (TContext context = new TContext())
            {
                var ekle = context.Entry(Entitiy);
                ekle.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity Entitiy)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context= new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList():
                    context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity Entitiy)
        {
            throw new NotImplementedException();
        }
    }
}
