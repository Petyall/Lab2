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
        public int X { get; set; }
        public int Y { get; set; }

        public Shape()
        {
            Name = "Figura";
            X = 0;
            Y = 0;
        }

        public Shape(string name, int x, int y)
        {
            Name = name;
            X = x;
            Y = y;
        }

        public abstract void Draw(Graphics g);
        public abstract float P();
        public abstract float S();

    }




}
