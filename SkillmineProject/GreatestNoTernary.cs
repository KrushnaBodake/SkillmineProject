using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject
{
    class GreatestNoTernary
    {
        static void Main(string[]args)
        {
            int num1, num2, num3, max;
            num1 = 10;
            num2 = 15;
            num3 = 25;

            max = (num1 > num2 && num1 > num3) ? num1 : (num2 > num3) ? num2 : num3;

            Console.WriteLine("Greatest number" + max);

        }
    }
}
