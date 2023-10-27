using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section8_1._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
            Console.ReadLine();
        }

        private static void runApp()
        {
            int[] array = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            int target = 30;

            int index = LinearSearch(array, target);

            if (index != -1)
            {
                Console.WriteLine("Element " + target + " found at index " + index);
            }
            else
            {
                Console.WriteLine("Element " + target + " not found in the array");
            }
        }

        public static int LinearSearch(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i; // Element found, return its index
                }
            }
            return -1; // Element not found
        }
    }
}
