using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Others
{
    internal class Student : Person
    {
        public Student(int age, string name) : base(age, name) { }


        public override void SayHi()
        {
            Console.WriteLine("I'm a student, age: " + this.getAge() + " and name: " + this.getName());
        }

        public override void SalaryCal()
        {
            Console.WriteLine("salary for Student is 0");
        }
    }
}
