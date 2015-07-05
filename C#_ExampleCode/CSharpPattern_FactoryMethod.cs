using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_FactoryMethod
{  
    abstract class Enemy
    {
    }

    class Zombie : Enemy
    {
        public Zombie() { Console.WriteLine("Zombie is coming!!"); }
    }
    
    class Beast : Enemy
    {
        public Beast() { Console.WriteLine("Beast is coming!!"); }
    }

    class Skeleton : Enemy
    {
        public Skeleton() { Console.WriteLine("Skeleton is coming!!"); }
    }

    class Human : Enemy
    {
        public Human() { Console.WriteLine("Human is coming!!"); }
    }
    
    abstract class Generator
    {
        private List<Enemy> _enemys = new List<Enemy>();

        public Generator()
        {            
        }

        public List<Enemy> Enemys
        {
            get { return _enemys; }
        }
        
        public abstract void CreateEnemys();
    }

    class Stage01Generator : Generator
    {
        public override void CreateEnemys()
        {
            Enemys.Add(new Zombie());
            Enemys.Add(new Zombie());
            Enemys.Add(new Zombie());
            Enemys.Add(new Zombie());
            Enemys.Add(new Beast());
            Enemys.Add(new Beast());
        }
    }

    class Stage02Generator : Generator
    {
        public override void CreateEnemys()
        {
            Enemys.Add(new Skeleton());
            Enemys.Add(new Skeleton());
            Enemys.Add(new Skeleton());
            Enemys.Add(new Beast());
            Enemys.Add(new Human());
            Enemys.Add(new Human());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Generator[] generators = new Generator[2];
            generators[0] = new Stage01Generator();
            generators[1] = new Stage02Generator();

            foreach (Generator gen in generators)
            {
                Console.WriteLine("*** {0} ****", gen.GetType().Name);
                gen.CreateEnemys();
                Console.WriteLine("\n");
            }

            Console.ReadKey();
        }
    }
}
