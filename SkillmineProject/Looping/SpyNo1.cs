using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.Looping
{
    class SpyNo1
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter No");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int multi = 1;
            while(num >0)
            {
                int digit = num % 10;
                sum = sum + digit;
                multi = multi * digit;
                num = num / 10;
            }
            if(sum==multi)
            {
                Console.WriteLine("no is Spy no");
            }
            else
            {
                Console.WriteLine("no is not spy no");
            }

        }
    }
    class Trimorphicno
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter the given no");
            int num = int.Parse(Console.ReadLine());
            int i = 0;
            

            while (i < num)
            {
                int digit = (num * num * num) % 10;


                if (digit == num)
                {
                    Console.WriteLine("Number is Trimorphic");
                }
                else
                {
                    Console.WriteLine("Number is not Trimorphic");
                }

            }

        }
    }
    class Trimorphicno1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the given no");
            int num = int.Parse(Console.ReadLine());
            
            int power = 1;
            for (int i = 0; i <= 3; i++)
            {

                power = power * num;
                power = power % 10;
            }
            if (power == num)
            {
                Console.WriteLine("Number is Trimorphic");
            }
            else
            {
                Console.WriteLine("Number is not Trimorphic");
            }
            
        }
    }
}
