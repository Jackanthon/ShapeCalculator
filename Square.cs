using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2ASsignment1
{
    class Square : Shape
    {
        public decimal Side { get; set; }
        public override decimal Perimeter()
        {
            decimal perimeter = Side * 4;
            return perimeter;
        }
        public override decimal Area()
        {
            decimal area = Side * Side;
            return area;
        }
    }
}
