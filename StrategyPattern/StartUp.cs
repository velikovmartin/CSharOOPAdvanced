using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<Person> peopeByName = new SortedSet<Person>(new PersonByName());
            SortedSet<Person> peopeByAge = new SortedSet<Person>(new PersonByAge());

            while (n-- > 0)
            {
                string[] inputArgs = Console.ReadLine().Split();

                Person p = new Person(inputArgs[0], int.Parse(inputArgs[1]));

                peopeByName.Add(p);
                peopeByAge.Add(p);
            }

            Console.WriteLine(string.Join(Environment.NewLine, peopeByName));
            Console.WriteLine(string.Join(Environment.NewLine, peopeByAge));
        }
    }
}
