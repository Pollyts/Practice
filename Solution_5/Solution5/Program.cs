using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution5
{
    class Program
    {
        static int GetN()
        {
            bool ok;
            int a;
            do
            {
                string b = Console.ReadLine();
                ok = Int32.TryParse(b, out a);
                if ((!ok) || (a <= 0))
                {
                    ok = false;
                    Console.WriteLine("Введите целое положительное число");
                }
            } while (!ok);
            return a;
        }
        static void GetRandomMatr(ref int [,] matr, int n)
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matr[i, j] = rand.Next(0, 1000);
                    Console.Write(matr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int n = GetN();
            int[,] matr = new int[n, n];
            GetRandomMatr(ref matr,n);
            int stolb = n - 1;
            int str = 0;
            int max = matr[0, n];
            do
            {
                stolb--;
                str++;
                for (int i = stolb; i < n; i++)
                    if (matr[str, i] > max)
                        max = matr[str, i];

            } while (str != (n - 1) && (stolb != 0));
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
