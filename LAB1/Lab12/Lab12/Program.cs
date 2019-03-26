using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of numbers: ");
            int N = Convert.ToInt32(Console.ReadLine());



            while (true)
            {
                Console.WriteLine("0 - For manually entering the numbers\n" +
                                  "1 - For generating randomly\n\n" +
                                  "Enter your choice:");

                int choice = Convert.ToInt32(Console.ReadLine());

                int max = Int32.MinValue;
                int min = Int32.MaxValue;
                long sum = 0;

                if (choice == 0)
                {
                    Console.WriteLine($"Enter the {N} numbers:");
                    for (int i = 0; i < N; ++i)
                    {
                        int number = Convert.ToInt32(Console.ReadLine());
                        //int number = random.Next(1, 1000);
                        sum += number;
                        if (max < number)
                            max = number;
                        if (min > number)
                            min = number;
                    }
                    Console.WriteLine("Average\tMax\tMin");
                    Console.WriteLine("{0}\t{1}\t{2}", sum * 1.0 / N, max, min);
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
                        sum += number;
                        if (max < number)
                            max = number;
                        if (min > number)
                            min = number;
                    }
                    Console.WriteLine("Average\tMax\tMin");
                    Console.WriteLine("{0}\t{1}\t{2}", sum * 1.0 / N, max, min);

                    break;
                }
                else
                {
                    Console.WriteLine("You entered wrong choice. Only 0 or 1 are acceptable.\nTryAgain!\n");
                }
            }
            Console.ReadKey();
        }
    }
}
