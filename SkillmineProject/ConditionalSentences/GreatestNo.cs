using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.ConditionalSentences
{
    class GreatestNo
    {
        static void Main(string[]args)
        {
            int num1, num2, num3;
            num1 = 10;
            num2 = 20;
            num3 = 30;

            if (num1 > num2)
            {
                if (num1 > num3 )
                {
                    Console.WriteLine(" number 1 is Largest");
                }
                else
                {
                    Console.WriteLine(" Number 3 is Largest");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("Number 2 is Largest");
            }   
            else
            {
                Console.WriteLine("Number 3 is Largest");
            }
        }      
    }
}
