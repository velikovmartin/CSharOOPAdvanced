using System;
using System.Linq;

namespace Collection
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split().Skip(1).ToArray();

            ListyIterator<string> list = new ListyIterator<string>(data);

            string input = Console.ReadLine();

            while (input != "END")
            {
                switch (input)
                {
                    case "Move":
                        Console.WriteLine(list.Move());
                        break;
                    case "Print":
                        try
                        {
                            list.Print();
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "HasNext":
                        Console.WriteLine(list.HasNext());
                        break;
                    case "PrintAll":
                        try
                        {
                            list.PrintAll();
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
