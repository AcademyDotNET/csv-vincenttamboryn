using System;

namespace Data.gov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(240, 60);
            string[,]cSV = CSV_reader.readCsv();
            Pokedex(cSV);
        }
        static void Pokedex<T>(T[,] array)
        {
            if (array.GetLength(0) > 0)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    for (int i = 0; i < array.GetLength(1); i++)
                    {
                        if (i == 1)
                        {
                            Console.SetCursorPosition(5, j);
                            Console.Write($"{array[j, i]}\t");
                        }
                        else if (i == 2)
                        {
                            Console.SetCursorPosition(32, j);
                            Console.Write($"{array[j, i]}\t");
                        }
                        else if (i == 3)
                        {
                            Console.SetCursorPosition(44, j);
                            Console.Write($"{array[j, i]}\t");
                        }
                        else if (i == 4)
                        {
                            Console.SetCursorPosition(56, j);
                            Console.Write($"{array[j, i]}\t");
                        }
                        else if (i == 12)
                        {
                            Console.SetCursorPosition(124, j);
                            Console.Write($"{array[j, i]}\t");
                        }
                        else
                        {
                            Console.Write($"{array[j, i]}\t");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Array is empty");
            }
        }
    }
}
