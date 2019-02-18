using OLSA.Breakdowns.Models;
using System.Collections.Generic;

namespace OLSA.Breakdowns.IServices
{
    public interface IEntityService<TEntity>
        where TEntity : Base
    {
        TEntity Get(int id);
        IEnumerable<TEntity> Get();
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(int id);
    }

    
}
