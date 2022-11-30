using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.ConditionalSentences
{
    class PositiveNegativeZero
    {
        static void Main(string[]argss)
        {
            int num;
            Console.WriteLine("ENter the Number");
            num = Convert.ToInt32(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("No is Negative");
            }
            else if (num == 0)
            {
                Console.WriteLine("No is Zero");
            }
            else 
            {
                Console.WriteLine("No is Positive");
            }
        }
    }
}
