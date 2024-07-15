//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class ContainsDuplicates
//    {
//        public static int[] nums = { 1, 2, 3 };
//        public static int flag ;
//        public static bool NumberArrayContainsDuplicate(int[] nums)
//        {
//            for (int i = 0; i < nums.Length && flag != 1; i++)
//            {
//                for (int j = i + 1; j < nums.Length; j++)
//                {
//                    if (nums[i] == nums[j])
//                    {
//                        flag = 1;
//                        break;
//                    }
//                }
//            }
//            return flag.Equals(1) ? true : false;
//        }
//        public static void Main(string[] args)
//        {
//            var val = NumberArrayContainsDuplicate(nums);
//            Console.WriteLine( $"Status is {val}"); ;


//        }
//    }
//}
