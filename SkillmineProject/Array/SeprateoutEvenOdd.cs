using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.Array
{
    class SeprateoutEvenOdd
    {
        static void Main(String[]args)
        {
            int[] arr = new int[] { 23, 12, 6, 8, 12 };
            int[] arr2 = new int[5];
            int[] arr3 = new int[5];
            int i, j = 0, k = 0;

            for( i=0; i<5; i++)
            {
                if (arr[i]%2==0)
                {
                    arr2[j] = arr[i];
                    j++;
                }
                else
                {
                    arr3[k] = arr[i];
                   k++;
                }
            }
            Console.WriteLine("Even numbers....");
            for(i=0; i<j; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            Console.WriteLine("Odd numbers....");
            for (i = 0; i < k; i++)
            {
                Console.WriteLine(arr3[i]);
            }
        }
    }
}
