using Bogus;
using OLSA.Breakdowns.IServices;
using OLSA.Breakdowns.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OLSA.Breakdowns.FakeServices
{
    public class FakeEntityService<TEntity> : IEntityService<TEntity>
        where TEntity : Base
    {
        protected readonly IList<TEntity> entities;
        private readonly Faker<TEntity> faker;

        public FakeEntityService(Faker<TEntity> faker)
        {
            this.faker = faker;

            entities = faker.Generate(100);
        }

        public virtual void Add(TEntity entity) => entities.Add(entity);
        public virtual TEntity Get(int id) => entities.SingleOrDefault(u => u.Id == id);    
        public virtual IEnumerable<TEntity> Get() => entities;        
        public virtual void Remove(int id) => entities.Remove(Get(id));

        public virtual void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
