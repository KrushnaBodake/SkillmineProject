using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.ConditionalSentences
{
    class Calculator
    {
        static void Main(string[]args)
        {
            char ch;
            do
            {
                Console.WriteLine("Enter num1");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter num2");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("(1) Addition");
                Console.WriteLine("(2) Substarction");
                Console.WriteLine("(3) Multification");
                Console.WriteLine("(4) dividation");

                Console.WriteLine("Enter the Menu Number");
                int menu = int.Parse(Console.ReadLine());


                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Add" + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("Substarction" + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("Multification" + (num1 * num2));
                        break;
                    case 4:
                        Console.WriteLine("Dividation" + (num1 / num2));
                        break;
                    default:
                        Console.WriteLine("Invalid Operator");
                        break;
                }
                Console.WriteLine("do you want to Continue");
                ch = Convert.ToChar(Console.ReadLine());
                
            }
            while ( ch== 'y' || ch == 'Y');



        }
    }
}
