using System;
using Isen.DotNet.Library.Repositories.InMemory;
using Isen.DotNet.Library.Repositories.Interfaces;

namespace Isen.DotNet.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ICityRepository cityRepository = new InMemoryCityRepository();
            IPersonRepository personRepository = new InMemoryPersonRepository(cityRepository);

            // Toutes les villes
            Console.WriteLine("----- Toutes les villes -----");
            foreach (var c in cityRepository.GetAll())
                Console.WriteLine(c);

            // Toutes les personnes
            Console.WriteLine("\n----- Toutes les personnes -----");
            foreach (var p in personRepository.GetAll())
                Console.WriteLine(p);

            // Toutes les personnes nées après 1996
            Console.WriteLine("\n----- Toutes les personnes nées après 1996 -----");
            var personBornAfter = personRepository.Find(p =>
            p.BirthDate.HasValue &&
            p.BirthDate.Value.Year >= 1997);
            foreach (var p in personBornAfter)
                Console.WriteLine(p);

            // Trouver toutes les peronnes avec age > 20
            Console.WriteLine("\n----- Trouver toutes les peronnes avec age > 20 -----");
            var personOlderThan = personRepository
                .Find(p =>
                    p.Age.HasValue &&
                    p.Age.Value >= 20);
            foreach (var p in personOlderThan)
                Console.WriteLine(p);

            // Toutes les villes qui contiennent un e
            Console.WriteLine("\n----- Toutes les villes qui contiennent un e -----");
            var citiesWithE = cityRepository
                .Find(c =>
                    // IndexOf : équivalent de Contains()
                    // Mais avec paramètre CurrentCultureIgnoreCase
                    c.Name.IndexOf("e", StringComparison.CurrentCultureIgnoreCase) >= 0);
            foreach (var c in citiesWithE)
                Console.WriteLine(c);

            // Effacer une ville
            Console.WriteLine("\n----- Effacer une ville -----");
            var evian = cityRepository.Single("Evian");
            cityRepository.Delete(evian);
            foreach (var c in cityRepository.GetAll())
                Console.WriteLine(c);

        }
    }
}
