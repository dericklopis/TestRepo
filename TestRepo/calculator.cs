using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepo
{
    public class calculator
    {
        //access-modifier return-type methodName
        public static void AddTwoNumbers(int firstNumb, int sendNumb)
        {
            int result = firstNumb + sendNumb;
            Console.WriteLine("Sum of two numbers:"+ result);
        }
        public static void AddTwoNumbers2()
        {
            int firstNumb = 5;
            int sendNumb = 10;
            int result = firstNumb + sendNumb;
            Console.WriteLine("Sum of two numbers:"+ result);
        }

    }
}
