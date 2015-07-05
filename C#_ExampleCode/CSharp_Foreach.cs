using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2 };
            float b = 0.0f;

            foreach (int value in a)
            {
                Console.WriteLine(value);
            }

            Console.ReadKey();
        }
    }
}
