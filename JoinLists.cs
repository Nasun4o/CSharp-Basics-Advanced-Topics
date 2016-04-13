using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = new List<int>(Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToList());
            List<int> secondList = new List<int>(Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToList());
            List<int> result = firstList.Union(secondList).ToList();

            result.Sort();
            foreach (var item in result)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
    }
}
