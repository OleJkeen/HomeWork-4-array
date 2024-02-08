using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines;
            int numberOfColumns;
            int sumOfLine = 0;
            int multiplicationOfColumns = 1;
            int minRandom = 3;
            int maxRandom = 5;
            int firstColumn = 0;
            int secondLine = 1;

            Random random = new Random();
            
            numberOfLines = random.Next(minRandom, maxRandom +1);
            numberOfColumns = random.Next(minRandom, maxRandom +1);
            
            int[,] array = new int[numberOfLines, numberOfColumns];
            Random randomArrayNumbers = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = randomArrayNumbers.Next(1, 5);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int j = 0; j < array.GetLength(1); j++)
            {
                sumOfLine += array[secondLine, j];
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                multiplicationOfColumns *= array[i, firstColumn];
            }

            Console.WriteLine(sumOfLine + " - Сумма второй строки");
            Console.WriteLine(multiplicationOfColumns + " - Произведение первого столбца");
            Console.ReadLine();
        }
    }
}
