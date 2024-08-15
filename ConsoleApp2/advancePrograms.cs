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

            foreach (var item in dict)
            {
                for (int i = 0; i < item.Value; i++)
                {
                    Console.Write($"{item.Key}");
                }
                Console.Write(" ");
            }

        }

    }
}
