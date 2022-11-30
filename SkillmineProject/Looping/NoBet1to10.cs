using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.Looping
{
    class NoBet1to10
    {
        static void Main(string[]args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("No is Bet 75 to 61");

            for (int i=75;i>=61;i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("No is Bet 120 to 200");

            for (int i=120; i<=200;i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
