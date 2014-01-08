using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            TMatrix matrix = new TMatrix(5);
            for (int i = 0; i < matrix.size; ++i)
            {
                for (int j = 0; j < matrix.size; ++j)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();

            TMatrix matrix2 = new TMatrix(5);
            for (int i = 0; i < matrix2.size; ++i)
            {
                for (int j = 0; j < matrix2.size; ++j)
                    Console.Write(matrix2[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();

            TMatrix matrix3 = matrix * matrix2;
            for (int i = 0; i < matrix3.size; ++i)
            {
                for (int j = 0; j < matrix3.size; ++j)
                    Console.Write(matrix3[i, j] + " ");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
