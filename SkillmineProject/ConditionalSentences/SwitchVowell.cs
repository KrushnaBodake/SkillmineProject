using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.ConditionalSentences
{
    class SwitchVowell
    {
        static void Main(string[]args)
        {
            char ch1;
            
            Console.WriteLine("Enter Charcter");
            ch1= Convert.ToChar(Console.ReadLine());

            switch(ch1)
            {
                case 'a':
                    Console.WriteLine("Given Char is Vowell");
                    break;
                case 'e': 
                    Console.WriteLine("Given char is Vowell");
                    break;
                case 'i':
                    Console.WriteLine("Given Char is Vowell");
                    break;
                case 'o':
                    Console.WriteLine("Given char is Vowell");
                    break;
                case 'u':
                    Console.WriteLine("Given Char is Vowell");
                    break;
                default:
                    Console.WriteLine("Given char is Consonant");
                    break;

            }

        }
    }
}
