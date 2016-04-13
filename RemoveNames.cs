using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> firstNames = new List<string>(Console.ReadLine().Split(' ').ToList());
            List<string> secondNames = new List<string>(Console.ReadLine().Split(' ').ToList());

            foreach (var name in secondNames)
            {
                firstNames.RemoveAll(item => item == name);
            }
            foreach (var name in firstNames)
            {
                Console.Write("{0} ", name);
            }
            Console.WriteLine();
        }
    }
}
