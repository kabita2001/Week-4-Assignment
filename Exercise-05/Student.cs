using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_05
{
    internal class Student
    {
        private string name;
        private int age;
        private string major;

        public Student(string name, int age, string major) 
        { 
            this.name = name;
            this.age = age;
            this.major = major;

        }

        public void Introduce() 
        {
            Console.WriteLine($"Hi, My name is {name}, I am {age}years old, My major is {major}");
        }
            


    }
}
