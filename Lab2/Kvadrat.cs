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
        public int Dlina { get; set; }
        public Kvadrat() : base()
        {
            Dlina = 1;
        }
        public Kvadrat(string name, int x, int y, int dlina)
        : base(name, x, y)
        {
            Dlina = dlina;
        }

        public override void Draw(Graphics g)
        {
            g.DrawPolygon(new Pen(new SolidBrush(Color.Black)),
            new Point[4]
            {
                new Point(X, Y),
                new Point(X+Dlina, Y),
                new Point(X+Dlina, Y+Dlina),
                new Point(X, Y+Dlina)
            }
            );
        }
        public override float P()
        {
            return Dlina * 4;
        }

        public override float S()
        {
            return Dlina * Dlina;
        }
    }

}
