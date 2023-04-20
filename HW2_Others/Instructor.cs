using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW2_Others
{
    internal class Instructor : Person
    {
        public Instructor(int age, string name) : base(age, name) { }

        public override void SayHi()
        {
            Console.WriteLine("I'm an Instructor, age: " + this.getAge() + " and name: " + this.getName());
        }

        public override void SalaryCal()
        {
            Console.WriteLine("salary for instructor is 30000");
        }
    }
}
