using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace Data.gov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(240, 60);
            string[,] cSV = CSV_reader.readCsv();
            Pokedex(cSV);
            CreateTxT(cSV);
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
        static void CreateTxT(string[,] text)
        {
            DateTime datum = DateTime.Today;
            string date = Convert.ToString(datum);
            string space ="";

            using (StreamWriter streamWriter = new StreamWriter($@"D:\documenten\Programmeren\C#\CSVs\DemoData.txt"))
            
            for (int j = 0; j < text.GetLength(0); j++)
            {
                for (int i = 0; i < text.GetLength(1); i++)
                {
                    if (i == 1)
                    {
                        for(int k = 0; k < (25-text[j,i].Length);k++)
                        {
                            space += " ";
                        }
                        streamWriter.Write($"{text[j, i]}{space}");
                        space = "";
                    }
                    else if (i == 2)
                    {
                        for (int k = 0; k < (12 - text[j, i].Length); k++)
                        {
                            space += " ";
                        }
                        streamWriter.Write($"{text[j, i]}{space}");
                        space = "";
                    }
                    else if (i == 3)
                    {
                        for (int k = 0; k < (12 - text[j, i].Length); k++)
                        {
                            space += " ";
                        }
                        streamWriter.Write($"{text[j, i]}{space}");
                        space = "";
                    }
                    else if (i == text.GetLength(1) - 2)
                    {
                        for (int k = 0; k < (12 - text[j, i].Length); k++)
                        {
                            space += " ";
                        }
                        streamWriter.Write($"{text[j, i]}{space}");
                        space = "";
                    }
                    else if (i == text.GetLength(1) - 1)
                    {
                        streamWriter.Write($"{text[j, i]}");
                    }
                    else
                    {
                        streamWriter.Write($"{text[j, i]}\t");
                    }
                }
                streamWriter.WriteLine();
            }
        }
    }
}
