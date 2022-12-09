using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.Looping
{
    class WhileLoop
    {
        // count the no of digit from the number.
        static void Main(string[]args)
        {
            Console.WriteLine("enter the no");
            int num = int.Parse(Console.ReadLine());

            int count = 0;
            int i = 1;
            while(i<=num)
            {
                num = num / 10;
                count++;               
            }
            Console.WriteLine(count);
        }
    }
    class SumoddNo
    {
        static void Main(string[]args)
        {
            int sum = 0;
            int i = 1;
            while(i<=5)
            {
                sum = sum + i;
                i = i + 2;        
            }
            Console.WriteLine(sum);
        }
    }
    class Stopadd10
    {
        static void Main(string[]args)
        {
            int i = 1;
            int sum = 0;

            while(i<=20)
            {
             
                sum = sum + i;
                i++;
                if(sum==10)
                {
                    break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
