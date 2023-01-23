using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.PatternPractice
{
    public class Class1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <=5; j++)
                {
                    Console.Write(" "+"*");
                }
                Console.WriteLine();
            }
        }       
    }
    public class Pattern
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=5; i++)
            {
                for (int j = 1; j <=i ; j++)
                {
                    Console.Write(" "+'*');
                }
                Console.WriteLine();
            }
        }
    }
    //    1
    //    12
    //    123
    //    1234

    public class P1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write( j);
                }
                Console.WriteLine();
            }
        }

    }
/* 1
   22
   333
   4444   */

    public class P2
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=5; i++)
            {
                for (int j = 1; j <=i; j++)
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
    public class P3
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 1; i <=5; i++)
            {
                for (int j = 1; j <=i ; j++)
                {
                    count++;
                    Console.Write(count +" ");
                }
                Console.WriteLine();
            }
        }
    }
    //  1234
    //  123
    //  12
    //  1
    public class P4
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=4; i++)
            {
                for (int j = 1; j <=5-i ; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    public class P6
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = i; j <= 4; j++)
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
    public class P5
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=4; i++)
            {
                for (int j = i; j <=4; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <=i; k++)
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
    public class P7
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=4; i++)
            {
                for (int j = 2; j <=i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = i; k <=4; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
        }
    }
}
