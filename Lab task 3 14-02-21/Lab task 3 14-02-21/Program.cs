using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task_3_14_02_21
{
    class Program
    {
        public static void Main()
        {
            int n = 0;
            int[] arr1 = new int[5] { 1, 1, 2, 3, 4 };
            int i, j, k;

            for (i = 0; i < 5; i++)
            {
                n = 0;

                for (j = 0; j < i - 1; j++)
                {

                    if (arr1[i] == arr1[j])
                    {
                        n++;
                    }
                }

                for (k = i + 1; k < 5; k++)
                {

                    if (arr1[i] == arr1[k])
                    {
                        n++;
                    }

                    if (arr1[i] == arr1[i + 1])
                    {
                        i++;
                    }
                }

                if (n == 0)
                {
                    Console.Write("{0} ", arr1[i]);
                }
            }
            Console.Write("\n\n");
        }
    }
}