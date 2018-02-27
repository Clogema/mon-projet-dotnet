using System;
using Isen.DotNet.Library;

namespace Isen.DotNet.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string world = Hello.World;
            Console.WriteLine(world);

            string greet = Hello.Greet("Lisa");
            Console.WriteLine(greet);

            string greetUpper = Hello.GreetUpper("Lisa");
            Console.WriteLine(greetUpper);
        }
    }
}
