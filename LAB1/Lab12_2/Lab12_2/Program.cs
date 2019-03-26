using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of numbers: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[N];
            while (true)
            {
                Console.WriteLine("0 - For manually entering the numbers\n" +
                                  "1 - For generating randomly\n\n" +
                                  "Enter your choice:");

                int choice = Convert.ToInt32(Console.ReadLine());

                int max;
                int min;
                double avg;

                if (choice == 0)
                {
                    Console.WriteLine($"Enter the {N} numbers:");
                    for (int i = 0; i < N; ++i)
                    {
                        int number = Convert.ToInt32(Console.ReadLine());
                        numbers[i] = number;
                    }
                    minMaxAvg(numbers, out avg, out max, out min);
                    Console.WriteLine("Average\tMax\tMin");
                    Console.WriteLine("{0}\t{1}\t{2}", Math.Round(avg, 2), max, min);
                    break;
                }
                else if (choice == 1)
                {
                    Random random = new Random();
                    for (int i = 0; i < N; ++i)
                    {
                        //Console.WriteLine($"Enter {N} number:");
                        //int number = Convert.ToInt32(Console.ReadLine());
                        int number = random.Next(1, 1000);
                        numbers[i] = number;
                    }
                    minMaxAvg(numbers, out avg, out max, out min);
                    Console.WriteLine("Average\tMax\tMin");
                    Console.WriteLine("{0}\t{1}\t{2}", Math.Round(avg,2), max, min);
                    break;
                }
                else
                {
                    Console.WriteLine("You entered wrong choice. Only 0 or 1 are acceptable.\nTryAgain!\n");
                }
            }
            Console.ReadKey();
        }

        static void minMaxAvg(int[] numbers, out double avg, out int min, out int max)
        {
            long sum = 0;
            min = Int32.MaxValue;
            max = Int32.MinValue;
            foreach (int number in numbers)
            {
                if (max < number)
                    max = number;
                if (min > number)
                    min = number;

                sum += number;
            }
            avg = sum * 1.0 / numbers.Length;
        }
    }
}
