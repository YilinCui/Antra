using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Others
{
    internal abstract class Person
    {
        private int age{ get; set; }
        private string name { get; set; }

        public Person()
        {
            age = 0;
            name = "";
        }

        public int getAge() { return age; }

        public void setAge(int age)
        {
            this.age = age;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName() { return name; }

        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public abstract void SayHi();
        public abstract void SalaryCal();
    }
}
