using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillArrayByRandom
{
    internal class Program
    {
        static Random rnd = new Random();
        static void FillAndPrintArray(int[]arr , int index=0)
        {
            if (index == arr.Length)
                return;
            arr[index] = rnd.Next(1, 101);
            Console.Write(arr[index] + " ");
            FillAndPrintArray(arr, index + 1);
        }
        static void Main(string[] args)
        {
            Console.Write("size of array ? ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine(" array : ");
            FillAndPrintArray(arr);

        }
    }
}
