using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Solution_12
{
    class Program
    {
        static Random rand = new Random();
        static public void merge(int [] arr, int l, int m, int r)
        {
            int i, j, k;
            int n1 = m - l + 1;
            int n2 = r - m;
            int[] L = new int[n1];
            int[] R = new int[n2];

            
            for (i = 0; i < n1; i++)
                L[i] = arr[l + i];
            for (j = 0; j < n2; j++)
                R[j] = arr[m + 1 + j];

            i = 0; 
            j = 0; 
            k = l; 
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }          
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
        static void mergeSort(int [] arr, int l, int r)
        {
            if (l < r)
            {                
                int m = l + (r - l) / 2;               
                mergeSort(arr, l, m);
                mergeSort(arr, m + 1, r);
                merge(arr, l, m, r);
            }
        }
        public static void sorting(ref int[] arr, int range, int length)
        {
            ArrayList[] lists = new ArrayList[range];
            for (int i = 0; i < range; ++i)
                lists[i] = new ArrayList();

            for (int step = 0; step < length; ++step)
            {
                //распределение по спискам
                for (int i = 0; i < arr.Length; ++i)
                {
                    int temp = (arr[i] % (int)Math.Pow(range, step + 1)) /
                                                  (int)Math.Pow(range, step);
                    lists[temp].Add(arr[i]);
                }
                //сборка
                int k = 0;
                for (int i = 0; i < range; ++i)
                {
                    for (int j = 0; j < lists[i].Count; ++j)
                    {
                        arr[k++] = (int)lists[i][j];
                    }
                }
                for (int i = 0; i < range; ++i)
                    lists[i].Clear();
            }
        }
               
                static public void Show(int [] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
        }
        static void Main(string[] args)
        {          
            int size = 50;
            int[] array1 = new int[size];
            int[] array2 = new int[size];
            for (int i = 0; i < size; i++)
            {
                int t = rand.Next(0, 1000);
                array1[i] = t;
                array2[i] = t;
            }            
            Console.WriteLine("до");
            Show(array1);
            Console.WriteLine("после использования сортировки слиянием");
            mergeSort(array1, 0, array1.Length-1);
            Show(array1);
            Console.WriteLine("до");
            Show(array2);
            Console.WriteLine("после использования поразрядной сортировки");
            sorting(ref array2, 10, 4);
            Show(array2);
            Console.ReadKey();
        }
    }
}
