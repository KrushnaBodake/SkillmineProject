using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.ConditionalSentences
{
    class Percentage
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter mark1");
            int mark1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter mark2");
            int mark2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter mark3");
            int mark3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter mark4");
            int mark4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter mark5");
            int mark5 = int.Parse(Console.ReadLine());

            double per;
            per = (mark1 + mark2 + mark3 + mark4 + mark5)/5;

            if (per > 70)
            {
                Console.WriteLine("Grade is Distinction");
            }
            else if (per > 60 && per < 70) 
            {
                Console.WriteLine("Grade Is first Class");
            }
            else if(per>50 && per<60)
            {
                Console.WriteLine("Grade is Second Class");
            }
            else
            {
                Console.WriteLine("You Are Fail");
            }




            




        }
    }
}
