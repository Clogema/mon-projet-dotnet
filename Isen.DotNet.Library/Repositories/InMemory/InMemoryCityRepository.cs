using System.Collections.Generic;
using System.Linq;
using Isen.DotNet.Library.Models.Implementation;
using Isen.DotNet.Library.Repositories.Interfaces;

namespace Isen.DotNet.Library.Repositories.InMemory
{
    public class InMemoryCityRepository : ICityRepository
    {
        private IList<City> _cityCollection;

        public IList<City> CityCollection
        {
            get
            {
                if (_cityCollection == null)
                {
                    _cityCollection = new List<City>
                    {
                        new City { Id = 1, Name = "Toulon" },
                        new City { Id = 2, Name = "Marseille" },
                        new City { Id = 3, Name = "Annemasse" },
                        new City { Id = 4, Name = "Paris" }
                    };
                }
                return _cityCollection;
            }
        }
        public IList<City> GetAll() => CityCollection;

        public City Single(int id) =>
            CityCollection.SingleOrDefault(c => c.Id == id);

        public City Single(string name) =>
            CityCollection.SingleOrDefault(c => c.Name == name);
    }
}