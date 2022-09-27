using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Lab2
{
    class ColorKvadrat : Kvadrat
    {
        public Color Color { get; set; }
        public ColorKvadrat() : base()
        {
            Color = Color.Blue;
        }

        public ColorKvadrat(string name, int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4, Color color)
        : base(name, x1, y1, x2, y2, x3, y3, x4, y4)
        {
            Color = color;
        }

        public override string ToString()
        {
            return Name + ", S = " + this.S() + ", P - " + this.P() + ", X,Y = "
                + "(" + X1 + ", " + Y1 + ")" + ", (" + X2 + ", " + Y2 + ")"
                + ", (" + X3 + ", " + Y3 + ")" + ", (" + X4 + ", " + Y4 + ")";
        }

        public override void Draw(Graphics g)
        {
            g.FillPolygon(new SolidBrush(Color),
            new Point[4] 
            {
                new Point(X1, Y1),
                new Point(X2, Y2),
                new Point(X4, Y4),
                new Point(X3, Y3),
            }
            );
        }
    }

}
