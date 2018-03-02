using System.Collections.Generic;
using System.Linq;
using Isen.DotNet.Library.Models.Implementation;
using Isen.DotNet.Library.Repositories.Interfaces;

namespace Isen.DotNet.Library.Repositories.InMemory
{
    public class InMemoryCityRepository : _BaseInMemoryRepository<City>, ICityRepository
    {
        public override IQueryable<City> ModelCollection
        {
            get
            {
                if (_modelCollection == null)
                {
                    _modelCollection = new List<City>
                    {
                        new City { Id = 1, Name = "Toulon" },
                        new City { Id = 2, Name = "Cuers" },
                        new City { Id = 3, Name = "Annemasse" },
                        new City { Id = 4, Name = "Evian" },
                        new City { Id = 5, Name = "Le Pradet" }
                    };
                }
                return _modelCollection.AsQueryable();
            }
        }
    }
}