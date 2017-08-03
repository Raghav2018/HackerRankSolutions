using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    /// <summary>
    /// Problem Source - https://www.hackerrank.com/challenges/ctci-merge-sort/problem
    /// </summary>
    class CountingInversionsMergeSort
    {
        public CountingInversionsMergeSort()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                string[] arr_temp = Console.ReadLine().Split(' ');
                int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
                Console.WriteLine(countInversions(arr, n));
            }
        }
        private static long countInversions(int[] arr, int n)
        {
            int[] aux = (int[])arr.Clone();
            return countInversions(arr, 0, n - 1, aux);
        }

        private static long countInversions(int[] arr, int lo, int hi, int[] aux)
        {
            if (lo >= hi) return 0;

            int mid = lo + (hi - lo) / 2;

            long count = 0;
            count += countInversions(aux, lo, mid, arr);
            count += countInversions(aux, mid + 1, hi, arr);
            count += merge(arr, lo, mid, hi, aux);

            return count;
        }

        private static long merge(int[] arr, int lo, int mid, int hi, int[] aux)
        {
            long count = 0;
            int i = lo, j = mid + 1, k = lo;
            while (i <= mid || j <= hi)
            {
                if (i > mid)
                {
                    arr[k++] = aux[j++];
                }
                else if (j > hi)
                {
                    arr[k++] = aux[i++];
                }
                else if (aux[i] <= aux[j])
                {
                    arr[k++] = aux[i++];
                }
                else
                {
                    arr[k++] = aux[j++];
                    count += mid + 1 - i;
                }
            }

            return count;
        }
    }
}
