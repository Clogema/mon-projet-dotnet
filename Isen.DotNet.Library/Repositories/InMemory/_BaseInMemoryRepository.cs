using System.Collections.Generic;
using System.Linq;
using Isen.DotNet.Library.Models.Base;
using Isen.DotNet.Library.Models.Implementation;
using Isen.DotNet.Library.Repositories.Interfaces;
using Microsoft.Extensions.Logging;

namespace Isen.DotNet.Library.Repositories.InMemory
{
    public abstract class _BaseInMemoryRepository<T> : BaseRepository<T>
        where T : BaseModel
    {
        protected IList<T> _modelCollection;

        public _BaseInMemoryRepository(ILogger<BaseRepository<T>> logger) : base(logger)
        {
        }

        public int NewId()
        {
            var all = GetAll().ToList();
            return all.Count == 0 ?
                1 :
                all.Max(m => m.Id) + 1;
        }

        public override void Delete(int id)
        {
            var list = ModelCollection.ToList();
            var modelToRemove = Single(id);
            list.Remove(modelToRemove);
            _modelCollection = list;
        }

        public override void Update(T model)
        {
            if (model == null) return;

            var list = ModelCollection.ToList();
            if (model.IsNew)
            {
                model.Id = NewId();
                list.Add(model);
            }
            else
            {
                // trouver le model ayant le même id dans la liste
                var existing = list.FirstOrDefault(m => m.Id == model.Id);
                existing = model;
            }
            _modelCollection = list;
        }
    }
}
