using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.Looping
{
    class Exponent
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter base");
            int basenumber = int.Parse(Console.ReadLine());

            Console.WriteLine("enter exponent");
            int Expo = int.Parse(Console.ReadLine());

            int power = 1;
            for (int i=1;i<=Expo;i++)
            {
                power = power * basenumber;
            }
            Console.WriteLine(power);
        }     
    }
}
