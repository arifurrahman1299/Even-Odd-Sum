using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class evenOddSum
{
    static void Main(string[] args)
    {

        int i, num1, num2, odd = 0, even = 0;

        Console.Write("Enter numbers: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        for (i = 1; i <= num1; i += 2)
        {
            odd += i;
        }
        Console.WriteLine("Sum of all odd numbers between 1 to " + num1 + " = " + odd);


        num2 = Convert.ToInt32(Console.ReadLine());

        for (i = 0; i <= num2; i += 2)
        {
            even += i;
        }
        Console.WriteLine("Sum of all even numbers between 1 to " + num2 + " = " + even);

        Console.ReadLine();
    }
}
