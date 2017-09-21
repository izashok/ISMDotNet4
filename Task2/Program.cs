using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
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




    }
}
