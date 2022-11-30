using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.ConditionalSentences
{
    class SwithEvenOdd
    {
       static void Main (string[]args)
        {
            int num;
            Console.WriteLine("Enter Number");
            num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Number is Even" + (num % 2 == 0));
                    break;
                default:
                    Console.WriteLine("number is Odd");
                    break;
            }
        }
    }
}
