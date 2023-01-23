using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.Array
{
    class Arrey
    {
        static void Main(string[] arg)
        {
            int i = 0;
            int small = 0;

            int[] arr = new int[5];

            Console.WriteLine("Enter array elements : ");
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            // assign 1st element to the small
            // compare it with other array elements
            small = arr[0];

            for (i = 1; i < arr.Length; i++)
            {
                if (small > arr[i])
                {
                    small = arr[i];
                }
            }
            Console.WriteLine(" smallest element in array is : " + small);
        }
    }

    class MaxMin
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 99, 95, 93, 89, 87 };
            int i, max, min;


            max = arr[0];
            min = arr[0];

            for (i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                else if (arr[i] < min)
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

        static void Freq(int[] arr, int n)
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
        public void DisplayEven(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
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
                if (max < a[i])
                {
                    max = a[i];
                }

            }
            return max;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            Console.WriteLine("Enter the Integer tupe of elements");
            for (int i = 0; i < arr.Length; i++)
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
        public void ChangeArray(char[] ch)
        {
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] >= 'a' && ch[i] <= 'z')
                {
                    ch[i] = (char)(ch[i] - 32);
                    Console.Write(" " + ch[i]);
                }
                else if (ch[i] >= 'A' && ch[i] <= 'Z')
                {
                    ch[i] = (char)(ch[i] + 32);
                    Console.Write(" " + ch[i]);
                }
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
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
        public int SumOfEven(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    sum = sum + a[i];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[4];
            Console.WriteLine("Enter interger type elements");
            for (int i = 0; i < arr.Length; i++)
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
        public int CountOdd(int[] a)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[4];
            Console.WriteLine("Enter interger type elements");
            for (int i = 0; i < arr.Length; i++)
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
                for (j = 1; j <= a[i]; j++)
                {
                    if (a[i] % j == 0)
                    {
                        // flag = false;
                        count++;
                    }
                }
                if (count == 3) //(flag==true)
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
        public void IsPresent(int[] a, int n)
        {
            bool flag = false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == n)
                {
                     flag = true;
                    Console.WriteLine("Number is present");
                    break;
                }
            }
            if (flag == true)
            {
                Console.WriteLine("Number is present");
            }
            else
            {
                Console.WriteLine("not present");
            }

            Console.WriteLine(flag);
        }

        static void Main(string[] args)
        {
            int[] arr = { 8, 3, 1, 6, 2 };
            Console.WriteLine("Enter Search Element");
            int num = int.Parse(Console.ReadLine());

            SearchElement s = new SearchElement();
            //  bool ischeck = s.IsPresent(arr, num);
            s.IsPresent(arr, 3);
            /*  Console.WriteLine(ischeck);

              if (flag==true)
                  Console.WriteLine("Number is present");
              }
              else
              {
                  Console.WriteLine("not present");
              }*/

        }
    }
    class ReverseArray
    {
        public int[] ReverseNo(int[] a)
        {
            int j = a.Length - 1;
            for (int i = 0; i < a.Length / 2; i++)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                j--;
            }
            return a;
        }
        static void Main(string[] args)
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
        public void Frequency(int [] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                
                int count = 1;
                bool isvisited = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (a[i] == a[k])
                    {
                       // Console.WriteLine(a[k]);
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
        static void Main(string[] args)
        {
              int[] arr = { 3, 4, 3, 3, 6 };
           // String ss = " Prakash Bodke Latur";
            FrequwncyOfNumber s = new FrequwncyOfNumber();
            s.Frequency(arr);
        }
    }
    public class Cha
    {
        public void Char1()
        {
            String s1 = "India is my countey and India is my love";
            String[] s2=s1.Split();
            Console.WriteLine(s1);

            for (int i = 0; i < s2.Length; i++)
            {
                int count = 1;
                bool isvisit = false;

                for (int k = i - 1; k >= 0; k--)
                {
                    if (s2[i] == s2[k])
                    {
                        isvisit = true;
                        break;
                    }
                }


                if (isvisit == false)
                {
                    for (int j = i + 1; j < s2.Length; j++)
                    {
                        if (s2[i] == s2[j])
                        {
                            count++;
                        }

                    }
                    
                    if (count >= 2)
                    {
                       
                        Console.WriteLine(s2[i] );
                    }
                }

            }

        }
        static void Main(string[] args)
        {
            Cha c = new Cha();
            c.Char1();
        }
    }
    class SortingCharArray
    {
        public char[] MySort(char[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = (char)(temp);
                    }
                }
            }
            return a;
        }
        static void Main(string[] args)
        {
            char[] arr = { 'a', 'c', 'f', 'e' };
            Console.WriteLine(string.Join("  ", arr));

            SortingCharArray s = new SortingCharArray();

            Console.WriteLine("........" + string.Join(" ", s.MySort(arr)));
        }
    }
    class SortingArray
    {
        public void MySort(int[] a)
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
                Console.Write(a[i]);
            }
            //  return a;
        }
        static void Main(string[] args)
        {
            int[] arr = { 4, 7, 3, 8, 9, 6 };
            Console.WriteLine(string.Join("  ", arr));

            SortingArray s = new SortingArray();
            s.MySort(arr);
            //Console.WriteLine("........" + string.Join(" ", s.MySort(arr)));
        }
    }
    class AssDescArray
    {
        public int[] Display(int[] a)
        {
            int temp;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (i < a.Length / 2)
                    {
                        if (a[i] > a[j])
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
            for (int i = 0; i < a.Length; i++)
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
                if (ch[i] == 'y' || ch[i] == 'Y' || ch[i] == 'z' || ch[i] == 'Z')
                {
                    Console.Write(ch[i] = (char)(ch[i] - 24));
                }
                else
                {
                    Console.Write(ch[i] = (char)(ch[i] + 2));
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
            for (int i = 1; i < ch.Length; i = i + 2)
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
        public void EvenOdd(int[] a)
        {
            int[] b=new int[5];
            int c = 0;
           
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] % 2 == 0)
                    {
                        b[c] = a[i];
                        c++;
                    }

                    else if (a[i] % 2 != 0)
                    {
                        Console.WriteLine("Odd Numbers   :" + a[i]);
                    }
                   
                }
            Console.WriteLine("Even numbers");
            Console.Write(string.Join( " ", b));


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
                if (a[0] < 0)
                {
                    a[0] = a[a.Length - 1] * a[a.Length - 1];
                }
                else if (a[i] < 0)
                {
                    a[i] = a[i - 1] * a[i - 1];
                }
               
                Console.Write(a[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            int[] a = { -2, 3, 7, -5,2 };
            Console.WriteLine(string.Join(" ", a));

            RepalaceaElementBySq s = new RepalaceaElementBySq();
            s.Square(a);

        }
    }
    public class DuplicateWord
    {
        public static void Main()
        {
            String string1 = "India is my country and india is my love";
            int count;

            //Converts the string into lowercase  
            string1 = string1.ToLower();

            //Split the string into words using built-in function  
            String[] words = string1.Split(' ');

            Console.WriteLine("Duplicate words in a given string : ");
            for (int i = 0; i < words.Length; i++)
            {
                count = 1;
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[i].Equals(words[j]))
                    {
                        count++;
                        //Set words[j] to 0 to avoid printing visited word  
                        words[j] = "0";
                       
                    }
                    
                }

                //Displays the duplicate word if count is greater than 1  
                if (count > 1 && words[i] != "0")
                    Console.WriteLine(words[i]);
            }
           
        }

    }
    public class AddArrae
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] arr2 = new int[] { 7, 8, 9 };
            int[] arr3 = new int[9];
            int i = 0, j = 0, k = 0;

            while (i<arr1.Length && j<arr2.Length)
            {
                arr3[k++] = arr1[i++];
                arr3[k++] = arr2[j++];
               
            }
            while(i<arr1.Length)
            {
                arr3[k++] = arr1[i++];
               
            }
            while(j<arr2.Length)
            {
                arr3[k++] = arr2[j++];
               
            }

           Console.WriteLine(string.Join(' ',arr3));
        }
    }
    public class VowelandConsonants
    {
        public static void Main()
        {
            string inputstring;
            int i, len, vowels, consonants;

            inputstring = "KrishnaBodake";
            vowels = 0;
            consonants = 0;
           
            // Iterating the string from left to right
            for (i = 0; i < inputstring.Length; i++)
            {

                // Check if the character is a vowel
                if (inputstring[i] == 'a' || inputstring[i] == 'e' ||
                    inputstring[i] == 'i' || inputstring[i] == 'o' ||
                    inputstring[i] == 'u' || inputstring[i] == 'A' ||
                    inputstring[i] == 'E' || inputstring[i] == 'I' ||
                    inputstring[i] == 'O' || inputstring[i] == 'U')
                {
                    // Increment the vowels
                    vowels++;
                }
                // Check if the character is a alphabet
                // other than vowels
                else if ((inputstring[i] >= 'a' && inputstring[i] <= 'z') ||
                        (inputstring[i] >= 'A' && inputstring[i] <= 'Z'))
                {
                    // Increment the consonants
                    consonants++;
                }
            }
            // Display the count of vowels and consonant
            Console.WriteLine("count of vowel = " + vowels);
            Console.WriteLine("count of consonant = " + consonants);
        }
    }
    public class Exercise7
    {
        public static void Main()
        {
            
            int alp, digit, splch, i;
            alp = digit = splch = i = 0;

           String str = " Hi@Hellow123";
            
            // Checks each character of string

            while (i < str.Length)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    alp++;
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    digit++;
                }
                else
                {
                    splch++;
                }

                i++;
            }

            Console.Write("Number of Alphabets in the string is : {0}\n", alp);
            Console.Write("Number of Digits in the string is : {0}\n", digit);
            Console.Write("Number of Special characters in the string is : {0}\n\n", splch);
        }
    }
    public class ProgramReverseStri
    {
        static void Main(string[] args)
        {
            //int temp;
            string s = Console.ReadLine();
            string[] a = s.Split(' ');
           // int k = a.Length - 1;
           // temp = k;
            for (int i = a.Length - 1 ; i>= 0; i--)
            {
                Console.Write(a[i] + "" + ' ');
               // --temp;
            }
            Console.ReadKey();
        }
    }
    public class SortA
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 1, 4, 9, 8 ,3,42,23,45,22};

            
            for (int i = 2; i < 5; i++)
            {
                for (int j = 2; j <=i; j++)
                {
                    if(a[i]>a[j+1])
                    {
                        int b = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = b;
                    }
                }
            }
           
            Console.WriteLine(String.Join(" ",a));

            /*int[] a = { 2, 1, 4, 9, 8 };
            for (int i = 2,j=a.Length-1; i <= a.Length&& j>1; i++,j--)
            {
                if(a[i]>a[j])
                {
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
                Console.WriteLine(a[i]);
            }*/
        }
    }
    public class Distinct
    {
        static int countDistinct(int[] arr, int n)
        {
            int res = 1;

            // Pick all elements one by one
            for (int i = 1; i < n; i++)
            {
                int j = 0;
                for (j = 0; j < i; j++)
                    if (arr[i] == arr[j])
                        break;

                // If not printed earlier,
                // then print it
                if (i == j)
                    res++;
            }
            return res;
        }

        // Driver code
        public static void Main()
        {
            int[] arr = { 12, 10, 9, 45, 2, 10, 10, 45 };
            int n = arr.Length;
            Console.WriteLine(countDistinct(arr, n));
        }
    }
   public class Coprime
   {      
        static void Main(string[] args)
        {
            int x = 0;
            int num1 = 2;// Convert.ToInt32(Console.ReadLine());
            int num2 = 3;//Convert.ToInt32(Console.ReadLine());
            int p = num1 * num2;
            for (int i = 1; i < p; i++)
            {
                if(num1%i==0 && num2%i==0)
                {
                  x = i;
                }
            }
            if(x==1)
            {
                Console.WriteLine("coprime");
            }
            else
            {
                Console.WriteLine("not coprime");
            }
        }

   }
    class GFG
    {
        static int lenOfLongSubarr(int[] arr, int n)
        {
            
            Dictionary<int, int> um
                = new Dictionary<int, int>();
            int sum = 0, maxLen = 0;

           
            for (int i = 0; i < n; i++)
            {
              
                sum += arr[i] == 0 ? -1 : 1;

                if (sum == 1)
                    maxLen = i + 1;

                else if (!um.ContainsKey(sum))
                    um.Add(sum, i);


                if (um.ContainsKey(sum - 1))
                {
                    if (maxLen < (i - um[sum - 1]))
                        maxLen = i - um[sum - 1];
                }
            }
            return maxLen;
        }

      
        public static void Main(String[] args)
        {
            int[] arr = { 0, 1, 1, 0, 0, 1 };
            int n = arr.Length;
            Console.WriteLine("Length = " + lenOfLongSubarr(arr, n));
        }
    }
    class GFG1
    {
        public static void Main(String[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter Array elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }        
       
           Dictionary<int, int> um
                = new Dictionary<int, int>();
            int sum = 0, maxLen = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i] == 0 ? -1 : 1;

                if (sum == 1)
                    maxLen = i + 1;

                else if (!um.ContainsKey(sum))
                    um.Add(sum, i);


                if (um.ContainsKey(sum - 1))
                {
                    if (maxLen < (i - um[sum - 1]))
                        maxLen = i - um[sum - 1];
                }               
            }
            Console.WriteLine(maxLen);        
        }
    }

}

