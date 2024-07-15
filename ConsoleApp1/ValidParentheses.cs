//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static System.Runtime.InteropServices.JavaScript.JSType;

//namespace ConsoleApp1
//{
//    //    Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

//    //An input string is valid if:

//    //Open brackets must be closed by the same type of brackets.
//    //Open brackets must be closed in the correct order.
//    //Every close bracket has a corresponding open bracket of the same type.


//    //Example 1:

//    //Input: s = "()"
//    //Output: true
//    //Example 2:

//    //Input: s = "()[]{}"
//    //Output: true
//    //Example 3:

//    //Input: s = "(]"
//    //Output: false
//    internal class ValidParentheses
//    {
//        public static string inputString = "](";
//        public static string NewString;
//        public static List<bool> status = new List<bool>();
//        public static List<bool> CheckValidParentheses(string s)
//        {

//            if (!(s.Length % 2 == 0))
//            {
//                status.Add(false);
//                return status;
//            }
//            else
//            {
//                for (int i = 0; i < s.Length; i += 2)
//                {
//                    switch (s[i])
//                    {
//                        case '(':
//                            status.Add(s[i + 1].Equals(')') ? true : false);
//                            break;

//                        case '{':
//                            status.Add(s[i + 1].Equals('}') ? true : false);
//                            break;

//                        case '[':
//                            status.Add(s[i + 1].Equals(']') ? true : false);
//                            break;

//                        default:
//                            status.Add(false);
//                            break;
//                    }
//                }
//                return status;
//            }
//        }

//        public static bool checkUsingReplace(string s)
//        {
//            int len = (s.Length / 2);
//            if (!(s.Length % 2 == 0)) { return false; }

//            else
//            {
//                for (int i = 0; i < (s.Length / 2); i++)
//                {
//                    s = s.Replace("{}", "").Replace("[]", "").Replace("()", "");
//                }
//                return s.Length > 0 ? false : true;
//            }

//            //do
//            //{

//            //} while ();
//        }

//        public static bool removeFromMiddle(string s)
//        {
//            Collection<char> col = new Collection<char>();

//            if (!(s.Length % 2 == 0)) { return false; }

//            else
//            {
//                foreach (char c in s)
//                {
//                    col.Add(c);
//                }

//                for (int i = 0; i <= (col.Count / 2); i++)
//                {
//                    int leftMiddle = (col.Count / 2) - 1;
//                    int rightMiddle = (col.Count / 2);
//                    string temp = $"{col.ElementAt(leftMiddle)}{col.ElementAt(rightMiddle)}";
//                    //char[] temp = new char[2];
//                    //temp[0] = col.ElementAt(leftMiddle);
//                    //temp[1] = col.ElementAt(rightMiddle);
//                    if (temp.Equals("()") || temp.Equals("[]") || temp.Equals("{}"))
//                    {
//                        col.RemoveAt(leftMiddle);
//                        col.RemoveAt(rightMiddle);
//                    }
//                }
//                return col.Count() > 0 ? false : true;
//            }

//        }

//        public static bool UsingSatck(string s)
//        {
//            Stack<char> stack = new Stack<char>();
//            //for (int i = 0; i < s.Length; i++)
//            //{
//            //    if(s[i].Equals('(') || s[i].Equals('{') || s[i].Equals('['))
//            //    {
//            //        stack.Push(s[i]);
//            //    }

//            //    if ((s[i].Equals(')') || s[i].Equals('}') || s[i].Equals(']')))
//            //    {
//            //        stack.Pop();
//            //    }

//            //}
//            //return stack.Count().Equals(0) ? true : false;
//            //foreach (var item in stack)
//            //{

//            //}

//            foreach (char c in s.ToCharArray())
//            { // loop through each character in the string
//                if (c == '(') // if the character is an opening parenthesis
//                    stack.Push(')'); // push the corresponding closing parenthesis onto the stack
//                else if (c == '{') // if the character is an opening brace
//                    stack.Push('}'); // push the corresponding closing brace onto the stack
//                else if (c == '[') // if the character is an opening bracket
//                    stack.Push(']'); // push the corresponding closing bracket onto the stack
//                else if (stack.Count().Equals(0) || stack.Pop() != c) // if the character is a closing bracket
//                                                                      // if the stack is empty (i.e., there is no matching opening bracket) or the top of the stack
//                                                                      // does not match the closing bracket, the string is not valid, so return false
//                    return false;
//            }
//            // if the stack is empty, all opening brackets have been matched with their corresponding closing brackets,
//            // so the string is valid, otherwise, there are unmatched opening brackets, so return false
//            return stack.Count().Equals(0);
//        }
//        public static void Main(string[] args)
//        {
//            //var sts = CheckValidParentheses(inputString);
//            //Console.WriteLine($"Is that Valid Parentheses : {!sts.Contains(false)}");
//            //var sts = checkUsingReplace(inputString);
//            //Console.WriteLine($"Is that Valid Parentheses : {sts}");

//            var sts = UsingSatck(inputString);
//            Console.WriteLine($"Is that Valid Parentheses : {sts}");
//        }
//    }
//}
