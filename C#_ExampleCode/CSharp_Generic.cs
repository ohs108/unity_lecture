using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Generic
{
    class A
    {
        public static void CopyArray(int[] src, int[] target)
        {
            for (int i = 0; i < src.Length; ++i)
            {
                target[i] = src[i];
            }
        }

        public static void CopyArray(string[] src, string[] target)
        {
            for (int i = 0; i < src.Length; ++i)
            {
                target[i] = src[i];
            }
        }

        // Generic Method
        public static void CopyArray<T>(T[] src, T[] target)
        {
            for (int i = 0; i < src.Length; ++i)
            {
                target[i] = src[i];
            }
        }
    }

    // Generic Class
    class B<T>
    {
        public static void CopyArray(T[] src, T[] target)
        {
            for (int i = 0; i < src.Length; ++i)
            {
                target[i] = src[i];
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] iSrc = { 1, 2, 3, 4, 5 };
            int[] iTarget = new int[5];

            string[] strSrc = { "ab", "cd", "ef", "gh", "ij" };
            string[] strTarget = new string[5];

            A.CopyArray(iSrc, iTarget);
            foreach (int i in iTarget)
                Console.WriteLine(i);

            A.CopyArray(strSrc, strTarget);
            foreach (string s in strTarget)
                Console.WriteLine(s);

            float[] fSrc = { 0.1f, 0.2f, 0.3f, 0.4f, 0.5f };
            float[] fTarget = new float[5];

            // Generic Method Example
            A.CopyArray<float>(fSrc, fTarget);
            foreach (float f in fTarget)
                Console.WriteLine(f);

            // Generic Class Example
            B<float>.CopyArray(fSrc, fTarget);
            foreach (float f in fTarget)
                Console.WriteLine(f);

            Console.ReadKey();
        }
    }
}
