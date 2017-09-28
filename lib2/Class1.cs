using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib2
{
    public class Class1
    {

        public static void Result(int[,] matr1, int[,] matr2, ref int n, ref int m)
        {
            int[,] matr3 = new int[m, n];
            Console.WriteLine("Результ. матрица");
            for (int i = 0; i < matr3.GetLength(0); i++)
            {

                for (int j = 0; j < matr3.GetLength(1); j++)
                {
                    matr3[i, j] = 0;
                    for (int k = 0; k < n - 1; k++)
                    {
                        matr3[i, j] += matr1[i, k] * matr2[k, j];

                    }
                    Console.Write($"{matr3[i, j],4}");
                }
                Console.WriteLine();
            }

        }

        public static void Suma(int[,] matr1, ref int m)
        {

            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                int zaq = 0;
                for (int j = 0; j < m - 1; j++)
                {
                    zaq = matr1[i, j] + zaq;
                    matr1[i, m - 1] = zaq;

                }


            }
            Console.WriteLine();
            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                for (int j = 0; j < matr1.GetLength(1); j++)

                {
                    Console.Write($"{matr1[i, j],4}");
                }
                Console.WriteLine();

            }
        }

        public static void Diag(int[,] matr1)
        {
            int kx = 0;
            int j = 1;
            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                for (j = j; j < matr1.GetLength(1); j++)
                {
                    if (matr1[i, j] > 0)
                        kx = kx + 1;
                }
                j++;

            }
            Console.WriteLine("Количетсво положит. чисел выше диагонали равно={0}", kx);

            int suma = 0;
            int z = 0;
            for (int i = 1; i < matr1.GetLength(0); i++)
            {

                for (int j = 0; j < z + 1; j++)
                {
                    suma = suma + matr1[i, j];
                    Console.WriteLine(suma);
                }
                z++;
            }

            Console.WriteLine("Сума чисел ниже диагонали равна={0}", suma);

        }
    }
}
