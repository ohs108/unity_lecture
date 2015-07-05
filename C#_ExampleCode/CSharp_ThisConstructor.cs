using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_ThisConstructor
{
    class A
    {
        int a, b, c;

        /*
        public A()
        {
            this.a = 1234;
        }

        public A(int b)
        {
            this.a = 1234;
            this.b = b;
        }

        public A(int b, int c)
        {
            this.a = 1234;
            this.b = b;
            this.c = c;
        }
        //*/

        //*
        public A()
        {
            this.a = 1234;
        }

        public A(int b) : this()
        {
            this.b = b;
        }

        public A(int b, int c) : this(b)
        {
            this.c = c;
        }
        //*/

        public void printFields()
        {
            Console.WriteLine("a:{0}, b:{1}, c:{2}", a, b, c);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A obj1 = new A();
            obj1.printFields();

            A obj2 = new A(567);
            obj2.printFields();

            A obj3 = new A(8, 9);
            obj3.printFields(); obj1 = new A();

            Console.ReadKey();
        }
    }
}
