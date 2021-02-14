using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task_2_14_02_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 10, 11, 11, 12, 12, 40, 40, 16, 17, 18 };
            int i, j,  k= 0;


            for (i = 0; i < 10; i++)
            {
                for (j = i + 1; j < 10; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        k++;
                        break;
                    }
                }
            }

            Console.WriteLine("\n Total  duplicate elements found :" + k);
            Console.ReadLine();
        }
    }
}
