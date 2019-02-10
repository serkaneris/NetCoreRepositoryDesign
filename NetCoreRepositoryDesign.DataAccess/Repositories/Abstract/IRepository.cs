using NetCoreRepositoryDesign.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace NetCoreRepositoryDesign.DataAccess.Repositories.Abstract
{
    public interface IRepository<TEntity> where TEntity:class,IEntity,new()
    {
        TEntity Get(Expression<Func<TEntity,bool>> filter);
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);

    }
}
