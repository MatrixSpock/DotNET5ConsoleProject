using System;
using Newtonsoft.Json;

namespace _NET5ConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(JsonConvert.SerializeObject(args));
        }
    }
}
