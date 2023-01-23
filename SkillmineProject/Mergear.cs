using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject
{
   public  class Mergear
   {
        static void Main(string []args)
        {
            int[] a = new int[] { 3, 5, 3, 7, 4 ,5};  // 3,5,7,4
            int[] b = new int[] { 2, 4, 3, 7, 8 ,2};   // 2,4,7,8  
                                                       // 3,5,7,4,2,8
            int a1 = a.Length;
            int b1 = b.Length;
            int c1 = a1 + b1;
          
            int[] c = new int[c1];

            int d = 0;
            for(int i=0; i<c1; i++)
            {
                if (i < a1)
                {
                    c[i] = a[i];
                }
                else 
                {
                    c[i] = b[d];
                    d++;
                }          
            }
            Console.WriteLine(string.Join(" ", c));

            int zerocount = 0;
            for (int i = 0; i < c1; i++)
            {
                for (int j = i + 1; j < c1; j++)
                {
                    if (c[i] == c[j])
                    {
                        c[i] = 0;
                        zerocount++;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", c));
            Console.WriteLine("total Zero Elements: " + zerocount);


            int[] e = new int[c1 - zerocount];
            int z = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] != 0)
                {
                    e[z] = c[i];
                    z++;
                }
            }
            Console.WriteLine(string.Join(" ", e));
        }
   }
}
