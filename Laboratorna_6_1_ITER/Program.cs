using System;

namespace Laboratorna_6_1_ITER
{
    public class Program
    {
        public static void FillArray(int[] b)
        {
            Random random = new Random();

            for (int i = 0; i < 21; ++i)
            {
                b[i] = random.Next(10, 91);
            }
        }

        public static void PrintArray(int[] b)
        {
            for (int i = 0; i < 21; ++i)
            {
                Console.Write($"{b[i],4}");
            }
            Console.WriteLine();
        }

        public static void ProcessArray(int[] b, out int count, out int sum)
        {
            count = 0;
            sum = 0;

            for (int i = 0; i < b.Length; ++i)
            {
                if (!(b[i] % 2 != 0 && b[i] % 3 == 0))
                {
                    count++;
                    sum += b[i];
                    b[i] = 0;
                }
            }
        }

        static void Main()
        {
            int[] myArray = new int[21];
            int count, sum;

            FillArray(myArray);
            Console.Write("Original Array: ");
            PrintArray(myArray);

            ProcessArray(myArray, out count, out sum);
            Console.Write("Modified Array: ");
            PrintArray(myArray);
            Console.WriteLine($"Count of elements satisfying the criteria: {count}");
            Console.WriteLine($"Sum of elements satisfying the criteria: {sum}");

            Console.ReadLine();
        }
    }
}