//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class AddBinary
//    {
//        public static string a = "11", b = "1";
//        public static int[] sum ;
//        public static int[] smallerArray;
//        public static int[] largeerArray;

//        public static void Main()
//        {
//            char[] ArrayOfA = a.ToArray();
//            char[] ArrayOfB = b.ToArray();
            
//            int smallerArrayLength;
//            if(ArrayOfA.Length >= ArrayOfB.Length)
//            {
                
//                ArrayOfB.CopyTo(smallerArray , 0);
//                ArrayOfA.CopyTo(largeerArray, 0);
//                //smallerArrayLength = ArrayOfB.Length;
//                sum = new int[ArrayOfA.Length];
//            }
//            else
//            {
//                ArrayOfA.CopyTo(smallerArray, 0);
//                ArrayOfB.CopyTo(largeerArray, 0);
//                //smallerArrayLength = ArrayOfA.Length;
//                sum = new int[ArrayOfB.Length];
//            }
//            var k = sum.Length;
//            var carry = 0;
//            int[] newArray = new int[k];
//            for (int i = smallerArray.Length - 1; i >= 0; i--)
//            {
//                newArray[i] = smallerArray[i];
//            }
//            for (int i = sum.Length; i >= 0; i--)
//            {
//                if (smallerArray[i].Equals('0') && largeerArray[i].Equals('0'))
//                {
//                    if(carry == 1)
//                    {
//                        sum[k] = 1;
//                    }
//                    else
//                    {
//                        sum[k] = 0;
//                    }
//                }
//                else if (smallerArray[i].Equals('0') && largeerArray[i].Equals('1'))
//                {
//                    if(carry == 1)
//                    {
//                        sum[k] = 0;
//                    }
//                    else
//                    {
//                        sum[k] = 1;
//                    }
//                }
//                else if (smallerArray[i].Equals('1') && largeerArray[i].Equals('0'))
//                {
//                    if (carry == 1)
//                    {
//                        sum[k] = 0;
//                    }
//                    else
//                    {
//                        sum[k] = 1;
//                    }
//                }
//                else
//                {
//                    if (carry == 1)
//                    {
//                        sum[k] = 0;
//                        carry = 1;
//                    }
                    
//                }
//            }
//        }
//    }
//}
