using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.Array
{
    class Arrey
    {
        static void Main(string[]arg)
        {
            int i = 0;
            int small = 0;

            int[] arr = new int[5];

            Console.WriteLine("Enter array elements : ");
            for (i=0; i<arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            // assign 1st element to the small
            // compare it with other array elements
            small = arr[0];

            for(i=1; i<arr.Length; i++)
            {
                if (small>arr[i])
                {
                    small = arr[i];
                }
            }
            Console.WriteLine(" smallest element in array is : " + small);
        }
    }

    class MaxMin
    {
        static void Main(string[]args)
        {
            int[] arr = new int[5] { 99, 95, 93, 89, 87 };
            int i, max, min ;

          
            max = arr[0];
            min = arr[0];

            for (i=1; i<arr.Length; i++)
            {
                if (arr[i]>max)
                {
                    max = arr[i];
                }
                else if (arr[i]<min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("max Element " + max);
            Console.WriteLine("min Element " + min);

        }
    }
    class FrequencyOfElemeny
    {
       /* static void Main(string[]args)
        {
            int[] arr = new int[7];
            Console.WriteLine("Enter the number");

            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());     
            }*//*
        }*/

        static void Freq (int[]arr, int n)
        {
            bool[] visited = new bool[n];

            for (int i = 0; i < n; i++)
            {
                if (visited[i] == true)

                    continue;

                int count = 1;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        visited[j] = true;
                        count++;
                    }
                }
                Console.WriteLine(arr[i] + count);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 10, 20, 20, 20 };
            int n = arr.Length;
            Freq(arr, n);
        }

    }
    class DisplayEvenNo
    {
        public void DisplayEven(int[]a)
        {    
            for(int i=0; i<a.Length;i++)
            {
                if (a[i] %2== 0)
                {
                    Console.WriteLine( a[i]);
                }
            }
        }
        static void Main(string[]args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter integer type of Elements");
            for(int i=0; i<arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());             
            }
            Console.WriteLine(string.Join(" ", arr));
            DisplayEvenNo s = new DisplayEvenNo();
            
            s.DisplayEven(arr);
        }
    }
    class FindMaxNumber
    {
        public int FindMax(int[] a)
        {
            int max = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if ( max < a[i] )
                {
                    max = a[i];
                }

            }
            return max;
        }
        static void Main (string[]args)
        {
            int[] arr = new int[6];
            Console.WriteLine("Enter the Integer tupe of elements");
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(string.Join("  ", arr));
            FindMaxNumber s = new FindMaxNumber();
            int result = s.FindMax(arr);
            Console.WriteLine(result);
        }
    }
    class ToggleArray
    {
        public void ChangeArray(char[]ch)
        {
            for(int i=0; i<ch.Length;i++)
            {
                if( ch[i] >= 'a' && ch[i] <= 'z')
                {
                    ch[i]=(char)(ch[i] - 32);
                    Console.Write(" "+ch[i]);
                }
                else if ( ch[i] >= 'A' && ch[i] <= 'Z')
                {
                    ch[i]=(char)(ch[i] + 32);
                    Console.Write(" "+ch[i]);
                }
            }
            Console.WriteLine();
        }
        static void Main(string[]args)
        {
            char[] c = { 't', 'R', 'u', 'a', 'l' };
            Console.WriteLine(string.Join(" ", c));

            ToggleArray s = new ToggleArray();
            s.ChangeArray(c);
            //char[] mytoggle = s.ChangeArray(c);
            //Console.WriteLine(string.Join(" ",mytoggle));
        }
    }
    class SumOfEvenElement
    {
        public int SumOfEven(int[]a)
        {
            int sum = 0;
            for (int i=0; i<a.Length; i++)
            {          
                if (a[i] % 2 == 0)
                {
                    sum = sum + a[i];
                }
            }
            return sum; 
        }
        static void Main(string[]args)
        {
            int[] arr = new int[4];
            Console.WriteLine("Enter interger type elements");
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
              Console.WriteLine(string.Join(" ", arr));
            /*for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }*/
            SumOfEvenElement s = new SumOfEvenElement();
            int result = s.SumOfEven(arr);
            Console.WriteLine(result);
        }
    }
    class CountOddElement
    {
        public int CountOdd(int[]a)
        {
            int count=0;
            for (int i=0; i<a.Length; i++)
            {          
                if (a[i] % 2 != 0)
                {
                    count++;
                }
            }
            return count; 
        }
        static void Main(string[]args)
        {
            int[] arr = new int[4];
            Console.WriteLine("Enter interger type elements");
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
              Console.WriteLine(string.Join(" ", arr));
            /*for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }*/
            CountOddElement s = new CountOddElement();
            int result = s.CountOdd(arr);
            Console.WriteLine(result);
        }
    }
    class DisplayPrimeNo
    {
        int j;
        public void DisplayPrime(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int count = 1;
                //bool flag = true;
                for (j = 2; j < a[i]; j++)
                {
                    if (a[i] % j == 0)
                    {
                        // flag = false;
                        count++;
                    }
                }
                if(count==1) //(flag==true)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter integer type of Elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ", arr));
            DisplayPrimeNo s = new DisplayPrimeNo();

            s.DisplayPrime(arr);
        }
    }
    class SearchElement
    {
        public bool IsPresent(int[]a,int n)
        {
            bool flag = false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == n)
                {
                    flag = true;
                   
                    break;
                }
            }

            return flag;
        }

        static void Main(string[]args)
        {
            int[] arr = { 8, 3, 1, 6, 2 };
            Console.WriteLine("Enter Search Element");
            int num = int.Parse(Console.ReadLine());

            SearchElement s = new SearchElement();
            bool ischeck = s.IsPresent(arr, num);
            Console.WriteLine(ischeck);

            if (ischeck)
            {
                Console.WriteLine("Number is present");
            }
            else
            {
                Console.WriteLine("not present");
            }

        }
    }
    class ReverseArray
    {

        public int[] ReverseNo(int[]a)
        {
            int j = a.Length - 1;
            for(int i=0; i<a.Length/2;i++)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                j--;
            }
            return a;
        }
        static void Main(string[]args)
        {
            int[] arr = { 8, 1, 3, 5, 6, 2 };
            Console.WriteLine(string.Join(" ", arr));
            ReverseArray s = new ReverseArray();
            int[] myarray = s.ReverseNo(arr);
            Console.WriteLine(string.Join(" ", myarray));
        }
    }
    class FrequwncyOfNumber
    {
        public void Frequency(int[]a)
        {       
            for(int i=0; i<a.Length; i++)
            {
                int count = 1;
                bool isvisited = false;
                for (int k=i-1;k>=0;k--)
                {
                    if(a[i]==a[k])
                    {
                        isvisited = true;
                        
                         break;
                    }
                   
                }
                
                if (isvisited == false)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(a[i] + "  " + count);
                }
            }

        }
        static void Main(string[]args)
        {
            int[] arr = { 3, 4, 3, 5, 6, 3, 5, 6, 4 };
            FrequwncyOfNumber s = new FrequwncyOfNumber();
            s.Frequency(arr);
        }
    }
    class SortingCharArray
    {
        public char[] MySort(char[]a)
        {
            for(int i=0; i<a.Length; i++)
            {
                for (int j =i+ 1; j < a.Length; j++)
                {
                    if(a[i]>a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = (char)(temp);
                    }
                }
            }
            return a;
        }
        static void Main(string[]args)
        {
            char[] arr = { 'a','c','f','e'};
            Console.WriteLine(string.Join("  ", arr));

            SortingCharArray s = new SortingCharArray();
            
            Console.WriteLine("........" + string.Join(" ", s.MySort(arr)));
        }
    }
    class SortingArray
    {
        public int[] MySort(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            return a;
        }
        static void Main(string[] args)
        {
            int [] arr = { 4,7,3,8,9,6 };
            Console.WriteLine(string.Join("  ", arr));

            SortingArray s = new SortingArray();

            Console.WriteLine("........" + string.Join(" ", s.MySort(arr)));
        }
    }
    class AssDescArray
    {
        public int[] Display(int[]a)
        {
            int temp;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i+1; j < a.Length; j++)
                {
                    if(i<a.Length/2)
                    {
                        if(a[i]>a[j])
                        {
                            temp = a[j];
                            a[j] = a[i];
                            a[i] = temp;
                        }
                    }
                    else
                    {
                        if (a[i] < a[j])
                        {
                            temp = a[j];
                            a[j] = a[i];
                            a[i] = temp;
                        }
                    }
                }
               
            }
            return a;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Size");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[size];
            Console.WriteLine("Enter array Element");
            for(int i=0; i<a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            AssDescArray s = new AssDescArray();
            int[] ara = s.Display(a);

            Console.WriteLine("....." + string.Join(" ", ara));
        }
    }
    class RepalaceaElementByAlternateChar
    {
        public void Alternate(char[] ch)
        {
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i]=='y' || ch[i] =='Y' || ch[i]=='z'|| ch[i]=='Z')
                {
                   Console.Write( ch[i] = (char)(ch[i] - 24) );
                }
                else 
                {
                   Console.Write( ch[i] = (char)(ch[i] + 2));
                }
            }
            
        }
        static void Main(string[] args)
        {
            char[] c = { 't', 'R', 'u', 'a', 'l' };
            Console.WriteLine(string.Join(" ", c));

            RepalaceaElementByAlternateChar s = new RepalaceaElementByAlternateChar();
             s.Alternate(c);
            //Console.WriteLine(string.Join(" ", ));
        }
    }
    class DisplayEvenPositionElement
    {
        public void Alternat(char[] ch)
        {
            for (int i = 1; i < ch.Length; i=i+2)
            {
                Console.WriteLine(ch[i]);  
            }
        }

        static void Main(string[] args)
        {
            char[] c = { 't', 'R', 'u', 'a', 'l' };
            Console.WriteLine(string.Join(" ", c));

            DisplayEvenPositionElement s = new DisplayEvenPositionElement();
            s.Alternat(c);
            //Console.WriteLine(string.Join(" ", ));
        }
    }
     class DisplayEvenOdd
    {
        public void EvenOdd(int[]a)
        {    
            for(int i=0; i<a.Length;i++)
            {
                if (a[i] %2== 0)
                {
                    Console.WriteLine("Even Numbers  :"+ a[i]);
                }
                
                else
                {
                    Console.WriteLine("Odd Numbers   :" + a[i]);
                }
                
            }
        }

        static void Main(string[]args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter integer type of Elements");
            for(int i=0; i<arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());             
            }
            Console.WriteLine(string.Join(" ", arr));
            DisplayEvenOdd s = new DisplayEvenOdd();
            
            s.EvenOdd(arr);
        }
     }

    class RepalaceaElementBySq
    {
        public void Square(int[] a)
        {

            for (int i = 0; i < a.Length; i++)
            { 
                  if (a[i]<0)
                  {
                    a[i] = a[i - 1]* a[i - 1];
                  }
                Console.Write(a[i]+" ");


            }

        }
        static void Main(string[] args)
        {
            int[] a = {2,-3,7,-5,1 };
            Console.WriteLine(string.Join(" ", a));

            RepalaceaElementBySq s = new RepalaceaElementBySq();
            s.Square(a);
            
        }
    }
    public class Exercise8
    {
        public static void Main()
        {
            int[] arr1 = new int[100];
            int[] fr1 = new int[100];
            int n, i, j, ctr;


            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
                fr1[i] = -1;
            }
            for (i = 0; i < n; i++)
            {
                ctr = 1;
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        ctr++;
                        fr1[j] = 0;
                    }
                }

                if (fr1[i] != 0)
                {
                    fr1[i] = ctr;
                }
            }
            Console.Write("\nThe frequency of all elements of the array : \n");
            for (i = 0; i < n; i++)
            {
                if (fr1[i] != 0)
                {
                    Console.Write("{0} occurs {1} times\n", arr1[i], fr1[i]);
                }
            }
        }
    }
    
   
}
