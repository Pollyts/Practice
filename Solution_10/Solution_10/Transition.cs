using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_10
{
    class Transition
    {
        public int FromTop;
        public int ToTop;
        public int FromValue;
        public int ToValue;
        public Transition()
        {
            FromTop = 0;
            ToTop = 0;
            FromValue = 0;
            ToValue = 0;
        }
        public Transition(int one,int two,int three,int four)
        {
            FromTop = one;
            ToTop = two;
            FromValue = three;
            ToValue = four;
        }
    }    
}
