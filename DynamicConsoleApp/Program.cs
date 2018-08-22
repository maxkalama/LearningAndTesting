using DynamicClassLibrary;
using System;

namespace DynamicConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            new Program().Run();
        }

        private void Run()
        {
            var rep = new Repository();

            dynamic data = rep.GetPerson();
            Console.WriteLine(data.Name);

            dynamic data2 = rep.GetPersonWrappedInAnonymusType();
            Console.WriteLine(data2.Person.Name);
        }
    }
}
