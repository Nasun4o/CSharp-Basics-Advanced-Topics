using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        Regex linkParser = new Regex(@"\b(?:http://|www\.)\S+\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        string textStr = Console.ReadLine();

        foreach (Match m in linkParser.Matches(textStr))
        {
            Console.WriteLine(m);
        }
        Console.WriteLine();
    }
}