using SharedClassLibrary;
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var sharedClassMember = new SharedClass();
            sharedClassMember.SharedMethod();

            Console.Write("anykey to exit...");
            Console.ReadKey();
        }
    }
}
