using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.Looping
{
    class Stopadd
    {
        static void Main(string []args)
        {
            int sum = 0;
            int i = 1;
            while (i <= 10)
            {
                sum = sum + i;
              //  i++;

                if (sum==10)
                {
                    break;
                   
                }
            }
            Console.WriteLine(sum);
           
              

        }
    }
}
