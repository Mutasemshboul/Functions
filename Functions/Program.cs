namespace Functions
{
    internal class Program
    {
        /*    1     */
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




        static void Main(string[] args)
        {
            Console.WriteLine(ConvertToSeconds(3));
        }
    }
}
