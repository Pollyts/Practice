using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_8
{
    class Program
    {
        public static void MyBubbleSort(ref int[,] A, int leng)
        {
            for (int i = 0; i < leng; i++)
            {
                for (int j = 0; j <leng - i - 1; j++)
                {
                    if (A[1,j] < A[1,j + 1])
                    {
                        int temp = A[1,j];
                        A[1,j] = A[1,j + 1];
                        A[1,j + 1] = temp;
                        temp = A[0, j];
                        A[0, j] = A[0, j + 1];
                        A[0, j + 1] = temp;
                    }
                }
            }
        }
        public static string [] TopSorted(int [,] numbers, string [] tops)
        {
            string[] newtops = new string[tops.Length];
            for (int i = 0; i < tops.Length; i++)
                newtops[i] = tops[numbers[0, i]];
            return newtops;
                
        }
        public static bool Connect(string top1, string top2, Interval [] intervals)
        {            
            for(int i=0; i<intervals.Length; i++)            
                if(((intervals[i].To==top1)&&(intervals[i].From==top2))||((intervals[i].To==top2)&&(intervals[i].From==top1)))                   
                    return true;     
            return false;
        }
        static void Main(string[] args)
        {
            Interval[] intervals = new Interval[0];
            string[] Tops = new string[0];
            string k;
            do
            {
                Console.WriteLine("1.Добавить вершину \n2.Добавить ребро \n3.Перейти к раскраске");
                k = Console.ReadLine();
                if (k == "1")
                {
                    Array.Resize(ref Tops, Tops.Length + 1);
                    Console.WriteLine("Введите название вершины");
                    Tops[Tops.Length - 1] = Console.ReadLine();
                }
                if(k=="2")
                {
                    Array.Resize(ref intervals, intervals.Length + 1);
                    intervals[intervals.Length - 1] = new Interval();
                    Console.WriteLine("Из какой вершины идет ребро?");
                    intervals[intervals.Length - 1].From = Console.ReadLine();
                    Console.WriteLine("В какую вершину переходит?");
                    intervals[intervals.Length - 1].To = Console.ReadLine();
                }
            } while (k != "3");
            int [,] numbers = new int[2, Tops.Length];
            for (int i = 0; i < Tops.Length; i++)
            {
                numbers[0, i] = i;
                for (int j = 0; j < intervals.Length; j++)
                {
                    if ((Tops[i] == intervals[j].To) || (Tops[i] == intervals[j].From))//считаем, сколько ребер у вершины
                        numbers[1, i]++;
                }
            }
            if (Tops.Length == 0)
            {
                Console.WriteLine("Нет вершин");
                Console.ReadKey();
                return;
            }
            MyBubbleSort(ref numbers, Tops.Length);
            Tops = TopSorted(numbers, Tops);
            for (int i = 0; i < Tops.Length; i++)
                Console.WriteLine("Вершина:" + Tops[i] + "  Ребер из нее:" + numbers[1,i]);
            int paint = 1;
            int[] paints = new int[Tops.Length];
            paints[0] = paint;
            bool ok=false;
            bool allpaints = false;
            while (!allpaints)//пока все вершины не раскрашены
            {
                for (int i = 1; i < Tops.Length; i++)
                {
                    if (paints[i] == 0)//если вершина неокрашенна 
                    {
                        for (int j = 0; j < i; j++)//проверяем от начала до текущей вершины
                        {
                            ok = false;
                            if (Connect(Tops[i], Tops[j], intervals)&&(paints[j]==paint))//если пересекается с кем-либо
                            {
                                ok = true;//завершаем два цикла:оставляем вершину и ничего с ней пока не делаем.                                
                                break;
                            }
                            else
                            {
                                ok = false;
                            }
                        }
                        if(!ok)//иначе
                            paints[i] = paint;//окрашиваем в цвет
                    }
                }//когда все вершины прошли
                paint++;//новый цвет
                for (int m = 0; m < paints.Length; m++)//проверка, остались ли неокрашенные вершины
                {
                    if (paints[m] == 0)//если хоть одна осталась неокрашена
                    {
                        paints[m] = paint;//т.к. вершины по убыванию, ей первой новая краска
                        allpaints = false;//еще не все были окрашены
                        break;
                    }
                    if ((paints[m] != 0) && (m == paints.Length - 1))//если перебор дошел до конца, и последняя вершина оказалась окрашенной
                        allpaints = true;//все вершины окрашены
                }
                
            }
            Console.WriteLine("Всего в работе использовалось " + (paint-1) + " цвета");
            for (int i = 0; i < paints.Length; i++)
                Console.WriteLine("Вершина: " + Tops[i] + ", цвет: " + paints[i]);
            Console.ReadKey();
        }
    }
}
