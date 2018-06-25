using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_9
{    
    class List
    {       
        int data; //информационное поле
        List next; //адресное поле
        public List()//конструктор без параметров
        {
            data = 0;
            next = null;
        }
        public List(int d)//конструктор с параметрами
        {
            data = d;
            next = null;
        }
        public static List AddFirst()
        {            
            Random rnd = new Random();
            int info = rnd.Next(0, 1000);
            Console.WriteLine("Элемент {0} добавлен", info);
            List beg = new List(info);            
            return beg;
        }
        public static List Add(List beg)
        {
            Random rnd = new Random();
            int info = rnd.Next(0, 1000);
            Console.WriteLine("Элемент {0} добавлен", info);
            List Bbeg = beg;
            List r = new List(info);
            while (beg.next!=null)
            {
                beg = beg.next;
            }
            beg.next = r;
            return Bbeg;
        }
        public static int CountList(List beg)
        {
            int k = 0;
            if (beg == null)
            {                
                return 0;
            }
            List p = beg;
            while (p != null)
            {               
                p = p.next;//переход к следующему элементу
                k++;
            }
            return k;
        }
        public static void CountListUsingRecursion(List beg, ref int k )
        {            
            if (beg == null)
            {
                k = 0;
                return;
            }               
            if (beg.next == null)
            {
                k++;
            }
            if (beg.next != null)
            {           
                CountListUsingRecursion(beg.next,ref k);
                k++;
            }            
        }
    }
}
