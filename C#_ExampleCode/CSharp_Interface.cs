using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Interface
{
    interface IA
    {
        void MustBeImplement(string text);
    }

    class B : IA
    {
        public void MustBeImplement(string text)
        {
            Console.WriteLine("{0} implement this method!!", text);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.MustBeImplement("B");

            //IA iaa = new IA();

            IA ia = new B();
            ia.MustBeImplement("IA");

            Console.ReadKey();
        }
    }
}
