using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
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

            Random rnd = new Random();

            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                for (int j = 0; j < matr1.GetLength(1); j++)
                {
                    matr1[i, j] = rnd.Next(minr, maxr + 1);
                    Console.Write($"{matr1[i, j],4}");
                }
                Console.WriteLine();

            }

            int kx=0;
            int x = 1;
            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                for (int j = x; j < matr1.GetLength(1);j++)
                {
                    if (matr1[i, j] > 0)
                        kx = kx + 1;
                }
                x++;

            }
            Console.WriteLine("Количетсво положит. чисел выше диагонали равно={0}",kx);
            int suma = 0;
            int z = 0;
            for (int i = 1; i < matr1.GetLength(0); i++)
            {
               
                for (int j = 0; j < z+1; j++)
                {
                    suma = suma + matr1[i, j];
                    Console.WriteLine(suma);
                }
                z++;
            }

            Console.WriteLine("Сума чисел ниже диагонали равна={0}",suma);

        }

    }
}
