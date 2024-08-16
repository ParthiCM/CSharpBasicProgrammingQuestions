using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                for (int j = i + 1; j < list.Count ; j++)
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

    }
}
