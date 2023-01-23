using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.StringPractice
{
    public class Class1
    {
        static void Main(string[] args)
        {
            String str = "Krushna";
            String s = "";
            
            for (int i = str.Length-1; i >=0 ; i--)
            {
                s = s + str[i];
            }
            Console.WriteLine(String.Join(" ",s));
        }
    }
    class Reve
    {
        static void Main(string[] args)
        {
            String str = "Krushna";
            char[] ch = str.ToCharArray();
            String revstring = String.Empty;

            for (int i = ch.Length - 1; i >= 0; i--)
            {
                revstring = revstring + ch[i];
            }
            Console.WriteLine(revstring);
        }
    }
   public class Split
    {
        static void Main(string[] args)
        {
            string str = "hello$world";
            string[] s = str.Split("$");
            Console.WriteLine(string.Join(" ",s));
        }
    }
    public class DuplicateWord
    {
        public void Word(string s)
        {
            string[] s1 = s.Split(" ");
            int count ;
            for (int i = 0; i < s1.Length; i++)
            {
                count = 1;
                for (int j = i+1; j <s1.Length; j++)
                {
                    if(s1[i].Equals(s1[j]))
                    {
                        count++;
                        s1[j] = "0";
                        
                    }
                }
                if (s1[i] != "0" && count >1)
                {
                    Console.WriteLine(s1[i]+ count);
                }
            }
          
        }
        static void Main(string[] args)
        {
            string s = "krushna Bodke krushna krushna";
            DuplicateWord d = new DuplicateWord();
            d.Word(s);

        }
    }
  public class Pall
    {
        static void Main(string[] args)
        {
            string s1 = "Krushna";
            string s2 = "";

            for (int i = 0; i < s1.Length; i++)
            {
                s2 = s1[i] + s2;
            }
            Console.WriteLine(s2);
            if(s1==s2)
            {
                Console.WriteLine("Pallindrome");
            }

        }
  }
   public class Vow
    {
        static void Main(string[] args)
        {
            string str = "India is My Country";
            int vowells = 0;
            int con = 0;
            string s = "";
            string s1 = "";

           
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i]=='a'|| str[i] == 'A'||
                   str[i]== 'I'|| str[i] == 'i'||
                   str[i]== 'o'|| str[i] == 'u')
                {
                    vowells++;
                    s = s+ str[i];
                    //Console.WriteLine(str[i]);
                }
                else if(str[i]>='a' && str[i]<='z' ||
                        str[i]>='A' && str[i]<='Z' )

                {
                    con++;
                    s1 = s1 + str[i];
                    //Console.WriteLine(str[i]);
                }
               
            }
            Console.WriteLine($" s={s}  s1={s1}");
            Console.WriteLine($" {vowells}  {con} ");
        }
    }
    public class Arr
    {
         static void ReverseString(String[]str)
         {
            String rewords = "";
            for (int i = 0; i < str.Length; i++)
            {
                String word = str[i];     // Convert Split String (Means Bunch of word) into String (means in character)
                
                String wordvalue = "";

                for (int j = 0; j <word.Length; j++)
                {
                    wordvalue = word[j] + wordvalue;

                }
                
                rewords =  wordvalue + " " + rewords ;
            }
            Console.WriteLine(rewords);
         }
        static void Main(string[] args)
        {
            string[] s = { "Krushna", "Prakash", "Vikas" };
            
            Arr.ReverseString(s);

        }        
    }
    public class R
    {
        public void ReverString(string[]s)
        {
                       
            string wordval = "";

            for (int i = 0; i < s.Length; i++)
            {
                string reword = "";
                string word =  s[i];
                for (int j = 0; j < word.Length; j++)
                {
                    reword = word[j] +reword;
                }
                wordval = reword + " " + wordval;

            }
            Console.WriteLine(wordval);
        }
        static void Main(string[] args)
        {
            string[] s = { "Vikas", "Krushna", "Prakash" };
            R r = new R();
            r.ReverString(s);

        }
    }
    public class Swap
    {
        static void Main(string[] args)
        {
            string s1 = "Krushna";
            string s2 = "Bodke";

            s1 = s1 + s2;
            s2 = s1.Substring(0, s1.Length - s2.Length);
            
            s1 = s1.Substring(s2.Length);
            Console.WriteLine(s1+" "+s2);
        }
    }
}
