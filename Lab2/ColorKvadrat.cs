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

        public ColorKvadrat(string name, int x, int y, int dlina, Color color)
        : base(name, x, y, dlina)
        {
            Color = color;
        }

        public override void Draw(Graphics g)
        {
            g.DrawPolygon(new Pen(new SolidBrush(Color)),
            new Point[4] {
            new Point(X, Y),
            new Point(X + Dlina, Y),
            new Point(X + Dlina, Y + Dlina),
            new Point(X, Y + Dlina)
            }
            );
        }
    }

}
