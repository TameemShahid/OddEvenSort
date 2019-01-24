using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODDEVENSORT
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = OddEvenSort.RandomNumberGenerate();
            Console.WriteLine("Array Before Sorting: ");
            OddEvenSort.PrintArray(array);
            OddEvenSort.OESort(array);
            Console.WriteLine("Array After Sorting: ");
            OddEvenSort.PrintArray(array);
        }
    }
}
