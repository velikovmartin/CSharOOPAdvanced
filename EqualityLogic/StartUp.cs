using System;
using System.Collections.Generic;

namespace EqualityLogic
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<Person> sortedPeople = new SortedSet<Person>();
            SortedSet<Person> peopleByHash = new SortedSet<Person>();

            while (n-- > 0)
            {
                string[] inputArgs = Console.ReadLine().Split();

                Person p = new Person(inputArgs[0], int.Parse(inputArgs[1]));

                sortedPeople.Add(p);
                peopleByHash.Add(p);
            }

            Console.WriteLine(string.Join(Environment.NewLine, sortedPeople.Count));
            Console.WriteLine(string.Join(Environment.NewLine, peopleByHash.Count));
        }
    }
}
