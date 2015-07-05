using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Static
{
    class A
    {
        public int a;
        public int b;

        public static int c;
        public static int d;

        public static void tell() { Console.WriteLine("I'm static method"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A obj1 = new A();
            obj1.a = 1;
            obj1.b = 2;

            A obj2 = new A();
            obj2.a = 3;
            obj2.b = 4;

            A.c = 5;
            A.d = 6;

            Console.WriteLine(obj1.a);
            Console.WriteLine(obj1.b);

            Console.WriteLine(obj2.a);
            Console.WriteLine(obj2.b);

            //Console.WriteLine(MyClass.a);
            //Console.WriteLine(MyClass.b);

            Console.WriteLine(A.c);
            Console.WriteLine(A.d);
            A.tell();

            Console.ReadKey();
        }
    }
}
