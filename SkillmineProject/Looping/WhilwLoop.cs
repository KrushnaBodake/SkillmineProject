using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.Looping
{
    class WhilwLoop
    {
        static void Main(string[]args)
        {
            int i = 1;
            while(i<=5)
            {
                Console.WriteLine("hi");
                i++;
            }
        }
    }
      // Find the sum of Digit from the number
    class WhileLoopDemo
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i <=num ; i++)
            {
                int digit = num % 10;
                sum = sum + digit;
                num = num / 10;
            }
            Console.WriteLine(sum);
            /*while (num>0)
            {
                int digit = num % 10;
                sum = sum + digit;
                num = num / 10;
            }
            Console.WriteLine(sum);*/
        }
    }
      // Print Odd Numbers only.

    class OddNoOnly
    {
        static void Main(string[]args)
        {
            int i = 1;
            while(i<=6)
            {
                if(i%2==0)
                {
                    i++;
                    continue;
                }
                Console.WriteLine(i);
                i++;
            }
        }
    }
        // Break the Loop
     class Break
    {
        static void Main(string[]args)
        {
            int i = 1;
            while(i<=10)
            {
                if (i==3)
                {
                    break;
                }
                Console.WriteLine(i);
                i++;
            }
        }
    }
    // Guessing Number.
    class GuessNo
    {
        static void Main(string[]args)
        {
            int magicnumber = 50;
            while(true)
            {
                Console.WriteLine("Enter The Number");
                int num = int.Parse(Console.ReadLine());

                if (num > magicnumber)
                {
                    Console.WriteLine("No is larger than Guessing no");
                }
                else if (num < magicnumber) 
                {
                    Console.WriteLine("No is Less Than Guessing No");
                }
                else
                {
                    Console.WriteLine("Wow Guessing No is Correct........");
                }
            }
        }
    }
    // Number is armstrong or Not
    class Armstrong
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int num = int.Parse(Console.ReadLine());
            int temp ;
            temp=num;
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum = sum + (digit * digit * digit);
                num = num / 10;
            }
           
            if (temp == sum)
            {
                Console.WriteLine("no is armstrong");
            }
            else
            {
                Console.WriteLine("not Armstrong");
            }
        }
    }
    public class Krishnamurti
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int fact = 1;
            int num = 145;
            int n = num % 10;
            
           

                for (int j = 1; j <= n; j++)
                {
                    fact = fact * j;
                    sum = sum + fact;
                }
                sum = sum + fact;
            //    int num= num /10;

            Console.WriteLine(fact);
            
        }

    }
    class Armstrong1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int num = int.Parse(Console.ReadLine());
            int temp;
            temp = num;
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                int val = 1;
                for (int i = 1; i <=3 ; i++)
                {
                    val = val * digit;
                }
                sum = sum + val;
                num = num / 10;
            }

            if (temp == sum)
            {
                Console.WriteLine("no is armstrong");
            }
            else
            {
                Console.WriteLine("not Armstrong");
            }
        }
    }











}
