using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplex
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double[,] table = { {25, -3,  5},
                                {30, -2,  5},
                                {10,  1,  0},
                                { 6,  3, -8},};

                double[] result = new double[2];
                double[,] table_result;
                Simplex S = new Simplex(table);
                table_result = S.Calculate(result);

                Console.WriteLine("Решенная симплекс-таблица:");
                for (int i = 0; i < table_result.GetLength(0); i++)
                {
                    for (int j = 0; j < table_result.GetLength(1); j++)
                        Console.Write(table_result[i, j] + " ");
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("Решение:");
                Console.WriteLine("X[1] = " + result[0]);
                Console.WriteLine("X[2] = " + result[1]);
                Console.ReadLine();
            }
        }
    }
}
