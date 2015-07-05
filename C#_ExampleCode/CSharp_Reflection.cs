using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace CSharp_Reflection
{
    class General
    {
        private string name;
        private int power;
        private int hp;

        public General()
        {
            this.name = "";
            this.power = 0;
            this.hp = 0;
        }

        public General(string name, int power, int hp)
        {
            this.name = name;
            this.power = power;
            this.hp = hp;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Power
        {
            get { return this.power; }
            set { this.power = value; }
        }

        public int HP
        {
            get { return this.hp; }
            set { this.hp = value; }
        }

        public void Print()
        {
            Console.WriteLine("장수명 : {0} POW: {1} HP : {2}", Name, Power, HP);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Type type = Type.GetType("CSharp_Reflection.General");
            MethodInfo mdInfo = type.GetMethod("Print");
            PropertyInfo nameProp = type.GetProperty("Name");
            PropertyInfo powerProp = type.GetProperty("Power");
            PropertyInfo hpProp = type.GetProperty("HP");

            object general = Activator.CreateInstance(type, "관우,", 99, 100);
            mdInfo.Invoke(general, null);

            general = Activator.CreateInstance(type);
            nameProp.SetValue(general, "여포", null);
            powerProp.SetValue(general, 100, null);
            hpProp.SetValue(general, 100, null);
            mdInfo.Invoke(general, null);

            Console.ReadKey();
        }
    }
}
