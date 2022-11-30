using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.Looping
{
    class Sum1to10
    {
        static void Main(string[]args)
        {
            int i;
            int sum = 0;

            for (i=1;i<=10;i++)
            {
                sum = sum + i;

            }
            Console.WriteLine(sum);
        }       
    }
}
