using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DifferenceBetweenDates
{
    static void Main()
    {
        DateTime date1 = DateTime.Parse(Console.ReadLine());
        DateTime date2 = DateTime.Parse(Console.ReadLine());

        TimeSpan diff = date2.Subtract(date1);
        Console.WriteLine(diff.Days);
    }
}