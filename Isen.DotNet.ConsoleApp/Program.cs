using System;
using Isen.DotNet.Library;

namespace Isen.DotNet.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = Hello.Greet("Lisa");
            Console.WriteLine(result);
        }
    }
}
