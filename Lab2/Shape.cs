using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab2
{
    abstract class Shape : IDraw, ICalcPS
    {
        public string Name { get; set; }
        public int X1 { get; set; }
        public int Y1 { get; set; }

        public Shape()
        {
            Name = "Figura";
            X1 = 0;
            Y1 = 0;
        }

        public Shape(string name, int x1, int y1)
        {
            Name = name;
            X1 = x1;
            Y1 = y1;
        }

        public abstract void Draw(Graphics g);
        public abstract double P();
        public abstract double S();

    }

}
