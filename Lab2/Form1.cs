using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
        Graphics g;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();

            List<Shape> list = new List<Shape>()
            {
                new Kvadrat("Квадрат", 10, 20, 100),
                new ColorKvadrat("Квадрат с заданным цветом заливки", 30, 40, 100, Color.Red),
                new Kvadrat4("Квадрат задается координатами всех четырех вершин", 500, 600, 100, 100),
            };

            list.ForEach(a => a.Draw(g));

        }
    }
}
