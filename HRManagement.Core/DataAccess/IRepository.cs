using HRManagement.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.Core.DataAccess
{
    public interface IRepository<TEntity>
        where TEntity:BaseEntity
    {
        TEntity Add(TEntity entity);
        TEntity Update(TEntity entity);
        int Remove(TEntity entity);
        TEntity Get(Expression<Func<TEntity,bool>>filter,params Expression<Func<TEntity,object>>[] includes);
        ICollection<TEntity> GetAll(Expression<Func<TEntity,bool>>filter=null,params Expression<Func<TEntity,object>>[] includes);
    }
}
