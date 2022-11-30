using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.Array
{
    class MinValue
    {
        static void Main(string[]arg)
        {
            int i = 0;
            int small = 0;

            int[] arr = new int[5];

            Console.WriteLine("Enter array elements : ");
            for (i=0; i<arr.Length; i++)
            {
                Console.WriteLine("Element[" + (i + 1) + "]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            // assign 1st element to the small
            // compare it with other array elements
            small = arr[0];

            for(i=1; i<arr.Length; i++)
            {
                if (small>arr[i])
                {
                    small = arr[i];
                }
            }
            Console.WriteLine(" smallest element in array is : " + small);
        }
    }

    class MaxMin
    {
        static void Main(string[]args)
        {
            int[] arr = new int[5] { 99, 95, 93, 89, 87 };
            int i, max, min, n;

            // size of array
            n = 5;
            max = arr[0];
            min = arr[0];

            for (i=1; i<n; i++)
            {
                if (arr[i]>max)
                {
                    max = arr[i];
                }
                if (arr[i]<min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("max Element " + max);
            Console.WriteLine("min Element " + min);

        }
    }
}
