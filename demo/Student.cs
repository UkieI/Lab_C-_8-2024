using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student : Person
    {
        private double gpa;
        public double Gpa { get; set; }

        public Student(string fullName,int age,double gpa) : base(fullName, age)
        {
            this.gpa = gpa;
        }
        public override void Move()
        {
            Console.WriteLine("Move by motorbike");
        }
    }
}
