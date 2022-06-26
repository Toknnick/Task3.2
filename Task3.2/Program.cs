using System;
using System.Linq;

namespace Task3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int sizeOfArray = 10;
            int[,] arrayOfNumbers = new int[sizeOfArray, sizeOfArray];
            int maxNumberInArray = 100;
            int minNumberInArray = 10;
            int maxValueInArray = 0;
            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < arrayOfNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < arrayOfNumbers.GetLength(1); j++)
                {
                    arrayOfNumbers[i, j] = random.Next(minNumberInArray, maxNumberInArray);
                    Console.Write(arrayOfNumbers[i, j] + " ");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < arrayOfNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < arrayOfNumbers.GetLength(1); j++)
                {
                    if (maxValueInArray <= arrayOfNumbers[i, j])
                    {
                        maxValueInArray = arrayOfNumbers[i, j];
                    }
                }
            }

            for (int i = 0; i < arrayOfNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < arrayOfNumbers.GetLength(1); j++)
                {
                    if (maxValueInArray == arrayOfNumbers[i, j])
                    {
                        arrayOfNumbers[i, j] = 0;
                    }
                }
            }

            Console.WriteLine($"\nМассив после замены {maxValueInArray} на 0:\n");

            for (int i = 0; i < arrayOfNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < arrayOfNumbers.GetLength(1); j++)
                {
                    Console.Write(arrayOfNumbers[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
