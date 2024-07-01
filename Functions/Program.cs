using System.Globalization;
using System.Text;

namespace Functions
{
    internal class Program
    {
        /*    Task 1     */
        static int ConvertToSeconds(int value)
        {
            return Convert.ToInt32(value*60);
        
        }

        static int IncremntNumber(int value)
        {
            return ++value;
        }

        static int TakeArray(int[] numbers)
        {
            return numbers[0];
        }

        static double AreaOfTriangle(int Base, int Height)
        {
            return 0.5 * Base * Height;
        }

        static int[] EvenNumEvenIndex(int[] numbers)
        {
            int[] temp = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 2 ==0 && i % 2 == 0)
                {
                    temp[i] = numbers[i];
                }
            }
            return temp;
        }

        public static string[] EvenIndexOddLength(string[] strings)
        {
            List<string> result = new List<string>();

            for (int i = 0; i < strings.Length; i += 2) 
            {
                if (strings[i].Length % 2 != 0) 
                {
                    result.Add(strings[i]);
                }
            }

            return result.ToArray();
        }


        public static int[] PowerElementIndex(int[] nums)
        {
            int[] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = (int)Math.Pow(nums[i], i);
            }

            return result;
        }


        public static int multiplication2(int num1, int num2)
        {
            int result = 0;
            for (int i = 0; i < Math.Abs(num2); i++)
            {
                result += num1;
            }
            if (num2 < 0)
            {
                result = -result;
            }

            return result;
        }

        public static int muti2(int start, int end)
        {
            if (start > end)
            {
                int temp = start;
                start = end;
                end = temp;
            }

            int product = 1;
            for (int i = start; i <= end; i++)
            {
                product *= i;
            }

            return product;
        }

        public static double aveArray(int[] numbers)
        {
            

            double sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            return sum / numbers.Length;
        }

        /*   Task2   */

        public static int GetDays(DateTime date1, DateTime date2)
        {
            if (date1 > date2)
            {
                DateTime temp = date1;
                date1 = date2;
                date2 = temp;
            }

            TimeSpan difference = date2 - date1;
            return difference.Days;
        }


        public static string[] NumInStr(string[] strings)
        {
            List<string> result = new List<string>();

            foreach (var str in strings)
            {
                if (ContainsDigit(str)) 
                {
                    result.Add(str);
                }
            }

            return result.ToArray();
        }

        private static bool ContainsDigit(string s)
        {
            foreach (char c in s)
            {
                if (char.IsDigit(c))
                {
                    return true; 
                }
            }
            return false; 
        }


        static string reverseOdd(string str)
        {
            string[] arr = str.Split(' ');

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length % 2 != 0)
                {
                    arr[i] = new string(arr[i].Reverse().ToArray());
                }
            }

            return string.Join(" ", arr);
        }



        static bool IsPandigital(long num)
        {
            string str = num.ToString();
            for (int i = 0; i < 10; i++)
            {
                if (!str.Contains(i.ToString()))
                {
                    return false;
                }
            }
            return true;
        }


        /*   Task3   */
        static int add(int x, int y)
        {
            return x + y;
        }


        static string removeLeadingTrailing(string str)
        {
            str = str.TrimStart('0');
            if (str.Contains('.'))
            {
                str = str.TrimEnd('0');
                if (str.EndsWith("."))
                {
                    str = str.TrimEnd('.');
                }
            }
            return str;
        }

        public static int secondLargest(int[] numbers)
        {
          

            var sortedNumbers = numbers.OrderByDescending(x => x).ToArray();
            return sortedNumbers[1];
        }


        public static bool IsRepdigit(int num)
        {
            if (num < 0)
                return false;  

            string numStr = Math.Abs(num).ToString();  
            return numStr.Distinct().Count() == 1; 
        }

        public static string ReverseWords(string str)
        {
            string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Array.Reverse(words);

            return String.Join(" ", words);
        }


        public static string SevenBoom(int[] arr)
        {
            foreach (int num in arr)
            {
                if (num.ToString().Contains('7'))
                {
                    return "Boom!";
                }
            }
            return "there is no 7 in the array";
        }


        public static string InsertWhitespace(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            StringBuilder result = new StringBuilder();
            result.Append(input[0]); 

            for (int i = 1; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]) && char.IsLower(input[i - 1]))
                {
                    result.Append(' '); 
                }
                result.Append(input[i]);
            }

            return result.ToString();
        }

        public static int CountTrue(bool[] arr)
        {
            int count = 0;
            foreach (bool value in arr)
            {
                if (value)  
                {
                    count++; 
                }
            }
            return count;
        }

        public static string CapToFront(string s)
        {
            StringBuilder upperCase = new StringBuilder();
            StringBuilder lowerCase = new StringBuilder();

            foreach (char c in s)
            {
                if (char.IsUpper(c))
                {
                    upperCase.Append(c);  
                }
                else
                {
                    lowerCase.Append(c);  
                }
            }

            return upperCase.ToString() + lowerCase.ToString();
        }

        public static bool MatchLastItem(object[] items)
        {
            if (items == null || items.Length < 2)
                return false; 

            StringBuilder allButLast = new StringBuilder();
            for (int i = 0; i < items.Length - 1; i++)
            {
                allButLast.Append(items[i].ToString()); 
            }

            return allButLast.ToString() == items[^1].ToString();
        }


        public static int FindNaN(double[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (double.IsNaN(numbers[i]))
                {
                    return i;  
                }
            }
            return -1;  
        }

        public static int[] RemoveDupsInts(int[] items)
        {
            List<int> uniqueItems = new List<int>();
            HashSet<int> seen = new HashSet<int>();

            foreach (int item in items)
            {
                if (seen.Add(item))
                {
                    uniqueItems.Add(item);
                }
            }

            return uniqueItems.ToArray();
        }

        public static string[] RemoveDupsStrings(string[] items)
        {
            List<string> uniqueItems = new List<string>();
            HashSet<string> seen = new HashSet<string>();

            foreach (string item in items)
            {
                if (seen.Add(item))
                {
                    uniqueItems.Add(item);
                }
            }

            return uniqueItems.ToArray();
        }


        public static string ConvertTime(string time12hr)
        {
            DateTime time = DateTime.ParseExact(time12hr, "hh:mm:sstt", CultureInfo.InvariantCulture);

            return time.ToString("HH:mm:ss");
        }


        public static string RemoveLastVowel(string sentence)
        {
            string[] words = sentence.Split(' ');
            string vowels = "aeiouAEIOU";
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = words[i].Length - 1; j >= 0; j--)
                {
                    if (vowels.Contains(words[i][j]))
                    {
                        words[i] = words[i].Substring(0, j) + words[i].Substring(j + 1);
                        break;
                    }
                }
            }
            return string.Join(" ", words);
        }


        public static int SumOfCubes(int[] nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                sum += (int)Math.Pow(num, 3); 
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ConvertToSeconds(3));
        }
    }
}
