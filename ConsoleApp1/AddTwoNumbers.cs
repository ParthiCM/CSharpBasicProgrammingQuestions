//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Runtime.Intrinsics.X86;
//using System.Text;
//using System.Threading.Tasks;
//using static System.Runtime.InteropServices.JavaScript.JSType;

//namespace ConsoleApp1
//{
//    /// <summary>
//    //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
//    //You may assume that each input would have exactly one solution, and you may not use the same element twice.
//    //You can return the answer in any order.
//    /// </summary>
//    /// 
//    // *************  Example  *************  
//    //    Input: nums = [2,7,11,15], target = 9
//    //Output: [0,1]
//    //Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
//    class AddTwoNumbers
//    {
//        public static int[] ArrayOfNumbers = {11, 15, 2, 7};
//        public static int target = 9;
//        public static int flag = 0;
//        public static int[] positions = new int[2];

//        public static void Main(string[] args)
//        {
//            for (int i = 0; i < ArrayOfNumbers.Count() && flag!=1; i++)
//            {
//                for (int j = i+1; j < ArrayOfNumbers.Count(); j++)
//                {
//                   if (ArrayOfNumbers[i] + ArrayOfNumbers[j] == target)
//                    {
//                        flag = 1;
//                        positions[0] = i; 
//                        positions[1] = j;
//                        break;
//                    }
//                }
//            }
//            Console.WriteLine($"the two numbers : [{positions[0]},{positions[1]}]");
//            //return positions;
//        }

//    }
//}
