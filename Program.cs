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

            Random randomOfLines = new Random();
            numberOfLines = randomOfLines.Next(3, 5);
            
            Random randomOfColumns = new Random();
            numberOfColumns = randomOfColumns.Next(3, 5);
            
            int[,] myArray = new int[numberOfLines, numberOfColumns];
            Random myRandom = new Random();

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for(int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = myRandom.Next(1, 5);
                    Console.Write(myArray[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                if (j < myArray.GetLength(1))
                {
                    sumOfLine += myArray[1, j];
                }
            }

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                multiplicationOfColumns *= myArray[i, 0];
            }

            Console.WriteLine(sumOfLine + " - Сумма второй строки");
            Console.WriteLine(multiplicationOfColumns + " - Произведение первого столбца");
            Console.ReadLine();
        }
    }
}
