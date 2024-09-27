using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pig pig = new Pig();
            pig.makeSound();
            pig.goHunt();
            // Student student1 = new Student("Hung", 21, 3.23);
            // student1.sleep();
            // student1.Move();
            // Person.Read();
            Console.ReadKey();
        }
    }

    interface IAnimal
    {
        void makeSound();
    }

    interface IPredator
    {
        void goHunt();
    }
    class Pig : IAnimal,IPredator
    {
        public void makeSound()
        {
            Console.WriteLine("Pig says euw");
        }

        public void goHunt()
        {
            Console.WriteLine("Pig go Hunt...");
        }
    }
}
