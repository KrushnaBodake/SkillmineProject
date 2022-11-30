using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.ConditionalSentences
{
    class DivisibleBy5ornotTernary    {
        static void Main(string[]args)
        {
            int num;
            Console.WriteLine("Enter Number");
            num = int.Parse(Console.ReadLine());

            string ans =(num%5== 0 ? "Number is Divisible by 5":"Number is not Divisible By 5");
            Console.WriteLine(ans);
            

        }
    }
}
