using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class Person
    {
        private string fullName;
        public int age;

        public int Age{ get; set; }

        public Person(string fullName,int age)
        {
            this.fullName = fullName;
            this.age = age;
        }
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }

        public abstract void Move();

        public static void Read()
        {
            Console.WriteLine("Read book...");
        }
    }
}
