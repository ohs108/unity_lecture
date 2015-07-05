using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Yield2
{
    class Program
    {
        public static void ShowGalaxies()
        {
            var theGalaxies = new Galaxies();
            foreach (Galaxy theGalaxy in theGalaxies.NextGalaxy)
            {
                Console.WriteLine(theGalaxy.Name + " " + theGalaxy.MegaLightYears.ToString() + "광년");
            }
        }

        public class Galaxies
        {

            public System.Collections.Generic.IEnumerable<Galaxy> NextGalaxy
            {
                get
                {
                    yield return new Galaxy { Name = "올챙이 은하", MegaLightYears = 400 };
                    yield return new Galaxy { Name = "바람개비 자리", MegaLightYears = 25 };
                    yield return new Galaxy { Name = "은하수", MegaLightYears = 0 };
                    yield return new Galaxy { Name = "안드로메다", MegaLightYears = 3 };
                }
            }

        }

        public class Galaxy
        {
            public String Name { get; set; }
            public int MegaLightYears { get; set; }
        }

        static void Main(string[] args)
        {
            ShowGalaxies();

            Console.ReadKey();
        }
    }
}
