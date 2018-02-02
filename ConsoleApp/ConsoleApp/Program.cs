using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {4, 28, 16, 47, 2, 86, 102, 12, 34};
            Console.WriteLine("Starting array:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Sorted array:");
            int[] sortedArray = performInsertionSort(array);
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write(sortedArray[i] + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        static int[] performInsertionSort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
            return inputArray;
        }

        static int[] BubbleSort (int[] array)
        {
            bool stillSort = false;
            // compares pairs of elements in the array until the entire array is sorted
            // do until stillSort is false
            // 4, 28, 16, 47, 2, 86, 102, 12, 34
            do
            {
                stillSort = false;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < array[i - 1])
                    {
                        int temp = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = temp;
                        stillSort = true;
                    }
                }
            } while(stillSort);
            return array;
        }

        static int[] MergeSort (int[] array)
        {
            //compares pairs of elements in the array until the entire array is sorted
            return array;
        }
    }
}