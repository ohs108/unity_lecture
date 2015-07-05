using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Indexers
{
    class A
    {
        private int[] array;

        public A()
        {
            array = new int[1];
        }

        public int this[int index]
        {
            get { return array[index]; }

            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine("Array Resized: {0}", array.Length);
                }

                array[index] = value;
            }
        }

        public int Length
        {
            get { return array.Length; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();

            for (int i = 0; i < 10; ++i)
            {
                a[i] = i;
            }

            for (int j = 0; j < a.Length; ++j)
            {
                Console.WriteLine(a[j]);
            }

            Console.ReadKey();
        }
    }
}
