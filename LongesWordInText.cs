using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;


    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            string text = Console.ReadLine();
            text = Regex.Replace(text, @"[^\w\]", string.Empty);
            string[] sentence = text.Split();
            int maxLenght = int.MinValue;
            string longestWord = string.Empty;
            foreach (string word in sentence)
            {
                char[] letter = word.ToCharArray();
                if (letter.Length > maxLenght)
                {
                    maxLenght = letter.Length;
                    longestWord = new string(letter);
                }
            }
            Console.WriteLine("{0}", longestWord);
        }
    }
// Imam problem s parsvaneto ako moje da kajete kak shte stane shte sum blagodaren :)