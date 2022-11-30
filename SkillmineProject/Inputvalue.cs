using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject
{
    class UserInput
    {
        static void Main (string []args)
        {
            int trianglebase;
            int height;
             

            Console.WriteLine("Enter the value");
            trianglebase = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value");
            height = int.Parse(Console.ReadLine());
            int result = (height * trianglebase)*1/2;
            Console.WriteLine(result);


            


        }

    }
}
