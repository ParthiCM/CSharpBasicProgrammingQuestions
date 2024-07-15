//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class RemoveDuplicatesFromSortedList
//    {
//        public class ListNode
//        {
//            public int val;
//            public ListNode next;
//            public ListNode(int val = 0, ListNode next = null)
//            {
//                this.val = val;
//                this.next = next;
//            }
//        }
//        public static ListNode RemoveDuplicate(ListNode head)
//        {
//            if (head == null)
//                return null;

//            if (head.next == null)
//                return head;

//            ListNode prevNode = head;
//            for (ListNode node = head.next; node != null; node = node.next)
//            {
//                if (node.val == prevNode.val)
//                {
//                    prevNode.next = node.next;
//                }
//                else
//                {
//                    prevNode = node;
//                }
//            }

//            return head;
//        }
//        public static void Main(string[] args)
//        {
//            int[] val = { 1, 1, 2, 3, 3 };
//            //RemoveDuplicate(val);
//        }
//    }
//}
