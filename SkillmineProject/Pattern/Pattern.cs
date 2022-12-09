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
}

