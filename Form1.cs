using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        bool created = false, paint = false;
        int lastX, lastY;
        Pen p = new Pen(Color.Black, 3);
        Brush b;

        private void panelMain_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }

        private void panelMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                g.DrawLine(p,lastX, lastY, e.X, e.Y);
                lastX = e.X;
                lastY = e.Y;
            }
        }

        private void panelBlack_Click(object sender, EventArgs e)
        {
            p.Color = Color.Black;
        }

        private void panelRed_Click(object sender, EventArgs e)
        {
            p.Color = Color.Red;
        }

        private void pictureEraser_Click(object sender, EventArgs e)
        {
            p.Color = panelMain.BackColor;
        }

        private void picturePen_Click(object sender, EventArgs e)
        {
            p.Color = Color.Black;
        }

        private void comboBoxPtt_SelectedIndexChanged(object sender, EventArgs e)
        {
            p.Width = comboBoxPtt.SelectedIndex;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            panelMain.Refresh();
        }

        private void panelBlue_Click(object sender, EventArgs e)
        {
            p.Color = Color.Blue;
        }


        private void panelMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (created)
            {
                paint = true;
                lastX = e.X;
                lastY = e.Y;
            }
            else
            {
                g = panelMain.CreateGraphics();
                paint = true;
                created = true;
                lastX = e.X;
                lastY = e.Y;
            }
        }
    }
}
