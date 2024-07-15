//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    //Input: digits = [1,2,3]
//    //Output: [1,2,4]
//    //Explanation: The array represents the integer 123.
//    //Incrementing by one gives 123 + 1 = 124.
//    //Thus, the result should be[1, 2, 4].
//    internal class PlusOne
//    {
//        public static int[] digits = { 9,  9 };

//        //public static int[] ReturnPlusOne(int[] digits)
//        //{
//        //    var sum = 0;
//        //    var k = digits.Length-1;
//        //    for (int i = 0 ; i < digits.Length && k!=0 ; i++)
//        //    {
//        //        sum = (int)(sum + digits[i] * Math.Pow(10,k));
//        //        k--;
//        //    }
//        //    var TotalPlusOne = sum + digits.Last() + 1;
//        //    int[] ans = new int[TotalPlusOne.ToString().Length];
//        //    for (int i = TotalPlusOne.ToString().Length-1; i >=0 ; i--)
//        //    {

//        //        ans[i] = TotalPlusOne % 10; 
//        //        TotalPlusOne = TotalPlusOne / 10;
//        //    }
//        //    return ans;
//        //}

//        public static int[] ReturnPlusOne(int[] digits)
//        {
            
//            if (!digits.Last().Equals(9) && digits.Length > 1)
//            {
//                digits[digits.Length-1] = digits.Last() + 1;
//                return digits;
//            }
//            if (digits.Length.Equals(1))
//            {
//                if (digits.Last().Equals(9))
//                {
//                    int[] newInts = new int[digits.Length + 1];
//                    newInts[0] = 1;
//                    return newInts;
//                }
//                else
//                {
//                    digits[digits.Length - 1] = digits.Last() + 1;
//                    return digits;
//                }
//            }
//            else
//            {
//                for (int i = digits.Length-1 ; i > 0 && digits[i] >= 9; i--)
//                {
//                    digits[i] = 0;
//                    if ( digits[i - 1] <= 8)
//                    {
//                        digits[i - 1] = digits[i - 1] + 1;
//                        break;
//                    }
//                    else
//                    {
//                        digits[i - 1] = digits[i - 1] + 1;
//                    }
//                }
//                if (digits[0].Equals(10))
//                {
//                    int[] newInts = new int[digits.Length + 1];
//                    newInts[0] = 1;
//                    return newInts;
//                }
//                return digits;
//            }
//        }

//        public static void Main(string[] args)
//        {
//            var ans = ReturnPlusOne(digits);
//        }
//    }
//}
