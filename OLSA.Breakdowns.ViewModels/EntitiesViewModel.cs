using OLSA.Breakdowns.IServices;
using OLSA.Breakdowns.Models;
using System.Collections.Generic;

namespace OLSA.Breakdowns.ViewModels
{
    public class EntitiesViewModel<TEntity>
        where TEntity : Base
    {
        public IEnumerable<TEntity> Entities { get; set; }
        public TEntity SelectedEntity { get; set; }
        private readonly IEntityService<TEntity> entityService;

        public EntitiesViewModel(IEntityService<TEntity> entityService)
        {
            this.entityService = entityService;
            Load();
        }

        public virtual void Load() => Entities = entityService.Get();
    }
}
