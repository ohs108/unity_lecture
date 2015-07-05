using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DeepCopy
{
    class A
    {
        public int field1;
        public int field2;
    }

    class Program
    {
        static void Main(string[] args)
        {
            A source = new A();
            source.field1 = 10;
            source.field2 = 20;

            A target = source;
            target.field2 = 30;

            Console.WriteLine("{0} {1}", source.field1, source.field2);
            Console.WriteLine("{0} {1}", target.field1, target.field2);

            Console.ReadKey();
        }
    }
}
