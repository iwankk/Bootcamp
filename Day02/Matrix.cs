using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    internal class Matrix
    {
        public static void InitMatrix()
        {
            int[,] matrix = new int[5, 5];
            matrix[2, 2] = 125;
            // Console.WriteLine(matrix);
        }

        public static int[,] FillRandomMatrix(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            Random random = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++) // i = baris
            {
                for (int j = 0; j < matrix.GetLength(1); j++)// j= kolom
                {
                    matrix[i, j] = random.Next(20);
                }
            }

            return matrix;
        }


        public static int[,] MatrixDiagonal(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            int counter = 5;

            // fill matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // isi diagonal
                    if (i == j)
                    {
                        matrix[i, j] = counter--;
                    }
                    else if (j > i)
                    {
                        matrix[i, j] = 20;
                    }
                    else if (i > j)
                    {
                        matrix[i, j] = 10;
                    }
                }
            }
            return matrix;
        }

        public static int[,] SumMatrixDiagonal(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            Random random = new Random();
            int hasil = 0;
            // fill matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // isi diagonal
                    if (i == j)
                    {
                        matrix[i, j] = random.Next(10);
                        hasil = hasil + matrix[i, j];
                    }
                    else if (j > i)
                    {
                        matrix[i, j] = 10;
                    }
                    else if (i > j)
                    {
                        matrix[i, j] = 20;
                    }
                }
            }
            Console.WriteLine($"total sum " + hasil);
            return matrix;

        }
        public static int[,] soal11(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            Random random = new Random();
            int panjangbaris = matrix.GetLength(0);
            int panjangkolom = matrix.GetLength(1);
            int awalbaris = 0;
            int awalkolom = 0;

            // fill matrix
            for (int i = 0; i < panjangbaris; i++)
            {
                for (int j = 0; j < panjangkolom; j++)
                {
                    // isi diagonal
                    if (i == awalbaris)
                    {
                        matrix[i, j] = j;

                    }
                    else if (i == panjangbaris && j != awalkolom)
                    {
                        matrix[i, j] = j;

                    }
                    else if (j == awalkolom)
                    {
                        matrix[i, j] = i;
                    }

                    else if (j == panjangkolom && i != awalbaris)
                    {
                        matrix[i, j] = i;
                    }
                    else if (j == panjangkolom && i == panjangbaris)
                    {
                        matrix[i, j] = i;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;

        }
        public static int[,] Matrix7(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            int c = baris - 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == i + j)
                    {
                        if (i != 0 && j != 0)
                        {
                            if (i != c && j != c)
                            {
                                matrix[i, j] = 0;
                            }

                        }
                    }

                }
            }

            return matrix;
        }
        public static int[,] EmptyMidMatrix(int baris, int kolom)
        {
            int[,] array = new int[baris, kolom];
            int n = baris - 1;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = i + j;
                    if (i != 0 && j != 0)
                    {
                        if (i != n && j != n)
                        {
                            array[i, j] = 0;
                        }
                    }
                }
            }
            return array;
        }

        public static void DisplayMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++) // looping baris
            {
                for (int j = 0; j < matrix.GetLength(1); j++)//loop kolom
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
