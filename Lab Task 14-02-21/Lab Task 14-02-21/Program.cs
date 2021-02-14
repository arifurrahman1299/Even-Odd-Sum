using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        public static void Main()
        {
            int[] arr1 = new int[6] { 10, 21, 52, 12, 45, 70};
            int[] arr2 = new int[6];
            int i;

            for (i = 0; i < 6; i++)
            {
                arr2[i] = arr1[i];
            }

            Console.Write("\nThe values is 1st array :\n");
            for (i = 0; i < 6; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }

            Console.Write("\n\nThe values copied in second array are :\n");
            for (i = 0; i < 6; i++)
            {
                Console.Write("{0}  ", arr2[i]);
            }
            Console.Write("\n");
        }
    }
}