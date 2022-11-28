using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_HW38
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[5];
            Random rand = new Random();
            void PrintArray(double[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }

            void FillArray(double[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = Math.Round(rand.NextDouble() * 100, 2);
                }
            }

            double MaxVal(double[] arr)
            {
                int i = 0;
                double max_val = arr[i];
                for (i = 0; i < arr.Length; i++)
                {
                    if (max_val < arr[i])
                    {
                        max_val = arr[i];
                    }
                }
                return max_val;
            }
            double MinVal(double[] arr)
            {
                int i = 0;
                double min_val = arr[i];
                for (i = 0; i < arr.Length; i++)
                {
                    if (min_val > arr[i])
                    {
                        min_val = arr[i];
                    }
                }
                return min_val;
            }

            FillArray(array);
            PrintArray(array);


            double min = MinVal(array);
            Console.Write("\nMin: " + min);

            double max = MaxVal(array);
            Console.Write("\nMax: " + max);

            Console.Write($"\nРазница между максимальным и минимальным элементами массива: {max - min}");
            Console.WriteLine();
        }

    }
}
