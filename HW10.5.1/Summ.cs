using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10._5._1
{
    internal class Summ : ISummator
    {
        internal double X { get; set; }
        internal double Y { get; set; }
        internal Summ(double x, double y)
        {
            X = x;
            Y = y;
        }
        internal double Sum(double x, double y)
        {
            return X + Y;
        }
    }
}
