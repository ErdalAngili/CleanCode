using Okul.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Okul.DataAccess.Abstract
{
    public interface IEntitiyRepository<T>
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        void add(T Entitiy);
        void Update(T Entitiy);
        void Delete(T Entitiy);
    }
}
