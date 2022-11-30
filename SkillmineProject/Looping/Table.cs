using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.Looping
{
    class Table
    {
        /*static void Main(string[]args)
        {
            Console.WriteLine("Enter table no");
            int sum= int.Parse(Console.ReadLine());
            int table;

            for (int i=1; i<=10; i++) 
            {
                table = (sum * i);
                Console.WriteLine(table);
            }*/

        
        static void Main(string[] args)
        {
            
            int table;
            int sum = 1;
            int sum2 = 2;
            int sum3 = 3;

            for (int i = 1; i <= 10; i++)
            {
                table = (sum * i);
                Console.WriteLine(table);
            }

        }
    }
}
