using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.ArrPractice
{
    public class Class1
    {
        public void MaxMin(int[] a)
        {
            int max = a[0];
            int min = a[0];

            for (int i = 0; i < a.Length; i++)
            {
                if(a[i]>max)
                {
                    max = a[i];
                }
                else if(a[i]<min)
                {
                    min = a[i];
                }
            }
            Console.WriteLine("Max"+max);
            Console.WriteLine("min"+min);
        }

        static void Main(string[] args)
        {           
            int[] arr = new int[5];           
            Console.WriteLine("Enter Array elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Class1 c = new Class1();
            c.MaxMin(arr);
        }
    }
    public class Toggle
    {
        public void Togg(char[] ch1)
        {
            for (int i = 0; i < ch1.Length; i++)
            {
                if(ch1[i]>='a' && ch1[i]<'z')
                {
                    ch1[i] = (char) (ch1[i] - 32);
                }
                else if(ch1[i] >= 'A' && ch1[i] <= 'Z')
                {
                    ch1[i] = (char)(ch1[i] + 32);
                }
            }
            Console.WriteLine(string.Join(" ",ch1));
        }
        static void Main(string[] args)
        {
            char[] ch = new char[] { 'A', 'e', 'I', 'o', 'u' };
            Toggle t = new Toggle();
            t.Togg(ch);

        }
    }
   public class Search
    {
        public void SearchEle(int [] a,int n)
        {
            bool flag = true;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i]==n)
                {
                    flag = false;
                }
            }
            if(flag==false)
            {
                Console.WriteLine("Present");
            }
            else
            {
                Console.WriteLine("Not Present");
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 3, 4, 5, 6 };
            Console.WriteLine("enter no to find");
            int n = Convert.ToInt32(Console.ReadLine());
            Search s = new Search();
            s.SearchEle(arr, n);
        }
    }
    public class Revesarr
    {
        public void Revarr(int[]a)
        {
            int j = a.Length - 1;
            for (int i = 0; i <a.Length/2; i++)
            {              
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    j--;
            }
            Console.WriteLine(string.Join(" ",a));
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            Revesarr r = new Revesarr();
            r.Revarr(arr);

        }
    }
    public class Fre
    {
        static void Main(string[] args)
        {
            int[] a = new int[]{ 2, 3, 4, 2, 6, 3, 2 };
            

            for (int i = 0; i < a.Length; i++)
            {
                int count = 1;
                bool flag = false;
                for (int k =i-1; k >=0; k--)
                {
                    if(a[i]==a[k])
                    {
                        flag =true;
                        break;
                    }
                }
                if(flag==false)
                {
                    for (int j =i+1; j < a.Length; j++)
                    {
                        if(a[i]==a[j])
                        {
                            count++;
                        }
                    }
                   
                }
                Console.WriteLine(a[i] +" is  "+count+ " times ");
            }
        }
    }
    public class Sort
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 2, 1, 4, 8,6, 6 };

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i+1; j < a.Length; j++)
                {
                    if(a[i]>=a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", a));

        }
    }
}
