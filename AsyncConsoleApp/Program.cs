using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyAsync();
            Console.WriteLine("main");
            Console.ReadKey();
        }

        private static async void MyAsync()
        {
            var result = await Task.Run(() => "ready");
            Console.WriteLine(result);
        }
    }
}
