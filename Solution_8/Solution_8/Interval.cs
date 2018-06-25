using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_8
{
    class Interval
    {
        public string From;
        public string To;
        public Interval()
        {
            From = "";
            To = "";
        }
        public Interval(string from, string to)
        {
            From = from;
            To = to;
        }
    }
}
