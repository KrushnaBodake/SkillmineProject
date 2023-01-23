using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.ConditionalSentences
{
    class GreatestNumberTernary
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter Number 1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number 2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number 3");
            int num3 = int.Parse(Console.ReadLine());

          /*  String ans = (num1 > num2) ? ("num1 is Greatest") : (num1 > num3) ? ("num1 is Greatest") :
           *               (num2 > num3) ? ("Num2 is Greatest") : ("Num3 is Greatest");
           *               
           *               
            Console.WriteLine(ans);*/

            int g = (num1 > num2) ? (num1 > num3 ? num1 : num3) : (num2 > num3 ? num2 : num3);
            Console.WriteLine("Greatest no is"+" "+g);
        }
    }
}
