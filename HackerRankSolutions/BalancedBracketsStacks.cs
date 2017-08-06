using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    /// <summary>
    /// Problem source - https://www.hackerrank.com/challenges/ctci-balanced-brackets
    /// </summary>
    class BalancedBracketsStacks
    {
        public BalancedBracketsStacks()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            var stringArray = new string[t];
            for (int a0 = 0; a0 < t; a0++)
            {
                stringArray[a0] = Console.ReadLine();
            }
            for (int a0 = 0; a0 < t; a0++)
            {
                var flag = IsProperlyNested(stringArray[a0]);
                if (flag == true)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            Console.ReadKey();
        }

        private static bool IsProperlyNested(string bracketString)
        {
            Stack<char> stack = new Stack<char>();

            foreach (var character in bracketString)
            {
                if (character.Equals('(') || character.Equals('{') || character.Equals('['))
                {
                    stack.Push(character);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    var recentCharacter = stack.Pop();
                    if (!IsValid(recentCharacter, character))
                    {
                        return false;
                    }
                }
            }
            if (stack.Count > 0)
            {
                return false;
            }
            return true;
        }

        private static bool IsValid(char left, char right)
        {
            if (left == '(' && right == ')')
                return true;

            if (left == '[' && right == ']')
                return true;

            if (left == '{' && right == '}')
                return true;

            return false;
        }
    }
}
