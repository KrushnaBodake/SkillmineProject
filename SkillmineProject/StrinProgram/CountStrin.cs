using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.StrinProgram
{
    public class CountStrin
    {
        static void Main(string[] args)
        {
            String str;
            Console.WriteLine("Enter a String");
            str = Console.ReadLine();
            int l = 0;
            int count = 1;

            while(l<str.Length-1)
            {
                if(str[l]==' '||str[l]=='\n')
                {
                    count++;
                }
                l++;
            }
            Console.WriteLine($"count: {count}");
        }
    }
    public class CountElementsStrin
    {
        static void Main(string[] args)
        {
            String str;
            Console.WriteLine("Enter a String");
            str = Console.ReadLine();
            
            int count = 0;
            string[] str1 = str.Split();
            for (int i = 0; i < str1.Length; i++)
            {
                char[] ch = str1[i].ToCharArray();
                for (int j = 0; j <ch.Length; j++)
                {
                    count++;
                }
            }
            Console.WriteLine($"count: {count}");


        }
    }
    public class CountNoString
    {
        
        static void Main(string[] args)
        {
            String s = "india is my country";
            int count = 0;
            String[] s1 = s.Split(" ");
            Console.WriteLine(s1.Length);
            for (int i = 0; i < s1.Length; i++)
            {
               // Console.WriteLine(s[i]);
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
