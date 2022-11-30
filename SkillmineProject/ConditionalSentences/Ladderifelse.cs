using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.ConditionalSentences
{
    class Ladderifelse
    {
        static void Main(string []args)
        {
            int ch;
            Console.WriteLine("Enter the Char");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch=='a')
            {
                Console.WriteLine("Vowel1)");
            }
            else if (ch=='e')
            {
                Console.WriteLine("vowel2");
            }
            else if (ch=='i')
            {
                Console.WriteLine("Vowel3");
            }

        }
    }
}
