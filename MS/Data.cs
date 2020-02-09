using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MS
{
    class Data
    {
      private  double width, height;
        public Data (double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public double Perimetr(double width, double height)
        {
            return (width/1000 + height/1000) * 2;
        }
        public double Square(double width, double height)
        {
            return width/1000 * height/1000;
        }
    }
}
