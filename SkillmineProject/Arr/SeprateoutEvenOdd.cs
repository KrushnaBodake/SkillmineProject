using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.Array
{
    class SeprateoutEvenOdd
    {
        static void Main(String[]args)
        {
            int[] arr = new int[] { 23,22,11,3,6, 12, 6, 8, 12 };
           
            int Count = 0;
            int count2 = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Count++;
                }  
                else
                {
                    count2++;
                }
            }
             int[] arr2 = new int[Count];
            
            int k = 0;

            for (int i = 0; i < arr.Length; i++)
            {

               if(arr[i]%2==0)
               {
                    arr2[k] = arr[i];
                    k++;
               }

            }
            Console.WriteLine(string.Join(" ",arr2));

            int[] arr3 = new int[count2];

            int l = 0;
            for(int i=0; i <arr.Length; i++)
            {
                if(arr[i]%2!=0)
                {
                    arr3[l] = arr[i];
                    l++;
                }
            }
            Console.WriteLine(string.Join(" ",arr3));
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
