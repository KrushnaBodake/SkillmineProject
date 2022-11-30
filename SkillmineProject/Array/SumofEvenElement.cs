using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.Array
{
    class SumofEvenElement
    {
        static void EvenSum (int[] arr, int n)
        {
            int even = 0;

            for(int i=0; i<n; i++)
            {
                if (i % 2 == 0)
                    even += arr[i];
            }
            Console.WriteLine(even);
        }
        static public void Main(string[]args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int n = arr.Length;
            EvenSum(arr, n);
        }
            
    }
}
