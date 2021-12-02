using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arr1 = new int[7];
            int[] arr2 = new int[9];
            int[] arr3 = new int[16];
            for (int i = 0; i < arr1.Length; i++)
                arr1[i] = rnd.Next(1, 10);
            for (int i = 0; i < arr2.Length; i++)
                arr2[i] = rnd.Next(11, 20);
            Console.WriteLine("Исходный массив 1:");
            foreach (int digit in arr1)
                Console.Write("{0,3}", digit);
            Console.WriteLine("\nИсходный массив 2:");
            foreach (int digit in arr2)
                Console.Write("{0,3}", digit);
            Array.Copy(arr1, 0, arr3, 0, 7);
            Array.Copy(arr2, 0, arr3, 7, 9);
            Array.Sort(arr3);
            Array.Reverse(arr3);
            Console.WriteLine("\nИтоговый массив:");
            foreach (int digit in arr3)
                Console.Write("{0,3}", digit);
            Console.ReadKey();
        }


    }
}
