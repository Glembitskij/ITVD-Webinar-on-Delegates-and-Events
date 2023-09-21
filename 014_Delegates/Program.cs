using System;
using System.Collections.Generic;

namespace _014_Delegates
{
    internal class Program
    {
        static void Main()
        {
            List<Person> people = new List<Person>()
            {
                new Person(){Name = "Ivan", Age = 20 },
                new Person(){Name = "Vova", Age = 30 },
                new Person(){Name = "Peta", Age = 40 }
            };

            List<Person> oldPeople = ConditionalMethod(people, person => person.Age > 20);

            foreach (Person person in oldPeople)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

            Console.ReadKey();
        }

        static List<Person> ConditionalMethod(List<Person> source, Func<Person, bool> conditional)
        {
            List<Person> people = new List<Person>();

            foreach (Person person in source)
            {
                if (conditional.Invoke(person))
                {
                    people.Add(person);
                }
            }
            
            return people;
        }
    }

    class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
