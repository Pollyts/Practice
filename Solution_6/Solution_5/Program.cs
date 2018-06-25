using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_5
{
    class Program
    {//Построить последовательность чисел ак = 13* ак–1 – 10* ак-2 + ак–3. 
        //Построить N элементов последовательности проверить, образуют ли элементы, стоящие на четных местах, возрастающую подпоследовательность.

        static int Create(int a3, int a2, int a1)
        {
            return 13 * a3 - 10 * a2 + a1;
        }
        static int GetA()
        {
            bool ok;
            int a;
            do
            {
                string b = Console.ReadLine();
                ok = Int32.TryParse(b, out a);
                if (!ok)
                {
                    ok = false;
                    Console.WriteLine("Введите вещественное число");
                }
            } while (!ok);
            return a;
        }
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
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Введите a1, a2, a3");
            int a1 = GetA();
            int a2 = GetA();
            int a3 = GetA();
            Console.WriteLine("Введите N");
            int n = GetN();
            int [] elements = new int[3+n];
            elements[0] = a1;
            elements[1] = a2;
            elements[2] = a3;
            for (int i = 3; i < elements.Length; i++)
            {
                elements[i] = Create(elements[i-1],elements[i-2],elements[i-3]);
                Console.WriteLine(elements[i]);
            }
            int temp = elements[1];
            bool ok = false;
            for(int i=3; i<elements.Length; i++)
                if(i%2==1)
                {
                    if(temp>=elements[i])
                    {
                        ok = false;
                        break;
                    }
                    else
                    {
                        ok = true;
                        temp = elements[i];
                    }
                }
            if (ok)
                Console.WriteLine("Образуют возрастающую постпоследовательность");
            else Console.WriteLine("Не образуют возрастающую постпоследовательность");
            Console.ReadKey();
        }
    }
}
