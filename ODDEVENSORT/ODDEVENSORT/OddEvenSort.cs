using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODDEVENSORT
{
    class OddEvenSort
    {
        public static int[] RandomNumberGenerate()
        {
            int size; 
            Console.Write("Enter the size of the array: ");
            size = int.Parse(Console.ReadLine()); 
            int[] array = new int[size]; 

            Random ran = new Random(); 
            for (int i = 0; i < size; i++)
            {
                array[i] = ran.Next(1,1000); //generating random numbers at each index of the array
            }

            return array;
        }
        public static int[] OESort(int[] array)
        {
            bool sorted = false; //sorted is equals to false to make the while loop run for the first iteration

            while (sorted == false)
            {
                sorted = true; // we set sorted equals to true to assume that our array or data is sorted

                for (int i = 1; i <= array.Length - 2; i = i + 2) //we increment i by i+2 to check odd indexes
                {
                    if (array[i] > array[i + 1]) //if ith index is greater than ith + 1 index meaning in wrong order than the elements are swapped
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        sorted = false;  //if there is a swapping then the array was not sorted and sorted is set equals to false
                    }
                }

                for (int i = 0; i <= array.Length - 2; i = i + 2) //same logic as first for loop to check even indexes
                {
                    if (array[i] > array[i + 1]) //same condition as the first loop
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        sorted = false;
                    }
                }
            }
            return array;
        }

        public static void PrintArray(int[] array) //function for printing the array
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
