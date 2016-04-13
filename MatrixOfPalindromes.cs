using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class MatrixOfPalindromes
    {
        static void Main()
        {
            string[] userInput = Console.ReadLine().Split(' ');
            int rows = int.Parse(userInput[0]);
            int col = int.Parse(userInput[1]);
            string[,] palindromes = new string[rows, col];

            for (int i = 0; i < palindromes.GetLength(0); i++)
            {
                for (int j = 0; j < palindromes.GetLength(1); j++)
                {
                    palindromes[i, j] = "" + (char)('a' + i) + (char)('a' + i + j) + (char)('a' + i);
                }
            }
            for (int i = 0; i < palindromes.GetLength(0); i++)
            {
                for (int j = 0; j < palindromes.GetLength(1); j++)
                {
                    Console.Write("{0} ", palindromes[i, j]);
                }
                Console.WriteLine();
            }
        }
    }