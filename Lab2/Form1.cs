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
            int k = 0;
            string p;
            foreach (var i in list)
            {
                dataGridView1.Rows.Add(new DataGridViewRow());
                p = i.P().ToString();
                dataGridView1.Rows[k].Cells[1].Value = p;
                p = i.S().ToString();
                dataGridView1.Rows[k].Cells[0].Value = p;
                p = i.ToString();
                dataGridView1.Rows[k].Cells[2].Value = p;
                k++;
            }
        }

        Graphics g;
        List<Shape> list = new List<Shape>()
            {
                new Kvadrat("Обычный квадрат", 20, 20, 60, 20, 20, 60, 60, 60),
                new Kvadrat("Наклоненный квадрат", 80, 40, 110, 10, 110,  70, 140, 40),
                new ColorKvadrat("Цветной квадрат", 20, 90, 60, 90, 20, 130, 60, 130, Color.DarkViolet),
                new ColorKvadrat("Наклоненный цветной квадрат", 80, 110, 110, 80, 110,  140, 140, 110, Color.DarkViolet),
            };

        private void button1_Click(object sender, EventArgs e)
        {
            g = CreateGraphics();
            list.ForEach(a => a.Draw(g));
        }

        private void True(object sender, DataGridViewAutoSizeModeEventArgs e)
        {

        }

    }
}
