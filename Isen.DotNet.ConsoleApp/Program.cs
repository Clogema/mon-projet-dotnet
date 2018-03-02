using System;
using Isen.DotNet.Library.Models.Implementation;
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

            // Etat Initial des villes
            Console.WriteLine("\n------ Etat Initial -----");
            foreach (var c in cityRepository.GetAll()) Console.WriteLine(c);

            // Ajouter une ville
            Console.WriteLine("\n------ Ajouter une ville -----");
            var cannes = new City { Name = "Cannes" };
            cityRepository.Update(cannes);

            foreach (var c in cityRepository.GetAll()) Console.WriteLine(c);

            // Mettre à jour une ville
            Console.WriteLine("\n------ Mettre à jour une ville -----");
            var evian = cityRepository.Single("Evian");
            if (evian != null)
            {
                evian.Name += " les bains";
                cityRepository.Update(evian);
                foreach (var c in cityRepository.GetAll()) Console.WriteLine(c);
            }

            // ajout et mis à jour dans une même update
            Console.WriteLine("\n------ Ajout et mis à jour dans une même update -----");
            var lyon = new City { Name = "Lyon" };
            if (evian != null) evian.Name = "Evian";
            cityRepository.UpdateRange(lyon, evian);
            foreach (var c in cityRepository.GetAll()) Console.WriteLine(c);

            // Ajout et mise à jour d'une personne
            Console.WriteLine("\n------ Ajout et mis à jour d'une personne -----");
            var marine = new Person
            {
                FirstName = "Marine",
                LastName = "Accart",
                BirthDate = new DateTime(1996, 5, 31),
                City = cityRepository.Single("Toulon")
            };
            var person2 = personRepository.Single(2);
            person2.BirthDate = person2.BirthDate.Value.AddYears(-100);
            personRepository.UpdateRange(marine, person2);
            foreach (var p in personRepository.GetAll()) Console.WriteLine(p);
        }
    }
}
