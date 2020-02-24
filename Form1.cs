﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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

        private Graphics g,gimg;
        bool created = false, paint = false;
        private enum Item { Pen,Brush }
        private Item PickedItem;
        private Size sz;

        private enum Figure { Line,Rectangle}
        private Figure PickedFigure;

        private Point startPoint,currentPoint;
        private Pen p = new Pen(Color.Black, 3);
        private Brush b = new SolidBrush(Color.Aquamarine);

        private Image img = null;
        private BufferedGraphicsContext bgc =BufferedGraphicsManager.Current;
        private BufferedGraphics bg;

        private void panelMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (created)
            {
                paint = true;
                startPoint = new Point(e.X, e.Y);
            }
            else
            {
                g = panelMain.CreateGraphics();
                paint = true;
                created = true;
                PickedItem = Item.Pen;
                PickedFigure = Figure.Line;
                startPoint = new Point(e.X, e.Y);
            }
        }
        private void panelMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (img == null) return;
            var bgg = bg.Graphics;
            if (paint)
            {
                currentPoint = new Point(e.X, e.Y);
                switch (PickedFigure)
                {
                    case Figure.Line:
                        gimg.DrawLine(p, startPoint, currentPoint);
                        g.DrawLine(p, startPoint, currentPoint);
                        startPoint = currentPoint;
                        break;
                    case Figure.Rectangle:
                        sz = new Size(currentPoint.X - startPoint.X,currentPoint.Y - startPoint.Y);
                        if (p.Color == (pictureEraser).BackColor) p.Color = Color.Black;
                        bgg.DrawImage(img, 0, 0);
                        bgg.DrawRectangle(p, new Rectangle(startPoint, sz));
                        bg.Render();
                        break;
                    default:
                        break;
                }
            }
        }
        private void panelMain_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            sz = new Size(currentPoint.X - startPoint.X, currentPoint.Y - startPoint.Y);
            switch (PickedFigure)
            {
                case Figure.Rectangle:
                    gimg.DrawRectangle(p, new Rectangle(startPoint, sz));
                    g.DrawRectangle(p, new Rectangle(startPoint, sz));
                    //можно добавить заливку в g и gimg кисточкой
                    break;
                default:
                    break;
            }
        }

        private void ChangeColor(object sender,EventArgs e)
        {
            p.Color = ((Panel)sender).BackColor;
        }
        private void ChangeFigure(object sender,EventArgs e)
        {
            switch (((PictureBox)sender).Name)
            {
                case "pictureBoxRectangle":
                    PickedFigure = Figure.Rectangle;
                    break;
                case "pictureBoxLine":
                    PickedFigure=Figure.Line;
                    break;
            }
        }
        private void ChangeItem(object sender,EventArgs e)
        {
            switch (((PictureBox)sender).Name)
            {
                case "picturePen":
                    PickedFigure = Figure.Line;
                    PickedItem = Item.Pen;
                    p.Color = Color.Black;
                    break;
                case "pictureEraser":
                    PickedFigure = Figure.Line;
                    PickedItem = Item.Pen;
                    p.Color = ((PictureBox)sender).BackColor;
                    break;
                case "pictureBrush":
                    //PickedFigure = Figure.Line;
                    break;
            }
        }
        private void comboBoxPtt_SelectedIndexChanged(object sender, EventArgs e)
        {
            p.Width = comboBoxPtt.SelectedIndex;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            img.Save("picture.jpg", ImageFormat.Jpeg);
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            if (img == null)
            {
                img = new Bitmap(panelMain.Width, panelMain.Height, panelMain.CreateGraphics());
                gimg = Graphics.FromImage(img);
                gimg.Clear(pictureEraser.BackColor);
                bg = bgc.Allocate(panelMain.CreateGraphics(), new Rectangle(0, 0, panelMain.Width, panelMain.Height));
            }
            e.Graphics.DrawImage(img, 0, 0);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            panelMain.Refresh();
            gimg.Clear(panelMain.BackColor);
            g.Clear(panelMain.BackColor);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
