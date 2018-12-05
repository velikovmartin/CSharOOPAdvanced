using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] inputArgs = input.Split();
                string name = inputArgs[0];
                int age = int.Parse(inputArgs[1]);
                string town = inputArgs[2];

                Person p = new Person(name, age, town);
                people.Add(p);
                input = Console.ReadLine();
            }

            int index = int.Parse(Console.ReadLine()) - 1;

            Person comparePerson = people[index];

            int equalPeople = 0;

            foreach (var p in people)
            {
                if (p.CompareTo(comparePerson) == 0)
                {
                    equalPeople++;
                }
            }

            if (equalPeople > 1)
            {
                Console.WriteLine($"{equalPeople} {people.Count - equalPeople} {people.Count}"); 
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
