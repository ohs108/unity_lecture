using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_LINQ
{
    class General
    {
        public string Name { get; set; }
        public int Power { get; set; }
        public int HP { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            General[] generals = {
                new General() {Name = "유비", Power = 75, HP = 100},
                new General() {Name = "관우", Power = 98, HP = 100},
                new General() {Name = "장비", Power = 99, HP = 100},
                new General() {Name = "간옹", Power = 45, HP = 49},
                new General() {Name = "미축", Power = 32, HP = 30}
            };

            var listGenerals = from general in generals
                               where general.HP > 50
                               orderby general.Power
                               select new { general.Name, general.HP };

            foreach (var g in listGenerals)
            {
                Console.WriteLine("장수명 : {0} HP : {1}", g.Name, g.HP);
            }

            Console.ReadKey();
        }
    }
}
