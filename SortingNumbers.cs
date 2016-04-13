using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SortingNumbers
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
        
        Array.Sort(numbers);

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
