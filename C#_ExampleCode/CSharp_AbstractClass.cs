using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_AbstractClass
{
    abstract class A
    {
        private string text;
        public void WriteTextToConsole(string text)
        {
            Console.WriteLine(text);
        }

        public abstract void MustBeImplemented(string text);
    }

    class B : A
    {
        public override void MustBeImplemented(string text)
        {
            Console.WriteLine("{0} implement this method", text);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.WriteTextToConsole("B");
            b.MustBeImplemented("B");

            //A a = new A();

            A a = new B();
            a.WriteTextToConsole("A");
            a.MustBeImplemented("A");

            Console.ReadKey();
        }
    }
}
