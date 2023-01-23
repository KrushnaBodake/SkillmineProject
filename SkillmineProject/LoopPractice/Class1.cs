using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.LoopPractice
{
   public  class Class1
   {
       
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int num = 8;
            for (int i = 0; i <=num; i++)
            {
                Console.WriteLine(a);
                int c = a + b;
                a = b;
                b = c;
              
            }
        }
        /*static void Main(string[] args)
        {
            Console.WriteLine("enter num");
            int num = Convert.ToInt32(Console.ReadLine());
            Class1 c = new Class1();
            int result = c.Fibonasi(num);
            Console.WriteLine(result);
        }*/
   }
    public class Spy
    {
        static void Main(string[] args)
        {
            int num = 1124;
            int sum = 0;
            int mul = 1;
            while (num>0)
            {
                int digit = num % 10;
                sum = sum + digit;
                mul = mul * digit;
                num = num / 10;
            }
            if(sum==mul)
            {
                Console.WriteLine("Spy no");
            }
            else
            {
                Console.WriteLine("not spy no");
            }
        }
        
    }
    public class Dis
    {
        static void Main(string[] args)
        {
            int count = 0;
            int num = 135;
            int orignal = num;
           
            int sum = 0;
            

            while(num>0)
            {
                num = num / 10;
                count++;
            }
             num = orignal;
            while(num>0)
            {
                int mul = 1;
                int digit = num % 10;
                for (int i = 0; i <count ; i++)
                {
                    mul = mul*digit;
                }
                sum = sum + mul;
                count--;
                num = num / 10;
                
            }
            if(sum==orignal)
            {
                Console.WriteLine("Dis");
            }
            else
            {
                Console.WriteLine("Not Disarium Number");
            }
        }
      
    }
    public class Tri
    { 
        static void Main(string[] args)
        {
            int power=1;
            int count = 0;
            Console.WriteLine("Enter no");
            int num = Convert.ToInt32(Console.ReadLine());
            int original = num;

            num = original;         
            int digit = num % 10;
            for (int i = 1; i <=3; i++)
            {
                    power = power * digit;
                    power = power % 10;               
            }           
            if(power==num)
            {
                Console.WriteLine("Trimorphic");
            }
            else
            {
                Console.WriteLine("Not Trimorphic");
            }

        }
    }
    public class Kri
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Krish no");
            int num = Convert.ToInt32(Console.ReadLine());
            
            int sum = 0;
            int temp = num;

            while(num>0)
            {
                int fact = 1;
                int digit = num % 10;
                for (int i = 1; i <= digit; i++)
                {
                    fact = fact * i;
                }
                sum = sum + fact;
                num = num / 10;
            }
             num=temp;
            if(sum==num)
            {
                Console.WriteLine("Krishn no");
            }
            else
            {
                Console.WriteLine("No");
            }
          
        }
    }
    public class Arm
    {
        static void Main(string[] args)
        {
            int num = 371;
            int sum = 0;
            int temp = num;

            while(num>0)
            {
                int power = 1;
                int digit = num % 10;
                for (int i = 1; i <= 3; i++)
                {
                    power = power * digit;
                }
                sum = sum + power;
                num = num / 10;
            }
            Console.WriteLine(num + " "+ sum);
            num = temp;
            if(sum==num)
            {
                Console.WriteLine("Arm ");
            }
            else
            {
                Console.WriteLine(" no Arm");
            }

        }
    }
    public class SumOfDigit
    {
        static void Main(string[] args)
        {
            int num = 56;
            int sum = 0;

            while(num>0)
            {
                int digit = num % 10;
                sum = sum + digit;
                num = num / 10;
            }
            Console.WriteLine(sum);

        }      
    }
    public class Rever
    {
        static void Main(string[] args)
        {
            int num = 654321;
            int rev = 0;

            while(num>0)
            {
                int digit = num % 10;
                rev = (rev * 10) + digit;
                num = num / 10;
            }
            Console.WriteLine(rev);
        }
    }
    public class Count
    {
        static void Main(string[] args)
        {
            int num = 245;
            int count = 0;

            while(num>0)
            {
                count++;
                num = num / 10;
            }
            Console.WriteLine(count);
        }
    }
    public class SumOdd
    {
        static void Main(string[] args)
        {
            int num = 4237;
            int sum = 0;

            for (int i = 1; i <=num; i++)
            {
                int digit = num % 10;
                if(digit %2 !=0)
                {
                    sum = sum + digit;
                }
                num=num / 10;
            }
            Console.WriteLine(sum);
        }
    }
    public class SumFactor
    {
        static void Main(string[] args)
        {
            int num = 10;
            int sum = 0;

            for (int i = 1; i <=num ; i++)
            {
                if(num%i==0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);
        }
    }
    public class Expo
    {
        static void Main(string[] args)
        {
            int baseno = 2;
            int expo = 3;
            int digit = 1;

            for (int i = 1; i <=expo; i++)
            {                
                digit = digit * baseno;
            }
            Console.WriteLine(digit);
        }
    }
}
