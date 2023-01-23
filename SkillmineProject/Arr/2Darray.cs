using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.Array
{


    class TwoDarray
    {
        static void Main(string[] args)
        {

            int[,] a = { {2,3,5},
                         {4,6,7},
                         {7,6,3} };

            int[,] arr = new int[3, 3];
            Console.WriteLine("enter 2d array");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                 for( int j=0; j<arr.GetLength(1); j++)
                 {
                    arr[i, j] = int.Parse(Console.ReadLine());
                 }
            }
            // Display 2D Array
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }  
    }
    class FindRowiseSum
    {
        public void FindRowMax(int[,]arr)
        {
           
            for(int i=0; i<arr.GetLength(0); i++)
            {
                int sum = 0;
                for(int j=0; j<arr.GetLength(1); j++)
                {
                    sum = sum + arr[i,j];
                    Console.Write(arr[i,j] +" ");
                }
                Console.WriteLine(" = "+ sum);
                Console.WriteLine();
            }
            
        }
        static void Main(string[] args)
        {

            int[,] a = { {2,3,5},
                         {4,6,7},
                         {7,6,3} };
            FindRowiseSum s = new FindRowiseSum();
           
            s.FindRowMax(a);
        }

    }
    class FindMaxVAlue
    {
        public void FindMax(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int max =a[i,0] ;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if(a[i,j]>max)
                    {
                        max = a[i, j];
                    }
                   
                }
                Console.WriteLine(" max ="+max);
                Console.WriteLine();
            }

        }
        static void Main(string[]args)
        {
            int[,] a = { {2,3,5},
                         {4,6,7},
                         {7,6,3} };
            FindMaxVAlue s = new FindMaxVAlue();

            s.FindMax(a);
        }
    }
    class Pattern1
    {
        public void Pattern(char[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if( i==0 || j==0|| j==a.GetUpperBound(1) || i==a.GetUpperBound(0) )
                    {
                        a[i, j]='*';
                    }
                    else
                    {
                        a[i,j]= ' ';
                    }
                }
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            /*int[,] a = { {2,3,5},
                         {4,6,7},
                         {7,6,3} };*/
            Pattern1 s = new Pattern1();
            char[,] arr1 = new char[4, 4];
            
            s.Pattern(arr1);

            
        }
    }
    class Pattern2
    {
        public void Patter(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == 0 || j == 0 || j == a.GetUpperBound(1) || i == a.GetUpperBound(0))
                    {
                        Console.Write(a[i, j]);
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] a = { {2,3,5},
                         {4,6,7},
                         {7,6,3} };
            Pattern2 s = new Pattern2();
            int[,] arr1 = new int[4, 4];
            s.Patter(arr1);
        }
    }
    class PatternN
    {
        public void Npattern(int[,]a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if((j==0) || (j==a.GetUpperBound(1) || (i==j)))
                    {
                        Console.Write(a[i, j]);
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(string[]args)
        {
            int[,] a = new int[4,4];
            Console.WriteLine("enter 2D array element");
            for(int i=0; i<a.GetLength(0); i++ )
            {
                for(int j=0; j<a.GetLength(1); j++)
                {
                    a[i,j]=int.Parse(Console.ReadLine());
                }
            }
            PatternN s = new PatternN();
            s.Npattern(a);

        }
    }

    class FindCellWiseSum
    {
        public void FindColSum(int[,] arr)
        {

           for (int j = 0; j < arr.GetLength(1); j++)
           {
                int sum = 0;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    sum = sum + arr[i, j];
                    Console.WriteLine(arr[i, j] + " ");
                }
                Console.Write(" = " + sum);
                Console.WriteLine();
           }

        }
        static void Main(string[] args)
        {

            int[,] a = { {2,3,5},
                         {4,6,7},
                         {7,6,3} };
            FindCellWiseSum s = new FindCellWiseSum();

            s.FindColSum(a);
        }

    }
    class AdditionOfTwoMatrix
    {
       
        static void Main(string[]args)
        {
            int[,] a1 = new int[3, 3];
            int[,] a2 = new int[3, 3];
            int[,] a3 = new int[3, 3];
            for (int i=0; i<a1.GetLength(0); i++)
            {
                for (int j = 0; j < a1.GetLength(1); j++)
                {
                    a1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < a2.GetLength(0); i++)
            {
                for (int j = 0; j < a2.GetLength(1); j++)
                {
                    a2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < a3.GetLength(0); i++)
            {
                for (int j = 0; j < a3.GetLength(1); j++)
                {
                    a3[i, j] = a1[i, j] + a2[i, j];
                }
            }
            for (int i = 0; i < a2.GetLength(0); i++)
            {
                for (int j = 0; j < a2.GetLength(1); j++)
                {
                    Console.Write(a3[i, j]);
                }
                Console.WriteLine( " ");
            }
            Console.WriteLine();
        }

      /*  public static void Main(string[]args)
        {
            int i, j;
            int[,] arr1 = new int[3,3];
            int[,] arr2 = new int[3,3];
            int[,] arr3 = new int[3,3];

            // setting matrix row and columns size
            
            Console.Write("Enter elements in the first matrix:\n");

            for (i = 0; i < arr1.GetLength(0); i++)
            {
                for (j = 0; j < arr1.GetLength(1); j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("Enter elements in the second matrix:\n");

            for (i = 0; i < arr2.GetLength(0); i++)
            {
                for (j = 0; j < arr2.GetLength(1); j++)
                {
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("\nFirst matrix is:\n");

            for (i = 0; i < arr1.GetLength(0); i++)
            {
                Console.Write("\n");
                for (j = 0; j < arr1.GetLength(1); j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }
            Console.Write("\nSecond matrix is:\n");

            for (i = 0; i < arr2.GetLength(0); i++)
            {
                Console.Write("\n");
                for (j = 0; j < arr2.GetLength(1); j++)
                    Console.Write("{0}\t", arr2[i, j]);
            }

            for (i = 0; i < arr3.GetLength(0); i++)
                for (j = 0; j < arr3.GetLength(1); j++)
                    arr3[i, j] = arr1[i, j] + arr2[i, j];
            Console.Write("\nAdding two matrices: \n");

            for (i = 0; i < arr3.GetLength(0); i++)
            {
                Console.Write("\n");
                for (j = 0; j < arr3.GetLength(1); j++)
                    Console.Write("{0}\t", arr3[i, j]);
            }
            Console.Write("\n\n");
        }*/
    }
    class AvgPrime
    {
        static void Main(string []args)
        {
            int s = 0, c = 0;
            for(int i=1; i<=20; i++)
            {
                bool f = true;
                if (i == 1)
                {
                    f = false;
                }
                for (int j = 2; j * j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        f = false;
                    }
                }
                if (f == true)
                {
                    s =s+ i;
                    c++;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(s / c); 
            
            
        }
    }
    // Display table between 1-5
    class Table1
    {
        static void Main(string[]args)
        {
          
            for(int i=1; i<=5; i++)
            {
                for(int j=1; j<=10; j++)
                {
                   int table=i * j ;
                    Console.Write(table+" ");
                }
                Console.WriteLine();
            }
        }
    }
    class SumFactorial
    {
        static void Main(string[]args)
        {
            int s = 0;
           
            for(int i=1; i<=5; i++)
            {
                int fact = 1;
                for (int j=1; j<=i;j++)
                {
                    fact = fact * j;
                }
                Console.WriteLine(fact);
                s = s + fact;
            }
            Console.WriteLine("sum of Factorial : " + s) ;
        }
    }
    // Merge 2 array
    class Merge
    {
        static void Main(string[]args)
        {
            int arr1count = 0;
            int arr2count = 0;
            int b = 5;

            int[] arr1 = new int[5];
            int[] arr2 = new int[5];
            int[] merge = new int[10];

            for(int a=0; a<5;a++)
            {
                b++;
                arr1[a] = a;
                arr2[a] = b;

            }
            for(int a = 0; a < 5; a++)
            {
                Console.WriteLine("array1" + arr1[a]);
                Console.WriteLine("array2" + arr2[a]);
            }
            for(int a=0; a<10; a++)
            {
                if (a<5)
                {
                    merge[a] = arr1[arr1count];
                    arr1count++;
                }
                else
                {
                    merge[a] = arr2[arr2count];
                    arr2count++;
                }
            }
            for (int a=0;a<10;a++)
            {
                Console.WriteLine("Merge array" + merge[a]);
            }
            Console.ReadKey();
        }
    }
    public class Prime
    {
        static void Main(string[] args)
        {
            int num = 3;
            int count = 0;
           
                for (int j = 2; j <num; j++)
                {
                    if(num%j==0)
                    {
                        count++;
                        break; 
                    }
                }
                if (count == 0)
                {
                   Console.WriteLine("prime");

                }

        }
    }
}





