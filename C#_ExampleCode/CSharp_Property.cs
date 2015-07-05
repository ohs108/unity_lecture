using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Property
{
    class A
    {
        //*
        private int age;
        private string name;

        public int GetAge() { return age; }
        public void SetAge(int age) { this.age = age; }
        public string GetName() { return name; }
        public void SetName(string name) { this.name = name; }
        //*/

        // Old Property;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Auto Property
        public int AAge { get; set; }
        public string AName { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();

            a.SetAge(36);
            a.SetName("Hyunseok Oh");

            Console.WriteLine("Age : {0}", a.GetAge());
            Console.WriteLine("Name : {0}", a.GetName());

            a.Age = 36;
            a.Name = "Hyunseok Oh";

            Console.WriteLine("Age : {0}", a.Age);
            Console.WriteLine("Name : {0}", a.Name);

            a.AAge = 36;
            a.AName = "Hyunseok Oh";

            Console.WriteLine("Age : {0}", a.AAge);
            Console.WriteLine("Name : {0}", a.AName);

            Console.ReadKey();
        }
    }
}
