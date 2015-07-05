using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_ObjectType
{
    class A
    {
        public int i = 10;
    }

    class Program
    {
        static void Main(string[] args)
        {
            object a;
            a = 1;
            Console.WriteLine(a);
            Console.WriteLine(a.GetType());
            Console.WriteLine(a.ToString());

            a = new A();
            A classRef;
            classRef = (A)a;
            Console.WriteLine(classRef.i);

            Console.ReadKey();
        }
    }
}
