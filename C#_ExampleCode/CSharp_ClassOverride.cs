using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_ClassOverride
{
    class Enemy
    {
        public virtual void Attack()
        {
            Console.WriteLine("\nAttack!!");
        }
    }

    class Zombie : Enemy
    {
        public override void Attack()
        {
            base.Attack();
            Console.WriteLine("I'm Zombie, Bite!!");
        }
    }

    class Skeleton : Enemy
    {
        public override void Attack()
        {
            base.Attack();
            Console.WriteLine("I'm Skeleton, SwordSweep!!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Enemy enemy1 = new Enemy();
            enemy1.Attack();

            Enemy enemy2 = new Zombie();
            enemy2.Attack();

            Enemy enemy3 = new Skeleton();
            enemy3.Attack();

            Console.ReadKey();
        }
    }
}
