using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_NoNameMethod
{
    delegate int MyDelegate(int a, int b);

    class A
    {
        public static void doSomething(string actionName, MyDelegate doAction)
        {
            int a = 3;
            int b = 5;
            Console.WriteLine("{0} {1} {2} = {3} ", a, actionName, b, doAction(a, b));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A.doSomething("+", delegate (int a, int b)
            {
                return a + b;
            });

            A.doSomething("*", delegate (int a, int b)
            {
                return a * b;
            });

            Console.ReadKey();
        }
    }
}
