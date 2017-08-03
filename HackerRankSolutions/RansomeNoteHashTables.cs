using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    /// <summary>
    /// Problem Source - https://www.hackerrank.com/challenges/ctci-ransom-note/problem
    /// </summary>
    class RansomeNoteHashTables
    {
        public RansomeNoteHashTables()
        {
            string[] tokens_m = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(tokens_m[0]);
            int n = Convert.ToInt32(tokens_m[1]);
            string[] magazine = Console.ReadLine().Split(' ');
            string[] ransom = Console.ReadLine().Split(' ');

            Dictionary<string, int> dictionary =
                    new Dictionary<string, int>();

            foreach (var magWord in magazine)
            {
                if (dictionary.ContainsKey(magWord))
                {
                    dictionary[magWord]++;
                }
                else
                {
                    dictionary.Add(magWord, 1);
                }
            }
            var flag = true;
            foreach (var ransomWord in ransom)
            {
                if (dictionary.ContainsKey(ransomWord))
                {
                    if (dictionary[ransomWord] == 0)
                    {
                        //Console.WriteLine("No");
                        flag = false;
                    }
                    dictionary[ransomWord]--;
                }
                else
                {
                    //Console.WriteLine("No");
                    flag = false;
                }
            }
            if (flag == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
