using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_BaseConstructor
{
    class A
    {
        protected string name;
        public A(string name)
        {
            this.name = name;
            Console.WriteLine("My Name is {0}", this.name);
        }
    }

    class B : A
    {
        public B(string name) : base(name)
        {
            Console.WriteLine("I am in the {0}.Class", this.name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A("a");
            B b = new B("b");

            Console.ReadKey();
        }
    }
}
