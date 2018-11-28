using System;

namespace Tuple
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine().Split();

            string fullName = personInfo[0] + " " + personInfo[1];
            string town = personInfo[2];

            string[] beerInfo = Console.ReadLine().Split();

            string name = beerInfo[0];
            int liters = int.Parse(beerInfo[1]);

            string[] specialNumbers = Console.ReadLine().Split();

            int specialInt = int.Parse(specialNumbers[0]);
            double specialDouble = double.Parse(specialNumbers[1]);

            MyTuple<string, string> personTuple = new MyTuple<string, string>(fullName, town);
            MyTuple<string, int> beerTuple = new MyTuple<string, int>(name, liters);
            MyTuple<int, double> specialTuple = new MyTuple<int, double>(specialInt, specialDouble);

            Console.WriteLine(personTuple);
            Console.WriteLine(beerTuple);
            Console.WriteLine(specialTuple);
        }
    }
}
