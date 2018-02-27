using System;
using Isen.DotNet.Library;
using Isen.DotNet.Library.Models.Implementation;

namespace Isen.DotNet.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string world = Hello.World;
            Console.WriteLine(world);

            string greet = Hello.Greet("Lisa");
            Console.WriteLine(greet);

            string greetUpper = Hello.GreetUpper("Lisa");
            Console.WriteLine(greetUpper);*/

            var me = new Person
            {
                FirstName = "Lisa",
                LastName = "Anthonioz",
                BirthDate = new DateTime(1996, 08, 10),
                City = new City { Name = "Toulon" }
            };
            Console.WriteLine(me);
        }
    }
}
