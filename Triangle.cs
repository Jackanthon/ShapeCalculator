using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2ASsignment1
{
    class Triangle : Shape
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }
        public override decimal Perimeter()
        {
            int perimeter = Side1 + Side2 + Side3;
            return perimeter;
        }
        public override decimal Area()
        {
            int s = (Side1 + Side2 + Side3) / 2;
            int area = Convert.ToInt32(Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3)));
            return area;
        }
    }
}
