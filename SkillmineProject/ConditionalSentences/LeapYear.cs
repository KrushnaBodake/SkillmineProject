using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.ConditionalSentences
{
    class LeapYear
    {
        static void Main(string[]argd)
        {
            Console.WriteLine("Enter the Year");
            int year = Convert.ToInt32(Console.ReadLine());

                if(((year%100!=0) && (year%100!=0)) || (year%400==0))
                {
                    Console.WriteLine("year is leap Year");
                }
                else
                {
                Console.WriteLine("year is not Leap year");
                }
                
            
        }
    }
}

