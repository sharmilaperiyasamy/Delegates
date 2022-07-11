using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_DS
{
    internal class Arithmetic_Operation
    {
        public static void Addition(int a, int b)
        {
            int add = a + b;
            Console.WriteLine("Addition of two numbers : " + add);
        }
        public static void Multiplication(int a, int b)
        {
            int mul = a * b;
            Console.WriteLine("Multiplication of two numbers is : " + mul);
        }
    }
}
