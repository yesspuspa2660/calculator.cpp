using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanInheritance
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        public void GetNameAndAge()
        {
            Console.WriteLine("The person has name : {0} and age : {1}", Name, Age);
        }
        
    }
}