using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    internal class QuizSolution
    {
        public static int[] RandomPosition(int[] n)
        {
            int[] array = n;
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int j = random.Next(0, n.Length);
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
            return array;
        }

        public static int[] ShiftArray(int[] n)
        {
            // local variable untuk return
            int[] array = n;
            var temp = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                array[i - 1] = array[i];
            }
            array[array.Length - 1] = temp;

            return array;
        }

        public static int[] Rotate(int[] hasil)
        {
            int[] n = hasil;
            for (int j = 1; j < 4; j++)
            {
                var temp = hasil[0];
                Console.WriteLine();
                Console.WriteLine($"Rotasi ke - {j} : ");
                for (int i = 1; i < hasil.Length; i++)
                {
                    hasil[i - 1] = hasil[i];
                }
                hasil[hasil.Length - 1] = temp;
                DisplayArrayInt(n);
                hasil = n;
            }
            return hasil;

        }

        public static int[] RightRotate(int[] hasil)
        {
            int[] n = hasil;
            for (int j = 1; j < 4; j++)
            {
                var temp = hasil[hasil.Length - 1];
                Console.WriteLine();
                Console.WriteLine($"Rotasi ke - {j} : ");
                for (int i = hasil.Length - 1; i > 0; i--)
                {
                    hasil[i] = hasil[i - 1];
                }
                hasil[0] = temp;
                DisplayArrayInt(hasil);
                hasil = n;

            }
            return hasil;
        }

        public static int[] SumAngka(int[] hasil)

        {
            int[] m = hasil.Distinct().ToArray();
            int count;

            for (int i = 0; i < hasil.Length; i++)
            {
                count = 0;
                for (int j = 0; j <= hasil.Length - 1; j++)
                {
                    if (hasil[i] == hasil[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine($"{m[i]} muncul sebanyak {count} kali");

            }
            return hasil;
        }

        //No. 6
        //No. 7
        public static int[] DuplicateArray(int[] hasil)
        {
            int[] o = hasil;
            int j = 0;
            Array.Sort(hasil);

            for (int i = 0; i < hasil.Length; i++)
            {
                if (hasil[i] != hasil[i + 1])
                {
                    hasil[j++] = hasil[i];
                }
            } //remove dupllicate
            hasil[j++] = hasil[hasil.Length - 1];
            for (int i = 0; i < j; i++)
            {
                hasil[j] = hasil[i];
            }

            return hasil;
        }






        public static int[] InitArraysInt(int[] arr)
        {
            int[] array = arr;
            return array;
        }

        public static void DisplayArrayInt(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
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
                    matrix[i, j] = i + j;
                    if (i != 0 && j != 0)
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
        public static void DisplayArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
        }
    }
}

