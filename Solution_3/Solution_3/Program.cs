using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_3
{
    class Program
    {
        static double GetDouble()
        {            
            bool ok;
            double a;
            do
            {
                string b = Console.ReadLine();
                ok = Double.TryParse(b, out a);
                if (!ok)
                    Console.WriteLine("Введите вещественное число");
            } while (!ok);
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты x и у");
            double x = GetDouble();
            double y = GetDouble();
            if ((y >= -1) && (y <= 3 * x + 2) && (x>=(y-2)/3)&&(x<=(-y+2)/3))
                Console.WriteLine("Входит");
            else
                Console.WriteLine("Не входит");
            Console.ReadKey();
        }
    }
}
