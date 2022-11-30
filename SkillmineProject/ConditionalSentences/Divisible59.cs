using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.ConditionalSentences
{
    class Divisible59
    {
        static void Main(string[]args)
        {
            int num;
            Console.WriteLine("Enter The no");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 3 == 0)
            {
                Console.WriteLine("no is divisible by 3");
            }
            else if (num % 9 == 0)
            {
                Console.WriteLine("No is divisibe By 9");
            }
           
         
        }
    }
}
