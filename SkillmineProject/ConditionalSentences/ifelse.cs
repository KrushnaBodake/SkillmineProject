using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.ConditionalSentences
{
    class ifelse
    {
     static void Main(string[]args)
        {
            int num;
            Console.WriteLine("Enter Number");
            num = int.Parse(Console.ReadLine());
            if (num%2==0)
            {
                Console.WriteLine("No is Even");
            }
            else
            {
                Console.WriteLine("No is Odd");
            }
        }
    }
}
