using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.ConditionalSentences
{
    class OddEven
    {
        static void Main (string[]args)
        {
            int num;
            Console.WriteLine("Enter No");
            num = int.Parse(Console.ReadLine());
            if (num%2==0)
            {
                Console.WriteLine("no is Even");
            }
            else
            {
                Console.WriteLine("No is Odd");
            }
        }
    }
}
