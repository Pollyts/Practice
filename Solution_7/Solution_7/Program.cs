using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a0=0, a1=0, a2=0, a3=0, a12=0, a13=0, a23=0, a123=0;            
            for(int i1=0; i1<=1; i1++)
                for (int i2 = 0; i2 <= 1; i2++)
                    for (int i3 = 0; i3 <= 1; i3++)
                        for (int i4 = 0; i4 <= 1; i4++)
                            for (int i5 = 0; i5 <= 1; i5++)
                                for (int i6 = 0; i6 <= 1; i6++)
                                    for (int i7 = 0; i7 <= 1; i7++)
                                        for (int i8 = 0; i8 <= 1; i8++)//10101010
                                        {
                                            a0 = i1%2;
                                            a3 = i2 - a0;
                                            a2 = i3 - a0;
                                            a23 = Math.Abs((i4 - a2 - a3-a0)%2);
                                            a1 = i5 - a0;
                                            a13 = Math.Abs((i6 - a1 - a3 - a0) % 2);
                                            a12 = Math.Abs((i7 - a1 - a2 - a0) % 2);
                                            a123 = Math.Abs((i8 - a1 - a2 - a3 - a12 - a13 - a23 - a0) % 2);
                                            if (a12 != 0 || a13 != 0 || a23 != 0 || a123 != 0)
                                                Console.WriteLine(i1 + ""+ i2 +""+ i3 +""+ i4 +""+ i5 +""+ i6 +""+ i7 +""+ i8);                                            
                                        }
            Console.ReadKey();

        }
    }
}
