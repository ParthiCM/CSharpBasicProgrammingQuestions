using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp2
{
    internal class advancePrograms
    {
        public static void ExpandString(string str)
        {

            char currentChar = '\0';
            StringBuilder numberStore = new StringBuilder();
            Dictionary<char, int> dict = new Dictionary<char, int>();

            //a10b11c19d3
            foreach (var item in str)
            {
                if (char.IsLetter(item))
                {
                    if (currentChar != '\0' && numberStore.Length > 0)
                    {
                        dict.Add(currentChar, Int32.Parse(numberStore.ToString()));
                        numberStore.Clear();
                    }
                    currentChar = item;
                }
                else if (char.IsDigit(item))
                {
                    numberStore.Append(item);
                }
            }

            dict.Add(currentChar, Int32.Parse(numberStore.ToString()));

            Console.WriteLine($"Input : {str}");
            Console.Write($"Output : ");
            foreach (var item in dict)
            {
                for (int i = 0; i < item.Value; i++)
                {
                    Console.Write($"{item.Key}");
                }
                Console.Write(" ");
            }

        }



        // find the smallest not repeating number in two array

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


        //Input: new int[] {5,7,16,1,2}
        //Output: false
        //Input: new int[] {3,5,-1,8,12}
        //Output: true
        public static bool SubsetSumEqualsMax(int[] arr)
        {
            // sort the given array 
            var temp = 0;
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
            List<int> list = arr.ToList();
            list.RemoveAt(arr.Length - 1);
            var largerNum = arr[arr.Length - 1];

            Console.WriteLine($"sorted arr {string.Join(",", arr)}");
            Console.WriteLine($"larger num is {largerNum} and new list {string.Join(",", list)}");

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    // 1,2,5,7  16
                    // -1,3,5,8,12
                    // using two pointer approach
                    // 
                    int sum = list[i] + list[j];
                    if (sum == largerNum)
                    {
                        return true;
                    }
                    else if (sum > largerNum)
                    {
                        break;
                    }
                }
            }
            return false;

        }

        public static void prefixSum(int[] arr, int startIndex, int endIndex)
        {
            int sum = 0;
        // 0 ,1, 2, 3, 4, 5 
        //Input: nums = [1, 2, 3, 4, 5, 6], i = 1, j = 3
        //    Output: 9

            for (int i = startIndex; i <= endIndex; i++)
            {
                sum = sum + arr[i];
            }

            Console.WriteLine($"Sum of sub array is {sum}");
        }

        public static void TopKElement(int[] arr, int k)
        {

            //input = [1, 1, 1, 2, 2, 2, 3, 3] | K = 2
            // output = [1, 2]

            // input = [1,1,2,2,2,3,3,3] | K = 3
            // output = [2,3]

            // 1  -> 3, 2 -> 3 , 3 -> 2
            Dictionary<int, int> dicts = new Dictionary<int, int>();  // Adding elements into the array

            foreach (var item in arr)
            {
                if (!dicts.ContainsKey(item))
                {
                    dicts.Add(item, 1);
                }
                else
                {
                    dicts[item]++;
                }
            }

            Console.WriteLine(string.Join(',', dicts));

            Dictionary<int, List<int>> reversedDicts = new Dictionary<int, List<int>>();

            foreach (var item in dicts.Keys)
            {
                var counts = dicts[item];

                if (!reversedDicts.ContainsKey(counts))
                {
                    reversedDicts.Add(counts, new List<int> { item });
                }
                else
                {
                    reversedDicts[counts].Add(item);
                }
            }


            foreach (var item in reversedDicts)
            {
                Console.WriteLine($"{item.Key} => {string.Join(',', item.Value)}");
            }


            var Kelements = new int[k];
            int index = 0;


            for (int i = arr.Length; i > 1; i--)
            {
                if (reversedDicts.ContainsKey(i))
                {
                    foreach (var item in reversedDicts[i])
                    {
                        if (index < k)
                        {
                            Kelements[index] = item;
                            index++;
                        }
                        else
                        {
                            break;
                        }


                    }
                }
            }

            Console.WriteLine($"The K elements are {string.Join(',', Kelements)}");

        }


        public static void slidingWindow(int[] arr, int valueToCheck , int windowLength )
        {

            // Input =  1, 1, 2, 2, 1, 2, 3, 3, 3

            int sum = 0, count = 0;
            for (int i = 0; i < windowLength; i++)
            {
                sum += arr[i];
                if (sum == valueToCheck)
                {
                    count++;
                }
            }

            Console.WriteLine($"sum of first window is {sum}");
            var start = 0;
            var end = windowLength;
            for (int i = windowLength; i < arr.Length ; i++)
            {
                sum = (sum + arr[end]) - arr[start];
                Console.WriteLine($"int  = {i} & sum = {sum}");
                if (sum == valueToCheck)
                {
                    count++;
                }
                start++;
                end++;
            }
            Console.WriteLine($"num of subArray is {count}");
        }
    }
}
