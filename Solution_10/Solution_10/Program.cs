using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_10
{
    class Program
    {
        public static Transition Add()
        {
            Transition tr = new Transition();
            Console.WriteLine("Из какой вершины?");
            tr.FromTop = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("В какую?");
            tr.ToTop = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Из какого значения?");
            tr.FromValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("В какое?");
            tr.ToValue = Convert.ToInt32(Console.ReadLine());
            return tr;
        }
        public static void Delete(ref Transition [] array, int index)
        {
            for (int i = index + 1; i < array.Length; i++)
            {
                array[i - 1] = array[i];
            }            
        }

        public static void Show(Transition[] array)
        {
            for(int i=0; i<array.Length; i++)
            {
                Console.WriteLine("Вершины: " + array[i].FromTop + " --> " + array[i].ToTop + "     Значения: " + array[i].FromValue + " --> " + array[i].ToValue);
            }
        }
        static void Main(string[] args)
        {
            Transition[] transitions = new Transition[0];
            string k;
            do
            {
                Console.WriteLine("1.Добавить переход \n2.Перейти дальше");
                k = Console.ReadLine();
                if (k == "1")
                {
                    Array.Resize(ref transitions, transitions.Length + 1);
                    transitions[transitions.Length - 1] = Add();
                    Show(transitions);
                }
            } while (k != "2");
            Console.WriteLine("Какое значение вы хотите стянуть?");
            int value = Convert.ToInt32(Console.ReadLine());
            int schetchik=0;
            int newTop=10000;
            bool ok = false;
            do
            {
                for (int i = 0; i < transitions.Length; i++)
                {
                    if ((value == transitions[i].FromValue) && (value == transitions[i].ToValue))
                    {
                        if(transitions[i].FromTop<newTop)
                        newTop = transitions[i].FromTop;
                        if (transitions[i].ToTop < newTop)
                        newTop = transitions[i].ToTop;
                        Delete(ref transitions, i);
                        schetchik++;
                        break;
                    }
                    if (i == 6)
                        ok = true;
                }
            } while (!ok);
            if (schetchik>0)
            {
                Array.Resize(ref transitions, transitions.Length - schetchik);
            }
            for (int i = 0; i < transitions.Length; i++)
            {
                if (transitions[i].FromValue == value)
                    transitions[i].FromTop = newTop;
                if (transitions[i].ToValue == value)
                    transitions[i].ToTop = newTop;
            }
            Console.WriteLine("Стянутый граф:");
            Show(transitions);
                    Console.ReadKey();
        }
    }
}
