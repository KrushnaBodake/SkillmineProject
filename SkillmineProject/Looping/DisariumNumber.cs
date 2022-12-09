using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.Looping
{
    class DisariumNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            int original = num;
            int count = 0;
            int sum = 0;
            while (num > 0)
            {
                num = num / 10;
                count++;
            }
            num = original;
            while (num > 0)
            {
                int power = 1;
                int r = num % 10;
                for (int i = 1; i <= count; i++)
                {
                    power = power * r;
                }
                sum = sum + power;
                count--;
                num = num / 10;
            }
            if (original == sum)
            {
                Console.WriteLine("Disarium Number");
            }
            else
            {
                Console.WriteLine("Not Disarium Number");
            }
        }
    }
    
}
