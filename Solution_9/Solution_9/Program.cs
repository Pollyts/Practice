using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_9
{
    class Program
    {
        static void Main(string[] args)
        {
            List beg = new List();
            bool ok=false;
            string t;
            do
            {
                Console.WriteLine("1.Добавить элемент в список \n2.Перейти к подсчету элементов");
                t = Console.ReadLine();
                if((t=="1")&&(!ok))
                {
                    beg = List.AddFirst();
                    ok = true;
                }
                else if ((t == "1") && (ok))
                {
                    beg = List.Add(beg);
                }
            } while (t != "2");
            int k = 0;
            List.CountListUsingRecursion(beg, ref k);
            Console.WriteLine("Количество элементов при подчете нерекурсивным методом: " + List.CountList(beg));
            Console.WriteLine("Количество элементов при подсчете рекурсивным методом: " +k);
            Console.ReadKey();
        }
    }
}
