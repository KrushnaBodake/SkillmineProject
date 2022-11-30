using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.Looping
{
    class OddNoBet120to81
    {
        static void Main(string[]args)
        {
            int i;
            int odd;
            for (i=120;i>=81;i--)
            {
                if (i%2!=0)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
