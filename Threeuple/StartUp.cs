using System;

namespace Threeuple
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine().Split();

            string fullName = personInfo[0] + " " + personInfo[1];
            string neighbourhood = personInfo[2];
            string town = personInfo[3];

            string[] beerInfo = Console.ReadLine().Split();

            string name = beerInfo[0];
            int liters = int.Parse(beerInfo[1]);
            bool drunkOrNot = beerInfo[2] == "drunk";

            string[] specialNumbers = Console.ReadLine().Split();

            string personName = specialNumbers[0];
            double accountBalance = double.Parse(specialNumbers[1]);
            string bankName = specialNumbers[2];

            MyTuple<string, string, string> personTuple = new MyTuple<string, string, string>(fullName, neighbourhood, town);
            MyTuple<string, int, bool> beerTuple = new MyTuple<string, int, bool>(name, liters, drunkOrNot);
            MyTuple<string, double, string> bankTuple = new MyTuple<string, double, string>(personName, accountBalance, bankName);

            Console.WriteLine(personTuple);
            Console.WriteLine(beerTuple);
            Console.WriteLine(bankTuple);
        }
    }
}
