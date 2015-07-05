using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Singleton
{
    class OldSingleton
    {
        public string Name { get; set; }

        private static OldSingleton _instance;        
        protected OldSingleton()
        {
        }

        public static OldSingleton Instance()
        {
            if (_instance == null)
            {
                _instance = new OldSingleton();
            }

            return _instance;
        }
    }

    // 멀티 스레드 동작시 다른 곳에서 동시에 객체에 접근하는 것을 방지
    class NewSingleton 
    {
        public string Name { get; set; }

        private static NewSingleton _instance;        
        private static object syncLock = new object();

        protected NewSingleton()
        {
        }

        public static NewSingleton Instance()
        {
            if (_instance == null)
            {
                lock (syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new NewSingleton();
                    }
                }
            }

            return _instance;
        }
    }

    // C# 기능을 이용한 싱글턴 클래스의 최적화
    sealed class OptimizeSingleton
    {
        public string Name { get; set; }

        private static readonly OptimizeSingleton _instance = new OptimizeSingleton();

        private OptimizeSingleton()
        {            
        }

        public static OptimizeSingleton Instance()
        {
            return _instance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            OldSingleton os1 = OldSingleton.Instance();
            OldSingleton os2 = OldSingleton.Instance();
            os1.Name = "This is old singleton class!!";
            Console.WriteLine(os2.Name);

            NewSingleton ns1 = NewSingleton.Instance();
            NewSingleton ns2 = NewSingleton.Instance();
            ns1.Name = "This is new singleton class!!";
            Console.WriteLine(ns2.Name);

            OptimizeSingleton ops1 = OptimizeSingleton.Instance();
            OptimizeSingleton ops2 = OptimizeSingleton.Instance();
            ops1.Name = "This is new C# optimize singleton class!!";
            Console.WriteLine(ops2.Name);
            
            Console.ReadKey();
        }
    }
}
