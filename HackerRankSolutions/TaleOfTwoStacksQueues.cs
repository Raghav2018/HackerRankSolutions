using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class TaleOfTwoStacksQueues
    {
        /// <summary>
        /// Problem source - https://www.hackerrank.com/challenges/ctci-queue-using-two-stacks
        /// </summary>
        public TaleOfTwoStacksQueues()
        {
            string numberOfQueriesInput = Console.ReadLine();
            int numberOfQuery;
            Int32.TryParse(numberOfQueriesInput, out numberOfQuery);

            if (numberOfQuery < 1 || numberOfQuery > 100000)
            {
                System.Environment.Exit(0);
            }

            int firstCommand = 0;
            int secondValue = 0;
            List<int> list = new List<int>();

            for (int i = 0; i < numberOfQuery; i++)
            {
                var query = Console.ReadLine();
                var commands = query.Split(new char[0]);
                int commandLength = commands.Length;

                if (commands != null)
                {
                    if (commandLength == 1)
                    {
                        if (commands[0] != null)
                        {
                            Int32.TryParse(commands[0], out firstCommand);
                            if (firstCommand == 2)
                            {
                                list.RemoveAt(0);

                            }
                            if (firstCommand == 3)
                            {
                                Console.WriteLine(list[0]);
                            }
                        }

                    }
                    if (commandLength == 2)
                    {
                        if (commands[0] != null)
                        {
                            Int32.TryParse(commands[0], out firstCommand);
                        }

                        if (commands[1] != null)
                        {
                            Int32.TryParse(commands[1], out secondValue);

                            if (firstCommand == 1 && secondValue < 1000000000 && secondValue > 1)
                            {
                                list.Add(secondValue);
                            }
                        }

                    }

                    if (commandLength != 1 && commandLength != 2)
                    {
                        System.Environment.Exit(0);
                    }

                    if (firstCommand != 1 && firstCommand != 2 && firstCommand != 3)
                    {
                        System.Environment.Exit(0);
                    }

                }
            }
        }
    }
}
