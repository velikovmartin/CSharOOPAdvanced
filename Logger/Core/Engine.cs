using System;
using System.Collections.Generic;
using System.Text;
using Logger.Appenders.Contracts;
using Logger.Core.Contracts;

namespace Logger.Core
{
    public class Engine : IEngine
    {
        private readonly ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine().Split();
                this.commandInterpreter.AddAppender(inputArgs);
            }

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] inputArgs = input.Split('|');

                this.commandInterpreter.AddMessage(inputArgs);

                input = Console.ReadLine();
            }

            this.commandInterpreter.PrintInfo();
        }
    }
}
