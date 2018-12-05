using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class PersonByAge : IComparer<Person>
    {
        public int Compare(Person firstPerson, Person secondPerson)
        {
            int result = firstPerson.Age.CompareTo(secondPerson.Age);

            return result;
        }
    }
}
