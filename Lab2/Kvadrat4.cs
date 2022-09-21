using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab2
{
    internal class Kvadrat4: Shape
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public Kvadrat4() : base()
        {
            X1 = 1;
            Y1 = 1;
        }
        public Kvadrat4(string name, int x, int y, int x1, int y1)
        : base(name, x, y)
        {
            X1 = x1;
            Y1 = y1;
        }

        public override void Draw(Graphics g)
        {
            g.DrawPolygon(new Pen(new SolidBrush(Color.Black)),
            new Point[4]
            {
                new Point(X, Y),
                new Point(X1, Y),
                new Point(X1, Y1),
                new Point(X, Y1)
            }
            );
        }
        public override float P()
        {
            return X + X1 + Y1 + Y;
        }

        public override float S()
        {
            return X * Y;
        }
    }
}

