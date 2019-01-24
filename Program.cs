using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            OE_SORT.OESort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}
