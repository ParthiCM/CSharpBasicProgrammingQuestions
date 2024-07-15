using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;

namespace ConsoleApp2
{
    internal class Program
    {
        public static bool CheckAnagram(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }
            var arrOfS1 = s1.ToCharArray();
            Array.Sort(arrOfS1);
            var arrOfS2 = s2.ToCharArray();
            Array.Sort(arrOfS2);

            if (arrOfS1.ToArray().SequenceEqual(arrOfS2.ToArray()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int[] SortArray(int[] arr)
        {
            int temp = 0;
            //for (int i = 0; i < intArray.Length; i++)
            //{
            //    for (int j = 0; j < (intArray.Length - 1); j++)
            //    {
            //        if (intArray[j] > intArray[j + 1])
            //        {
            //             temp = intArray[j+1];
            //            intArray[j + 1] = intArray[i];
            //            intArray[i] = temp;
            //        }
            //    }
            //}

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }

        public static void PrintNumberOfOccurance(string val)
        {
            Dictionary<char,int> dic = new Dictionary<char,int>();

            foreach (var item in val)
            {
                if (!dic.ContainsKey(item))
                {
                    dic.Add(item, 1);
                }
                else
                {
                    dic[item]++;
                }
            }

            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} -- {item.Value}");
            }

        }
        public static void CheckDictionary()
        {
            Dictionary<int,bool> dic = new Dictionary<int, bool>();

            for (int i = 0; i < 10; i++)
            {
                dic.Add(i, true );
            }
            for (int i = 11; i < 15; i++)
            {
                dic.Add(i, false);
            }
            
            List<int> list = new List<int>();
            foreach (var item in dic) 
            {
                if (item.Value.Equals(false))
                {
                    list.Add(item.Key);
                }
            }
            
            foreach (var item in dic)
            {
                Console.WriteLine($"{string.Format("Here's the list: ({0}).", string.Join(", ", list))}");
                string.Format("This is a Test {0}" , string.Join(", ", list));
            }

        }
        //5 , 1,2,3,
        static void GenerateFibonacci(int n)
        {
            int first = 0, second = 1, next;

            Console.WriteLine("Fibonacci series up to " + n + " terms:");

            //for (int i = 0; i < n; i++)
            //{
            //    if (i <= 1)
            //    {
            //        next = i;
            //    }
            //    else
            //    {
            //        next = first + second;
            //        first = second;
            //        second = next;
            //    }
            //    Console.Write(next + " ");
            //}
            //0 1 1 2 3 5
            Console.Write($"{first},{second}");
            for (int i = 2; i < n; i++)
            {
                next = first + second;
                Console.Write($",{next}");
                first = second;
                second = next;
            }
            

        }
        public static string SortTheArrayOfIntegers(int[] arr) // [1,2,4,3]
        {
            var temp = 0;
            for (int i = 0; i < arr.Length; i++) //new int[] { 1, 5, 6, 8, 10, 0 }
            {
                for (int j = 0;  j < arr.Length - 1;  j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return string.Join(", " , arr);
        }


        public static void CheckNumberBeginWithOne(int[] arr)
        {
            //List<int> list = new List<int>();   
            //foreach (var item in arr)
            //{
            //    var val = item.ToString().ToCharArray()[0];
            //    if (val == '1')
            //    {
            //        list.Add(item);
            //    }
            //}
            //Console.WriteLine(String.Format("The Result is {0}", String.Join(',', list))); 
            List<int> list = new List<int>();
            foreach (var item in arr)
            {
                int temp = item;
                while (temp != 0)
                {
                    if (temp == 1)
                    {
                        list.Add(item);
                    }
                    temp = temp / 10;
                }
            }
            Console.WriteLine(String.Format("The Result is {0}", String.Join(',', list))); 

        }

        public static void Main(string[] args)
        {
            //var s1 = "Silent";
            //var s2 = "Listen";
            //Console.WriteLine($"Status = {CheckAnagram(s1.ToLower(), s2.ToLower())}"); ;
            //int[] arr = { 10, 5, 8, 1, 2, 3, 4 };
            //var res = SortArray(arr);
            //Console.WriteLine();
            //PrintNumberOfOccurance("paarthiii");
            //GenerateFibonacci(10);
            //CheckDictionary();
            Console.WriteLine(SortTheArrayOfIntegers(new int[] { 1, 5, 6, 8, 10, 0 })); 
            // CheckNumberBeginWithOne(new int[] { 111, 51, 16, 18, 10, 1,0,-1 });
        }


    }

    // find the smallest not repeating number in two array
}



