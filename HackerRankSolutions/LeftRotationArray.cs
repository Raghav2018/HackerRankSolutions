using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    class LeftRotationArray
    {
        /// <summary>
        /// Problem Source - https://www.hackerrank.com/challenges/ctci-array-left-rotation
        /// </summary>
        public LeftRotationArray()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            a = leftRotate(a, k, n);
            Console.WriteLine(string.Join(" ", a));
        } 

        static int[] leftRotate(int[] arr, int d, int n)
        {
            arr = rvereseArray(arr, 0, d - 1);
            arr = rvereseArray(arr, d, n - 1);
            arr = rvereseArray(arr, 0, n - 1);
            return arr;
        }

        /*Function to reverse arr[] from index start to end*/
        static int[] rvereseArray(int[] arr, int start, int end)
        {
            int temp;
            while (start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
            return arr;
        }
    }
}
