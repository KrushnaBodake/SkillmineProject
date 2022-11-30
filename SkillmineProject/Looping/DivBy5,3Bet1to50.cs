using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.Looping
{
    class DivBy5_3Bet1to50
    {
        static void Main(string[]args)
        {
            

            for (int i=1; i<=50; i++)
            {
                if (i%5==0 && i % 3 == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
    class SkipNoDivisibleby5
    {
        static void Main(string[]args)
        {
            int i = 1;
            while(i<=50)
            {
                if (i % 5 == 0)
                {
                    i++;
                    continue;
                }
                Console.WriteLine(i);
                i++;

            }
           
        }
    }
    
}
