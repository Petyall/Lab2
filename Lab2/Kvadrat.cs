using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab2
{
    class Kvadrat : Shape
    {
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public int X3 { get; set; }
        public int Y3 { get; set; }
        public int X4 { get; set; }
        public int Y4 { get; set; }
        public double Dlina { get; set; }
        public Kvadrat() : base()
        {
            Dlina = 1;
            X2 = 1;
            Y2 = 1;
            X3 = 1;
            Y3 = 1;
            X4 = 1;
            Y4 = 1;
        }
        public Kvadrat(string name, int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        : base(name, x1, y1)
        {
            Dlina = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            X2 = x2;
            Y2 = y2;
            X3 = x3;
            Y3 = y3;
            X4 = x4;
            Y4 = y4;
        }

        public override void Draw(Graphics g)
        {
            g.DrawPolygon(new Pen(new SolidBrush(Color.Black)),
            new Point[4]
            {
                new Point(X1, Y1),
                new Point(X2, Y2),
                new Point(X4, Y4),
                new Point(X3, Y3),
                
            }
            );
        }

        public override double P()
        {
            return Math.Round(Dlina * 4);
        }

        public override double S()
        {
            return Math.Round(Math.Pow(Dlina, 2));
        }

        public override string ToString()
        {
            return Name + "    S = " + this.S() + "    P = " + this.P() + "    X,Y = "
                + "(" + X1 + ", " + Y1 + ")" + ", (" + X2 + ", " + Y2 + ")"
                + ", (" + X3 + ", " + Y3 + ")" + ", (" + X4 + ", " + Y4 + ")";
            //return "Название и тип фигуры - " + Name + ", площадь - " + this.S() + ", периметр - " + this.P() + ", координаты : "
            //    + "(" + X1 + ", " + Y1 + ")" + ", (" + X2 + ", " + Y2 + ")"
            //    + ", (" + X3 + ", " + Y3 + ")" + ", (" + X4 + ", " + Y4 + ")";
        }
    }

}
