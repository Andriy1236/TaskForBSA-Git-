using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Addition(1, 2));
            Console.WriteLine(Calculator.Substact(5, 1));
            Greeting();
        }

        public static void Greeting()
        {
            Console.WriteLine("Hello!!!");
        }
    }
}
