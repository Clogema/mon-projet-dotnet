using System.Collections.Generic;
using System.Linq;
using Isen.DotNet.Library.Models.Implementation;
using Isen.DotNet.Library.Repositories.Interfaces;

namespace Isen.DotNet.Library.Repositories.InMemory
{
    public class InMemoryPersonRepository : _BaseInMemoryRepository<Person>, IPersonRepository
    {
        private ICityRepository _cityRepository;
        // Constructeur avec pattern d'injection de dépendances (DI)
        public InMemoryPersonRepository(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public override IQueryable<Person> ModelCollection
        {
            get
            {
                if (_modelCollection == null)
                {
                    _modelCollection = new List<Person>
                    {
                        new Person
                        {
                            Id = 1,
                            FirstName = "Lisa",
                            LastName = "Anthonioz",
                            BirthDate = new System.DateTime(1996, 8, 10),
                            City = _cityRepository.Single("Toulon")
                        },
                        new Person
                        {
                            Id = 2,
                            FirstName = "Lolo",
                            LastName = "Rivière",
                            BirthDate = new System.DateTime(1997, 1, 17),
                            City = _cityRepository.Single("Le Pradet")
                        },
                        new Person
                        {
                            Id = 3,
                            FirstName = "Matthieu",
                            LastName = "Ruiz",
                            BirthDate = new System.DateTime(1996, 8, 13),
                            City = _cityRepository.Single("Toulon")
                        },
                        new Person
                        {
                            Id = 4,
                            FirstName = "Matthieu",
                            LastName = "Reynier",
                            BirthDate = new System.DateTime(1996, 10, 18),
                            City = _cityRepository.Single("Cuers")
                        },
                    };
                }
                return _modelCollection.AsQueryable();
            }
        }
    }
}