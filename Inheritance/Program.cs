using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer
                {
                    Name="Alper"
                },
                new Student
                {
                    Name="Burçin"
                },
                new Person
                {
                    Name="Sushi"
                }
            };

            foreach (var person in persons) 
            {
                Console.WriteLine(person.LastName);
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }

    class Customer:Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Departmant { get; set; }
    }
}
