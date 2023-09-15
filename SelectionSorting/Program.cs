using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[7];

            // Input
            Console.WriteLine("Enter 7 numbers: ");
            for (int i = 0; i < 7; ++i)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Selection Sort
            for (int i = 0; i < 6; ++i)
            {
                int minIndex = i;
                for (int j = i + 1; j < 7; ++j)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }

            // Sorted Output
            Console.Write("Sorted numbers: ");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            return;
        }
    }
}
