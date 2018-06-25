using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_4
{
    class Program
    {
        static double GetE()
        {
            bool ok;
            double a;
            do
            {
                string b = Console.ReadLine();
                ok = Double.TryParse(b, out a);
                if ((!ok) || (a < 0) || (a > 1))
                {
                    ok = false;
                    Console.WriteLine("Введите вещественное число из промежутка (0; 1)");
                }
            } while (!ok);
            return a;
        }

        static void Main(string[] args)
        {
            double S = 0;
            long fact = 1;
            Console.WriteLine("Введите нужную точность");
            double e=GetE();            
            int i = 1;
            double last = 1;
            while (Math.Abs(last)>e)
            {
                fact =fact* i;
                last = Math.Pow(-2, i) / fact;
                S += last;
                i++;
            }
            Console.WriteLine(S);
            Console.ReadKey();
        }
    }
}
