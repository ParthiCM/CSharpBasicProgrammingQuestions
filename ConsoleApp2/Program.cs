﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;

namespace ConsoleApp2
{
    internal class Program
    {
        public static bool CheckAnagram(string s1, string s2)
        {
            
            // using Array Sort ****

            //var arr1 = s1.ToLower().ToCharArray();
            //var arr2 = s2.ToLower().ToCharArray();
            //if (s1.Length  != s2.Length)
            //{
            //    return false;
            //}
            //Array.Sort(arr1);
            //Array.Sort(arr2);
            //if (arr1.SequenceEqual(arr2))
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            // using Array Dictionary

            s1 = s1.ToLower();  
            s2 = s2.ToLower(); 
            
            if (s1.Length != s2.Length)
            {
                return false;
            }
            Dictionary<char, int> dic = new Dictionary<char, int>();

            foreach (char c in s1) { 
                if(!dic.ContainsKey(c))
                {
                    dic.Add(c, 1);
                }
                else
                {
                    dic[c]++;
                }
            }

            foreach (char c in s2)
            {
                if (!dic.ContainsKey(c) || dic[c] == 0)
                {
                    return false;
                }

                dic[c]--;
            }
            return true;

        }

        public static void SortArray(int[] arr)
        {
            foreach (var item in arr)
            {
                
            }
            var temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 ; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.WriteLine(string.Join(",", arr));
        }

        public static void PrintNumberOfOccurrence(string str)
        {
            Dictionary<char, int> dic = new Dictionary<char, int> ();

            foreach (var c in str)
            {
                if (!dic.ContainsKey(c))
                {
                    dic.Add(c, 1);
                }
                else
                {
                    dic[c]++;
                }
            }

            foreach (var c in dic)
            {
                Console.WriteLine($"{c.Key} -- {c.Value}" );
            }
        }

        public static void GenerateFibonacci(int n)
        {
            int first = 0, second = 1, next;

            Console.Write($"{first},{second},");

            for(int i = 2; i < n; i++)
            {
                next = first + second;
                Console.Write($"{next},");
                first = second;
                second = next;
            }

            
        }

        public static void swapTwoVariable(int a , int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine( $" a = {a}, b = {b}");
        }
        /// <summary>
        ///  3 2 1
        ///  3 2 
        ///  3
        /// </summary>
        /// <param name="num"></param>
        public static void printPattern1(int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int j = num; j > i ; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine("");
            }
        }

        /// <summary>
        /// 1 
        /// 1 2
        /// 1 2 3
        /// 
        /// </summary>
        /// <param name="args"></param>

        public static void printPattern2(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i ; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine("");
            }
        }


        /// <summary>
        ///     *
        ///    ***
        ///   ***** 
        ///  *******
        /// </summary>
        /// <param name="args"></param>
        /// 

        public static void printPattern3(int num)
        {
            
        }

        /// <summary>
        /// *
        /// **
        /// ***
        /// ****
        /// <param name="args"></param>
        /// 

        public static void printPattern4(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1;  j <= i;  j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }


        /// <summary>
        /// 
        /// <param name="args"></param>
        /// 

        public static void printPattern5(int num)
        {
            for (int i = 0; i <= num; i++)
            {
                for (int j = num; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
        public static void Main(string[] args)
        {
            //Console.WriteLine($"Status = {CheckAnagram("Silent", "Listee")}");
            //SortArray(new int[] { 10, 5, 8, 1, 2, 3, 4 });
            //PrintNumberOfOccurrence("paarthiii");
            //GenerateFibonacci(10);
            //swapTwoVariable(9, 10);
            //CheckDictionary();
            //Console.WriteLine(SortTheArrayOfIntegers(new int[] { 1, 5, 6, 8, 10, 0 })); 
            // CheckNumberBeginWithOne(new int[] { 111, 51, 16, 18, 10, 1,0,-1 });
            //printPattern1(3);
            //printPattern2(3);
            //printPattern4(4); 
            printPattern5(4);
        }


    }

    // find the smallest not repeating number in two array
}



