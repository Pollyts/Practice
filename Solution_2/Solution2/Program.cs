using System;
namespace Solution2
{
    class Program
    {        
        static int [,] MySort(int [,] array, int numbers)
        {
            int[,] newarray = new int[2, numbers];
            int[] temp = new int[numbers];
            for (int i = 0; i <numbers; i++)
                temp[i] = array[1, i];
            Array.Sort(temp);
            for(int i=0; i<numbers; i++)
                for(int j=0; j<numbers; j++)
                    if(temp[i]==array[1,j])
                    {
                        newarray[0, i] = array[0, j];
                        newarray[1, i] = array[1, j];
                    }
            return newarray;
        }
        static void Main(string[] args)
        {
            string[] inputdata = Console.ReadLine().Split(' ');
            int numbers = Convert.ToInt32(inputdata[0]);
            int basesalary = Convert.ToInt32(inputdata[1]);
            int[,] lastsalaries = new int[2, numbers];
            int[] difference = new int[numbers];
            int[] temp = new int[numbers];
            int[] towhom = new int[numbers];
            for (int person = 0; person < numbers; person++)
            {
                lastsalaries[0, person] = person + 1;
                lastsalaries[1, person] = Convert.ToInt32(Console.ReadLine());
                temp[person] = basesalary;

            }           
            
            {
                lastsalaries = MySort(lastsalaries, numbers);
                for (int i = 0; i < numbers; i++)
                {
                    if (lastsalaries[1, i] != basesalary)//если зп не равна базовой
                        for (int j = i + 1; j < numbers; j++)
                        {
                            if (lastsalaries[1, j] != basesalary)
                            {
                                towhom[i] = lastsalaries[0, j];
                                difference[i] = Math.Abs(temp[i] - lastsalaries[1, i]);
                                temp[j] += difference[i];
                                break;
                            }
                        }
                }
                for (int j = 1; j <= numbers; j++)
                    for (int i = 0; i < numbers; i++)
                        if (lastsalaries[0, i] == j)//если номер человека совпал с его индексом
                            if (difference[i] != 0)
                                Console.WriteLine(towhom[i] + " " + difference[i]);
                            else
                                Console.WriteLine(0 + " " + 0);
            }
            Console.ReadKey();
        }
    }
}
