using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, minr, maxr;
            bool f;
            do
            {
                Console.WriteLine("Введите количество строк : ");
                f = int.TryParse(Console.ReadLine(), out n);
            } while (f == false);
            do
            {
                Console.WriteLine("Введите количество столб.: ");
                f = int.TryParse(Console.ReadLine(), out m);
            } while (f == false);
            do
            {
                Console.WriteLine("Введите диапазон чисел.: ");
                f = int.TryParse(Console.ReadLine(), out minr);
            } while (f == false);
            do
            {
                f = int.TryParse(Console.ReadLine(), out maxr);
            } while (f == false);
            int[,] matr1 = new int[n, m];
            int[,] matr2 = new int[m, n];
            int[,] matr3 = new int[m, n];

            Random rnd = new Random();
            Console.WriteLine("Первая матрица");
            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                for (int j = 0; j < matr1.GetLength(1); j++)
                {
                    matr1[i, j] = rnd.Next(minr, maxr + 1);
                    Console.Write($"{matr1[i, j],4}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Вторая матрица");
            for (int i = 0; i < matr2.GetLength(0); i++)
            {
                for (int j = 0; j < matr2.GetLength(1); j++)
                {
                    matr2[i, j] = rnd.Next(minr, maxr + 1);
                    Console.Write($"{matr2[i, j],4}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Результ. матрица");
            for (int i = 0; i < matr3.GetLength(0); i++)
                {

                    for (int j = 0; j < matr3.GetLength(1); j++)
                    {
                    matr3[i, j] = 0;
                    for (int k = 0; k < n-1; k++)
                    {
                        matr3[i, j] += matr1[i, k] * matr2[k, j];
                        
                    }
                    Console.Write($"{matr3[i, j],4}");
                }
                Console.WriteLine();
                }
                        
            
        }
    }
}
