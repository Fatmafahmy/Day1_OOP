using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiment
{
    internal class point
    {

        public double x;
        public double y;

        public point(double x, double y)
        { 
            this .x =x;
            this .y = y;
        }
       public point ()
        {
            x = default;
            y = default;
        }
    }
}
