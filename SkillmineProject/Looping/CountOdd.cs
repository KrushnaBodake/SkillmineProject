﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.Looping
{
    class CuntOdd
    {
        static void Main (string[]args)
        {
            int count = 0;
            for (int i=1; i<=20; i++)
            {
                if (i%2!=0)
                {
                    count++;
                  
                }
                
            }
             Console.WriteLine(count);
        }
    }
    class Even
    {
        static void Main(string[]args)
        {
            int count = 0;
            for (int i=1; i<=100; i++)
            {
                if(i%2==0)
                {
                    count++;
                    Console.WriteLine(i);
                }
                if (count == 10)
                {
                    
                    break;
                }


            }


        }
    }

}
