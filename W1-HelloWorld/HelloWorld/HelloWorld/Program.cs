using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
            Console.WriteLine("Please enter your name");
            string name = getUserInput();
            Console.WriteLine($@"So..... {name} why so firsty!");

        }

        private static string getUserInput()
        {
            return Console.ReadLine();
        }
    }
}
