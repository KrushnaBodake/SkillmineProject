using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.ConditionalSentences
{
    class PositiveNegativeTernary
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Number");
            num = int.Parse(Console.ReadLine());

            string ans = (num > 0) ? ("Number is Positive") : (num < 0) ? ("Number is Negative") : ("Number is Zero");
            Console.WriteLine(ans);


        }
    }
}
