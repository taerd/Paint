using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Graphics g, gimg;
        bool created = false, paint = false;

        private enum Item { Pen, Eraser }
        private Item PickedItem = Item.Pen;

        private enum Figure { Line, Rectangle, Ellipse, Star, Arrow }
        private Figure PickedFigure;

        private Point startPoint, currentPoint;
        private Pen pen1 = new Pen(Color.Black, 3);
        private Brush b = new SolidBrush(SystemColors.Control);

        private Image img = null;
        private Image img2 = null;
        private BufferedGraphicsContext bgc = BufferedGraphicsManager.Current;
        private BufferedGraphics bg;

        private int PanelWidth;
        private int PanelHeight;

        private void panelMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (created)
            {
                paint = true;
                startPoint = new Point(e.X, e.Y);
            }
            else
            {
                paint = true;
                created = true;
                if (PickedFigure != Figure.Ellipse && PickedFigure != Figure.Rectangle && PickedFigure != Figure.Star && PickedFigure != Figure.Arrow)
                {
                    PickedFigure = Figure.Line;
                }
                startPoint = new Point(e.X, e.Y);
            }
        }
        private void panelMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (img == null) return;
            if (paint)
            {
                var bgg = bg.Graphics;
                currentPoint = new Point(e.X, e.Y);
                if (PickedFigure == Figure.Line)
                {
                    gimg.DrawLine(pen1, startPoint, currentPoint);
                    g.DrawLine(pen1, startPoint, currentPoint);
                    startPoint = currentPoint;
                }
                else
                {
                    bgg.DrawImage(img, 0, 0);
                    DrawOrFillFigure(PickedFigure, startPoint, currentPoint, bgg, false);
                    bg.Render();
                }
            }
        }
        private void panelMain_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            DrawOrFillFigure(PickedFigure, startPoint, currentPoint, gimg, !(panelCol2.BackColor == SystemColors.Control));
            g.DrawImage(img, 0, 0);
        }

        private void ChangeColor(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pen1.Color = ((Panel)sender).BackColor;
                panelCol1.BackColor = pen1.Color;
                picturePen.BorderStyle = BorderStyle.Fixed3D;
                pictureEraser.BorderStyle = BorderStyle.None;
            }
            else if (e.Button == MouseButtons.Right)
            {
                b = new SolidBrush(((Panel)sender).BackColor);
                panelCol2.BackColor = ((Panel)sender).BackColor;
            }
        }
        private void ChangeFigure(object sender, EventArgs e)
        {
            switch (((PictureBox)sender).Name)
            {
                case "pictureBoxRectangle":
                    PickedFigure = Figure.Rectangle;
                    pictureBoxRectangle.BorderStyle = BorderStyle.Fixed3D;
                    pictureBoxLine.BorderStyle = BorderStyle.None;
                    pictureBoxEllipse.BorderStyle = BorderStyle.None;
                    pictureBoxArrow.BorderStyle = BorderStyle.None;
                    pictureBoxStar.BorderStyle = BorderStyle.None;
                    break;
                case "pictureBoxLine":
                    PickedFigure = Figure.Line;
                    pictureBoxRectangle.BorderStyle = BorderStyle.None;
                    pictureBoxLine.BorderStyle = BorderStyle.Fixed3D;
                    pictureBoxEllipse.BorderStyle = BorderStyle.None;
                    pictureBoxArrow.BorderStyle = BorderStyle.None;
                    pictureBoxStar.BorderStyle = BorderStyle.None;
                    break;
                case "pictureBoxEllipse":
                    PickedFigure = Figure.Ellipse;
                    pictureBoxRectangle.BorderStyle = BorderStyle.None;
                    pictureBoxLine.BorderStyle = BorderStyle.None;
                    pictureBoxEllipse.BorderStyle = BorderStyle.Fixed3D;
                    pictureBoxArrow.BorderStyle = BorderStyle.None;
                    pictureBoxStar.BorderStyle = BorderStyle.None;
                    break;
                case "pictureBoxStar":
                    PickedFigure = Figure.Star;
                    pictureBoxRectangle.BorderStyle = BorderStyle.None;
                    pictureBoxLine.BorderStyle = BorderStyle.None;
                    pictureBoxEllipse.BorderStyle = BorderStyle.None;
                    pictureBoxStar.BorderStyle = BorderStyle.Fixed3D;
                    pictureBoxArrow.BorderStyle = BorderStyle.None;
                    break;
                case "pictureBoxArrow":
                    PickedFigure = Figure.Arrow;
                    pictureBoxRectangle.BorderStyle = BorderStyle.None;
                    pictureBoxLine.BorderStyle = BorderStyle.None;
                    pictureBoxEllipse.BorderStyle = BorderStyle.None;
                    pictureBoxStar.BorderStyle = BorderStyle.None;
                    pictureBoxArrow.BorderStyle = BorderStyle.Fixed3D;
                    break;
                default:
                    break;
            }
        }
        private void ChangeItem(object sender, EventArgs e)
        {
            switch (((PictureBox)sender).Name)
            {
                case "picturePen":
                    if (pen1.Color == SystemColors.Control)
                    {
                        pen1.Color = Color.Black;
                        panelCol1.BackColor = Color.Black;
                    }
                    pictureEraser.BorderStyle = BorderStyle.None;
                    picturePen.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case "pictureEraser":
                    PickedItem = Item.Eraser;
                    pen1.Color = SystemColors.Control;
                    pictureEraser.BorderStyle = BorderStyle.Fixed3D;
                    picturePen.BorderStyle = BorderStyle.None;
                    break;
                default:
                    break;
            }
        }
        private void comboBoxPtt_SelectedIndexChanged(object sender, EventArgs e)
        {
            pen1.Width = comboBoxPtt.SelectedIndex;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //img.Save("picture.jpg", ImageFormat.Jpeg);
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.Filter = "Фаил картинки в формате JPG|*.jpg  |Фаил картинки в формате PNG|*.png";
            var res = saveFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                img.Save($"{saveFileDialog1.FileName}", ImageFormat.Jpeg);
            }
        }

        private void panelMain_Resize(object sender, EventArgs e)
        {
            PanelWidth = panelMain.Width;
            PanelHeight = panelMain.Height;
            if (img != null && PanelWidth > 0 && PanelHeight > 0)
            {
                //с сужением изображения(не совсем хорошее)
                /*
                gimg.Dispose();
                img2 = new Bitmap(img, PanelWidth, PanelHeight);
                gimg = Graphics.FromImage(img2);
                img = img2;
                g = panelMain.CreateGraphics();
                g.DrawImage(img, new Rectangle(0, 0, PanelWidth, PanelHeight));
                bg = bgc.Allocate(panelMain.CreateGraphics(), new Rectangle(0, 0, PanelWidth, PanelHeight));
                */
                //обрезание изображения
                g = panelMain.CreateGraphics();
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                img2 = new Bitmap(PanelWidth, PanelHeight, g);
                gimg = Graphics.FromImage(img2);
                gimg.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                gimg.Clear(SystemColors.Control);
                gimg.DrawImage(img, 0, 0);
                img = img2;
                bg = bgc.Allocate(panelMain.CreateGraphics(), new Rectangle(0, 0, PanelWidth, PanelHeight));
            }
        }
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            var res = openFileDialog1.ShowDialog();
            //openFileDialog1.Filter = "JPG files (*.jpg)|*.png|PNG files (*.png*)|*.png*";
            //openFileDialog1.FilterIndex = 2;
            //openFileDialog1.RestoreDirectory = true;
            if (res == DialogResult.OK)
            {
                /*
                bool action = false;
                Form2 frm2 = new Form2(this);
                frm2.Show();
                this.Hide();
                while (!action)
                {
                    //Thread.Sleep(1000);
                    action = frm2.act;
                }
                switch (frm2.res)
                {
                    case 1:
                        //запустить панельку с выбором подгона изображения по панели или его обрезание
                        img2 = new Bitmap(Image.FromFile(openFileDialog1.FileName));

                        gimg.DrawImage(img2, 0, 0);
                        if (g != null)
                        {
                            g.DrawImage(img2, 0, 0);
                        }
                        else
                        {
                            g = panelMain.CreateGraphics();
                            g.DrawImage(img2, 0, 0);
                        }
                        break;
                    case 2:
                        //с сужением изображения(не совсем хорошее)
                        gimg.Dispose();
                        img2 = new Bitmap(Image.FromFile(openFileDialog1.FileName));
                        gimg = Graphics.FromImage(img2);
                        gimg.DrawImage(img2, 0, 0);
                        if (g != null)
                        {
                            g.DrawImage(img2,0,0);
                        }
                        else
                        {
                            g = panelMain.CreateGraphics();
                            g.DrawImage(img2, 0, 0);
                        }
                        bg = bgc.Allocate(panelMain.CreateGraphics(), new Rectangle(0, 0, PanelWidth, PanelHeight));
                        break;
                    default:
                        break;
                }      */
                img2 = new Bitmap(Image.FromFile(openFileDialog1.FileName));

                gimg.DrawImage(img2, 0, 0);
                if (g != null)
                {
                    g.DrawImage(img2, 0, 0);
                }
                else
                {
                    g = panelMain.CreateGraphics();
                    g.DrawImage(img2, 0, 0);
                }
            }
        }
        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            if (img == null)
            {
                img = new Bitmap(PanelWidth, PanelHeight, panelMain.CreateGraphics());
                gimg = Graphics.FromImage(img);
                gimg.Clear(SystemColors.Control);
                bg = bgc.Allocate(panelMain.CreateGraphics(), new Rectangle(0, 0, PanelWidth, PanelHeight));
            }
            e.Graphics.DrawImage(img, new Rectangle(0, 0, PanelWidth, PanelHeight));
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (created)
            {
                panelMain.Refresh();
                gimg.Clear(SystemColors.Control);
                g.Clear(SystemColors.Control);
            }
        }
        private void DrawOrFillFigure(Figure figure, Point startPoint, Point endPoint, Graphics gimg, bool fill)
        {
            if (pen1.Color == SystemColors.Control && PickedItem != Item.Eraser)
            {
                pen1.Color = Color.Black;
                panelCol1.BackColor = Color.Black;
            }
            switch (figure)
            {
                case (Figure.Line):
                    gimg.DrawLine(pen1, startPoint, endPoint);
                    break;
                case (Figure.Rectangle):
                    if (startPoint.X > currentPoint.X && startPoint.Y > currentPoint.Y)
                    {
                        gimg.DrawRectangle(pen1, new Rectangle(currentPoint, new Size(startPoint.X - currentPoint.X, startPoint.Y - currentPoint.Y)));
                        if (fill)
                        {
                            gimg.FillRectangle(b, new Rectangle(currentPoint, new Size(startPoint.X - currentPoint.X, startPoint.Y - currentPoint.Y)));
                        }
                    }
                    else if (startPoint.X > currentPoint.X && startPoint.Y < currentPoint.Y)
                    {
                        gimg.DrawRectangle(pen1, new Rectangle(currentPoint.X, startPoint.Y, startPoint.X - currentPoint.X, currentPoint.Y - startPoint.Y));
                        if (fill)
                        {
                            gimg.FillRectangle(b, new Rectangle(currentPoint.X, startPoint.Y, startPoint.X - currentPoint.X, currentPoint.Y - startPoint.Y));
                        }
                    }
                    else if (startPoint.X < currentPoint.X && startPoint.Y < currentPoint.Y)
                    {
                        gimg.DrawRectangle(pen1, new Rectangle(startPoint.X, startPoint.Y, currentPoint.X - startPoint.X, currentPoint.Y - startPoint.Y));
                        if (fill)
                        {
                            gimg.FillRectangle(b, new Rectangle(startPoint.X, startPoint.Y, currentPoint.X - startPoint.X, currentPoint.Y - startPoint.Y));
                        }
                    }
                    else
                    {
                        gimg.DrawRectangle(pen1, new Rectangle(startPoint.X, currentPoint.Y, currentPoint.X - startPoint.X, startPoint.Y - currentPoint.Y));
                        if (fill)
                        {
                            gimg.FillRectangle(b, new Rectangle(startPoint.X, currentPoint.Y, currentPoint.X - startPoint.X, startPoint.Y - currentPoint.Y));
                        }
                    }
                    break;
                case (Figure.Ellipse):
                    if (fill)
                    {
                        gimg.FillEllipse(b, new Rectangle(startPoint.X, startPoint.Y, currentPoint.X - startPoint.X, currentPoint.Y - startPoint.Y));
                    }
                    gimg.DrawEllipse(pen1, new Rectangle(startPoint.X, startPoint.Y, currentPoint.X - startPoint.X, currentPoint.Y - startPoint.Y));
                    break;
                case (Figure.Star):
                    Rectangle area;
                    Point[] points;
                    if (startPoint.X > currentPoint.X && startPoint.Y > currentPoint.Y)
                    {
                        area = new Rectangle(currentPoint, new Size(startPoint.X - currentPoint.X, startPoint.Y - currentPoint.Y));
                    }
                    else if (startPoint.X > currentPoint.X && startPoint.Y < currentPoint.Y)
                    {
                        area = new Rectangle(currentPoint.X, startPoint.Y, startPoint.X - currentPoint.X, currentPoint.Y - startPoint.Y);
                    }
                    else if (startPoint.X < currentPoint.X && startPoint.Y < currentPoint.Y)
                    {
                        area = new Rectangle(startPoint.X, startPoint.Y, currentPoint.X - startPoint.X, currentPoint.Y - startPoint.Y);
                    }
                    else
                    {
                        area = new Rectangle(startPoint.X, currentPoint.Y, currentPoint.X - startPoint.X, startPoint.Y - currentPoint.Y);
                    }
                    points = CreatePolPoints(7, area);
                    if (fill)
                    {
                        gimg.FillPolygon(b, points);
                    }
                    gimg.DrawPolygon(pen1, points);
                    break;
                case (Figure.Arrow):
                    Rectangle area1;
                    Point[] points1;
                    if (startPoint.X > currentPoint.X && startPoint.Y > currentPoint.Y)
                    {
                        area1 = new Rectangle(currentPoint, new Size(startPoint.X - currentPoint.X, startPoint.Y - currentPoint.Y));
                    }
                    else if (startPoint.X > currentPoint.X && startPoint.Y < currentPoint.Y)
                    {
                        area1 = new Rectangle(currentPoint.X, startPoint.Y, startPoint.X - currentPoint.X, currentPoint.Y - startPoint.Y);
                    }
                    else if (startPoint.X < currentPoint.X && startPoint.Y < currentPoint.Y)
                    {
                        area1 = new Rectangle(startPoint.X, startPoint.Y, currentPoint.X - startPoint.X, currentPoint.Y - startPoint.Y);
                    }
                    else
                    {
                        area1 = new Rectangle(startPoint.X, currentPoint.Y, currentPoint.X - startPoint.X, startPoint.Y - currentPoint.Y);
                    }

                    points1 = CreateArrPoints(area1);

                    if (fill)
                    {
                        gimg.FillPolygon(b, points1);
                    }
                    gimg.DrawPolygon(pen1, points1);
                    break;
                default:
                    break;
            }
        }

        private Point[] CreatePolPoints(int numb,Rectangle area)
        {
            Point[] pts = new Point[numb];
            int cX = area.Width / 2;
            int cY = area.Height / 2;

            int centerX = area.X + cX;
            int centerY = area.Y + cY;

            double theta = -Math.PI / 2;
            double dtheta = 4 * Math.PI / numb;//шаг в градусах между вершинами

            for(int i = 0; i < numb; i++)
            {
                pts[i] = new Point((int)(centerX + cX * Math.Cos(theta)), (int)(centerY + cY * Math.Sin(theta)));
                theta += dtheta;
            }
            return pts;

        }
        private Point[] CreateArrPoints(Rectangle area)
        {
                Point point1 = new Point(area.X, area.Y+area.Height/2);
                Point point2 = new Point((int)(area.X + area.Width * 0.65), (int)(area.Y + area.Height * 0.35));
                Point point3 = new Point((int)(area.X + area.Width * 0.6), (int)(area.Y + area.Height * 0.15));
                Point point4 = new Point((int)(area.X + area.Width * 0.9), (int)(area.Y + area.Height * 0.5));
                Point point5 = new Point((int)(area.X + area.Width * 0.6), (int)(area.Y + area.Height * 0.85));
                Point point6 = new Point((int)(area.X + area.Width * 0.65), (int)(area.Y + area.Height * 0.65));
            Point[] pts = { point1, point2, point3, point4, point5, point6 };
            return pts;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            g = panelMain.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen1.EndCap = pen1.StartCap = System.Drawing.Drawing2D.LineCap.Round;
        }
    }
}
