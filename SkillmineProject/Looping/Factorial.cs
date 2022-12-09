using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.Looping
{
    class Factorial
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());

            int fact = 1;

            for (int i = 1; i <= num ;i++)
            {
                fact = fact * i;

            }
            Console.WriteLine(fact);
        }
    }
    class SumFactor
    {
        static void Main(string[]args)
        {
            int sum = 0;
            Console.WriteLine("entr no");
            int num = int.Parse(Console.ReadLine());
            for(int i=1; i<=num; i++)
            {
                if (num%i==0)
                {
                    sum = sum + i; 
                }
               // Console.WriteLine(sum);
            }
            Console.WriteLine(sum);
        }
    }
}
