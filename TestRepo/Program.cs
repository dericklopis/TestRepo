using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            calculator.AddTwoNumbers(1, 2);
            calculator.AddTwoNumbers2();            
            Human human1 = new Human();
            human1.Talk();
            Console.ReadLine();
        }
    }
}
