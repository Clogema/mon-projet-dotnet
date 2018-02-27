using System;

namespace Isen.DotNet.Library.Models.Implementation
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public City City { get; set; }

        public int? Age => BirthDate.HasValue ?
            (int?)((DateTime.Now - BirthDate.Value).Days / 365.25) :
            null;

        public string Display =>
            $"[Id = {Id}] | {FirstName} {LastName} | [Age = {Age} | City = {City}]";

        public override string ToString() => Display;
    }
}