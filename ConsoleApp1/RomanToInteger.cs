//class MyClass
//{
//    public static string InputRomanValue = "MCMXCIV";

//    public static int ConvertRomanToInteger(string RomanNumber)
//    {
//        Dictionary<char, int> Values = new Dictionary<char, int>();
//        Values.Add('I', 1);
//        Values.Add('V', 5);
//        Values.Add('X', 10);
//        Values.Add('L', 50);
//        Values.Add('C', 100);
//        Values.Add('D', 500);
//        Values.Add('M', 1000);

//        int ans = 0;


//        for (int i = 0; i < RomanNumber.Length; i++)
//        {
//            if (i + 1 < RomanNumber.Length)
//            {
//                if (Values[RomanNumber[i]] < Values[RomanNumber[i + 1]])
//                {
//                    ans = ans - Values[RomanNumber[i]];
//                }
//                else
//                {
//                    ans = ans + Values[RomanNumber[i]];
//                }
//            }
//            else
//            {
//                ans = ans + Values[RomanNumber[i]];
//            }

//        }
//        return ans;

//    }
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Roman To Integer");
//        Console.WriteLine($"{InputRomanValue} => {ConvertRomanToInteger(InputRomanValue)}");
//    }
//}
