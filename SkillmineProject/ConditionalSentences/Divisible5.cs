using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.ConditionalSentences
{
    class Divisible5
    {
        static void Main (string []args)
        {
            int num;
            Console.WriteLine("Enter the number");
            num = int.Parse(Console.ReadLine());

            if (num%5==0)
            {
                Console.WriteLine("Numbe Is Divisible By 5");
            }
            else
            {
                Console.WriteLine("Number is not divisible by 5");
            }
        }
    }
}
