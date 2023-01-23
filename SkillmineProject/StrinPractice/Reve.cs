using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.StrinPractice
{
    class Reve
    {
        static void Main(string[] args)
        {
            String str = "Krushna";
            char[] ch = str.ToCharArray();
            String revstring = String.Empty;
        
            for (int i = ch.Length - 1; i>=0; i--)
            {
                revstring =revstring+ ch[i];             
            }
            Console.WriteLine(revstring);
        }
      
    }
    public class R
    {
        static void Main(string[] args)
        {
            String s = "Krishna Bodke";
            for (int i =s.Length-1 ; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
        }
        
    }
 //   I
 //   I Like
 //   I Like India
    public class StriRev
    {
        static void Main(string[] args)
        {
           
            String s = "I Like India";
            String[] str = s.Split();

            
            for (int i = 0; i <str. Length; i++)
            {
                for (int k = 0; k <=i; k++)
                {
                    Console.Write(" "+str[k]);

                }
                Console.WriteLine();     
            }
            
        }
    }
    public class S
    {
        static void ReverseString(String[]str)
        {
            String rewords = "";
            for (int i = 0; i < str.Length; i++)
            {
                String word = str[i];     // Convert Split String into String
                String wordvalue = "";

                for (int j = 0; j <word.Length; j++)
                {
                    wordvalue = word[j] + wordvalue;

                }
                rewords = rewords + wordvalue+" ";
            }
            Console.WriteLine(rewords);
        }
        static void Main(string[] args)
        {
            string s = "India is my country";
            String[] str = s.Split();
            S.ReverseString(str);

        }
    }
    public class C
    {
        static void SumOfDigitFromNumber(String s)
        {
            int sum = 0;
            for (int i = 0; i <s.Length; i++)
            {
                if(s[i]>='0' && s[i]<='9')
                {
                    sum = (int) (sum + char.GetNumericValue(s[i]));
                }
            }
            Console.WriteLine("sum  "+sum);
        }
        static void Main(string[] args)
        {

            Console.WriteLine(" Enter String ");
            String s = Console.ReadLine();
            C.SumOfDigitFromNumber(s);
            
        }
    }
    public class L
    {
        public static void LongestWord(String s)
        {
            String[] str = s.Split();
            int max = 0;
            for (int i = 0; i <str.Length; i++)
            {
                if(str[i].Length >max)
                {
                    max = str[i].Length;
                }
            }
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i].Length==max)
                {
                    Console.WriteLine(str[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            String s = Console.ReadLine();
            L.LongestWord(s);
        }
        
    }
    public class Sor
    {
        static void SortStringArra(String s)
        {
            String[] str = s.Split();

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i+1; j < str.Length; j++)
                {
                    if(str[i].CompareTo(str[j]) ==-1)
                    {
                        String temp = str[i];
                        str[i] = str[j];
                        str[j] = temp;
                    }
                }
            }
            Console.WriteLine(String.Join(" ",str));

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[i].CompareTo(str[j]) == 1)
                    {
                        String temp = str[i];
                        str[i] = str[j];
                        str[j] = temp;
                    }
                }
            }
            Console.WriteLine(String.Join(" ", str));
        }
        static void Main(string[] args)
        {
            String s = "India is my country";
            Sor.SortStringArra(s);
        }
    }
    public class Sorr
    {
        static void SortArrBasedOnLength(String s)
        {
            String[] str = s.Split();
            Console.WriteLine(str);
            for (int i = 0; i < str.Length; i++)
            {

                for (int j = i+1; j < str.Length; j++)
                {
                    if(str[i].Length>str[j].Length)
                    {
                        String temp = str[i];
                        str[i] = str[j];
                        str[j] = temp;

                    }                    
                }                
            }
            Console.WriteLine(String.Join(" ",str));            
        }
        static void Main(string[] args)
        {
            String s = "India is my coutry and Krish ";
            Sorr.SortArrBasedOnLength(s);
        }
    }
    public class abb
    {
        static void NameAbbrivation(string s)
        {
                     
            String word = "";
            for (int i = 0; i <s.Length; i++)
            {
                if(s[i]!=' ')
                {
                    word = word + s[i];                   
                }
                else
                {
                    Console.Write(word[0]+".");
                    word ="";
                }
            }
            Console.WriteLine(word);
        }
        static void Main(string[] args)
        {
            String s = "Krushna Maroti Bodke";
            abb.NameAbbrivation(s);
        }
    }
    public class PreservingthPositionofSpaces
    {
        static void Main(string[] args)
        {
            String s = "India is my country";
            char[] ch = s.ToCharArray();
            char[] ch1 = new char[ch.Length];
            for (int i = 0; i < ch.Length; i++)
            {
                if(ch[i]==' ')
                {
                    ch1[i] = ' ';
                }
            }
            int j = ch1.Length - 1;
            for (int i = 0; i < ch.Length; i++)
            {
                if(ch[i]!=' ')
                {
                    if(ch1[j]==' ')
                    {
                        j--;
                    }
                    ch1[j] = ch[i];
                   j--;
                }
            }
            Console.WriteLine(String.Join("",ch1));
        }
    }
}
