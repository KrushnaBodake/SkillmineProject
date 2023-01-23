using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.Pattern
{
 /*  *****
     *****
     *****
     *****
     *****  */

    class Pattern
    {
        static void Main(string[]args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for(int j=1; j<=5; j++)
                {
                    Console.Write(" "+ "*" );
                }
                Console.WriteLine();
            }
        }
    }

/* *
   **
   ***
   ****
   ******/

    class Pattern2
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(" " + "*");
                }
                Console.WriteLine();
            }
        }
    }

  //  1
//    12
//    123
//    1234
    class Pattern3
    {
        static void Main(string[]args)
        {
            for(int i=1; i<=4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

/* 1
   22
   333
   4444   */
    class Pattern4
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }

  // 1
  // 23
  // 456
  // 78910

    class Pattern5
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    count++;
                    Console.Write(count);
                }
                Console.WriteLine();
            }
        }
    }
 //   1234
  //  1234
//    1234
//    1234
    class Pattern6
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

  //  1234
  //  123
  //  12
  //  1

    class Pattern7
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 5-i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

 //    *
 //   **
 //  ***
 // ****
    class Pattern8
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = i; j <= 4; j++)
                {
                    Console.Write(" ");
                }
                for(int k=1; k<=i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }


 //   *****
 //    ****
 //     ***
 //      **
 //       *

    class Pattern9
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 2; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = i; k <= 5; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

/*    *     *
      * *   *
      *   * *
      *     *    */
    class Pattern10
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if(j==1  || j==4 || i==j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                
                Console.WriteLine();
            }
        }
    }

   //   *
 //     *
 //   *****
 //     *
 //     *
    class Pattern11
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (j == 3 || i == 3 )
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }

 //   *
 //   *0
 //   *0*
 //   *0*0
 //   *0*0*

    class Pattern12
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j%2==0)
                    {
                        Console.Write("0");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
    }

 //   A
 //   A B
 //   A B C
 //   A B C D

    class Pattern13
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write ((char) (j+64)+" ");
                }
                Console.WriteLine();
            }
        }
    }

  //  D C B A
  //  D C B
  //  D C
  //  D

    class Pattern14
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = i; j <= 4; j++)
                {
                    Console.Write((char)(68+i-j) + " ");
                }
                Console.WriteLine();
            }
        }
    }
    class Pattern1
    {
        public void Pattern(char[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == 0 || j == 0 || j == a.GetUpperBound(1) || i == a.GetUpperBound(0))
                    {
                        a[i, j] = '*';
                    }
                    else
                    {
                        a[i, j] = ' ';
                    }
                }
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            /*int[,] a = { {2,3,5},
                         {4,6,7},
                         {7,6,3} };*/
            Pattern1 s = new Pattern1();
            char[,] arr1 = new char[4, 4];

            s.Pattern(arr1);


        }
        }
    class Pattern22
    {
        public void Patter(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == 0 || j == 0 || j == a.GetUpperBound(1) || i == a.GetUpperBound(0))
                    {
                        Console.Write(a[i, j]);
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] a = { {2,3,5},
                         {4,6,7},
                         {7,6,3} };
            Pattern22 s = new Pattern22();
            int[,] arr1 = new int[4, 4];
            s.Patter(arr1);
        }
    }
    class PatternN
    {
        public void Npattern(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if ((j == 0) || (j == a.GetUpperBound(1) || (i == j)))
                    {
                        Console.Write(a[i, j]);
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] a = new int[4, 4];
            Console.WriteLine("enter 2D array element");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            PatternN s = new PatternN();
            s.Npattern(a);

        }
    }
}

