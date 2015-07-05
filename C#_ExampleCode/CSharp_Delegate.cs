using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Delegate
{
    delegate int MyDelegate(int a, int b);

    class Calculator
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            MyDelegate callback;
            callback = new MyDelegate(calc.Plus);
            Console.WriteLine(callback(2, 9));

            callback = new MyDelegate(Calculator.Minus);
            Console.WriteLine(callback(8, 3));

            Console.ReadKey();
        }
    }
}
