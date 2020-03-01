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

        private enum Item { Pen }
        private Item PickedItem=Item.Pen;

        private Size sz;

        private enum Figure { Line,Rectangle,Ellipse}
        private Figure PickedFigure;

        private Point startPoint,currentPoint;
        private Pen pen1 = new Pen(Color.Black, 3);
        private Brush b = new SolidBrush(SystemColors.Control);

        private Image img = null;
        private Image img2 = null;
        private BufferedGraphicsContext bgc =BufferedGraphicsManager.Current;
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
                g = panelMain.CreateGraphics();
                paint = true;
                created = true;
                if(PickedFigure!=Figure.Ellipse && PickedFigure != Figure.Rectangle)
                {
                    PickedFigure = Figure.Line;
                }
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
                        gimg.DrawLine(pen1, startPoint, currentPoint);
                        g.DrawLine(pen1, startPoint, currentPoint);
                        startPoint = currentPoint;
                        break;
                    case Figure.Rectangle:
                        
                        //if (pen1.Color == (pictureEraser).BackColor) pen1.Color = Color.Black;
                        bgg.DrawImage(img, 0, 0);
                        if(startPoint.X>currentPoint.X && startPoint.Y > currentPoint.Y)
                        {
                            bgg.DrawRectangle(pen1, new Rectangle(currentPoint, new Size(startPoint.X-currentPoint.X,startPoint.Y-currentPoint.Y)));
                        }
                        else if(startPoint.X>currentPoint.X && startPoint.Y < currentPoint.Y)
                        {
                            bgg.DrawRectangle(pen1,new Rectangle(currentPoint.X,startPoint.Y,startPoint.X-currentPoint.X,currentPoint.Y-startPoint.Y));
                        }
                        else if(startPoint.X<currentPoint.X && startPoint.Y < currentPoint.Y)
                        {
                            bgg.DrawRectangle(pen1, new Rectangle(startPoint.X, startPoint.Y, currentPoint.X - startPoint.X, currentPoint.Y - startPoint.Y));
                        }else
                        {
                            bgg.DrawRectangle(pen1, new Rectangle(startPoint.X, currentPoint.Y, currentPoint.X - startPoint.X, startPoint.Y - currentPoint.Y));
                        }
                        //bgg.DrawRectangle(pen1, new Rectangle(startPoint, sz));
                        bg.Render();
                        break;
                    case Figure.Ellipse:
                        sz = new Size(currentPoint.X - startPoint.X, currentPoint.Y - startPoint.Y);
                        bgg.DrawImage(img, 0, 0);
                        bgg.DrawEllipse(pen1, new Rectangle(startPoint, sz));
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
                    if(panelCol2.BackColor != SystemColors.Control)
                    {
                        gimg.FillRectangle(b, new Rectangle(startPoint, sz));
                        g.FillRectangle(b, new Rectangle(startPoint, sz));
                    }
                    if (startPoint.X > currentPoint.X && startPoint.Y > currentPoint.Y)
                    {
                        gimg.DrawRectangle(pen1, new Rectangle(currentPoint, new Size(startPoint.X - currentPoint.X, startPoint.Y - currentPoint.Y)));
                        g.DrawRectangle(pen1, new Rectangle(currentPoint, new Size(startPoint.X - currentPoint.X, startPoint.Y - currentPoint.Y)));
                        if (panelCol2.BackColor != SystemColors.Control)
                        {
                            gimg.FillRectangle(b, new Rectangle(currentPoint, new Size(startPoint.X - currentPoint.X, startPoint.Y - currentPoint.Y)));
                            g.FillRectangle(b, new Rectangle(currentPoint, new Size(startPoint.X - currentPoint.X, startPoint.Y - currentPoint.Y)));
                        }
                    }
                    else if (startPoint.X > currentPoint.X && startPoint.Y < currentPoint.Y)
                    {
                        gimg.DrawRectangle(pen1, new Rectangle(currentPoint.X, startPoint.Y, startPoint.X - currentPoint.X, currentPoint.Y - startPoint.Y));
                        g.DrawRectangle(pen1, new Rectangle(currentPoint.X, startPoint.Y, startPoint.X - currentPoint.X, currentPoint.Y - startPoint.Y));
                        if (panelCol2.BackColor != SystemColors.Control)
                        {
                            gimg.FillRectangle(b, new Rectangle(currentPoint.X, startPoint.Y, startPoint.X - currentPoint.X, currentPoint.Y - startPoint.Y));
                            g.FillRectangle(b, new Rectangle(currentPoint.X, startPoint.Y, startPoint.X - currentPoint.X, currentPoint.Y - startPoint.Y));
                        }
                    }
                    else if (startPoint.X < currentPoint.X && startPoint.Y < currentPoint.Y)
                    {
                        gimg.DrawRectangle(pen1, new Rectangle(startPoint.X, startPoint.Y, currentPoint.X - startPoint.X, currentPoint.Y - startPoint.Y));
                        g.DrawRectangle(pen1, new Rectangle(startPoint.X, startPoint.Y, currentPoint.X - startPoint.X, currentPoint.Y - startPoint.Y));
                        if (panelCol2.BackColor != SystemColors.Control)
                        {
                            gimg.FillRectangle(b, new Rectangle(startPoint.X, startPoint.Y, currentPoint.X - startPoint.X, currentPoint.Y - startPoint.Y));
                            g.FillRectangle(b, new Rectangle(startPoint.X, startPoint.Y, currentPoint.X - startPoint.X, currentPoint.Y - startPoint.Y));
                        }
                    }
                    else
                    {
                        gimg.DrawRectangle(pen1, new Rectangle(startPoint.X, currentPoint.Y, currentPoint.X - startPoint.X, startPoint.Y - currentPoint.Y));
                        g.DrawRectangle(pen1, new Rectangle(startPoint.X, currentPoint.Y, currentPoint.X - startPoint.X, startPoint.Y - currentPoint.Y));
                        if (panelCol2.BackColor != SystemColors.Control)
                        {
                            gimg.FillRectangle(b, new Rectangle(startPoint.X, currentPoint.Y, currentPoint.X - startPoint.X, startPoint.Y - currentPoint.Y));
                            g.FillRectangle(b, new Rectangle(startPoint.X, currentPoint.Y, currentPoint.X - startPoint.X, startPoint.Y - currentPoint.Y));
                        }
                    }
                    break;
                case Figure.Ellipse:
                    if(panelCol2.BackColor != SystemColors.Control)
                    {
                        gimg.FillEllipse(b, new Rectangle(startPoint, sz));
                        g.FillEllipse(b, new Rectangle(startPoint, sz));
                    }
                    gimg.DrawEllipse(pen1, new Rectangle(startPoint, sz));
                    g.DrawEllipse(pen1, new Rectangle(startPoint, sz));
                    break;
                default:
                    break;
            }
        }

        private void ChangeColor(object sender,MouseEventArgs e)
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
        private void ChangeFigure(object sender,EventArgs e)
        {
            switch (((PictureBox)sender).Name)
            {
                case "pictureBoxRectangle":
                    PickedFigure = Figure.Rectangle;
                    pictureBoxRectangle.BorderStyle = BorderStyle.Fixed3D;
                    pictureBoxLine.BorderStyle = BorderStyle.None;
                    pictureBoxEllipse.BorderStyle = BorderStyle.None;
                    break;
                case "pictureBoxLine":
                    PickedFigure=Figure.Line;
                    pictureBoxRectangle.BorderStyle = BorderStyle.None;
                    pictureBoxLine.BorderStyle = BorderStyle.Fixed3D;
                    pictureBoxEllipse.BorderStyle = BorderStyle.None;
                    break;
                case "pictureBoxEllipse":
                    PickedFigure = Figure.Ellipse;
                    pictureBoxRectangle.BorderStyle = BorderStyle.None;
                    pictureBoxLine.BorderStyle = BorderStyle.None;
                    pictureBoxEllipse.BorderStyle = BorderStyle.Fixed3D;
                    break;
                default:
                    break;
            }
        }
        private void ChangeItem(object sender,EventArgs e)
        {
            switch (((PictureBox)sender).Name)
            {
                case "picturePen":
                    if(pen1.Color == SystemColors.Control)
                    {
                        pen1.Color = Color.Black;
                        panelCol1.BackColor = Color.Black;
                    }
                    pictureEraser.BorderStyle = BorderStyle.None;
                    picturePen.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case "pictureEraser":
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
            if (img !=null && PanelWidth>0 && PanelHeight>0)
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
                img2 = new Bitmap(PanelWidth, PanelHeight, g);
                gimg = Graphics.FromImage(img2);
                gimg.Clear(SystemColors.Control);
                gimg.DrawImage(img, 0, 0);
                img = img2;
                bg = bgc.Allocate(panelMain.CreateGraphics(), new Rectangle(0, 0, PanelWidth, PanelHeight));
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            var res=openFileDialog1.ShowDialog();
            //openFileDialog1.Filter = "JPG files (*.jpg)|*.png|PNG files (*.png*)|*.png*";
            //openFileDialog1.FilterIndex = 2;
            //openFileDialog1.RestoreDirectory = true;
            if (res == DialogResult.OK)
            {
                //запустить панельку с выбором подгона изображения по панели или его обрезание
                img2 = new Bitmap(Image.FromFile(openFileDialog1.FileName));

                gimg.DrawImage(img2,0,0);
                if(g != null)
                {
                    g.DrawImage(img2, 0, 0);
                }
                else
                {
                    g=panelMain.CreateGraphics();
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
            e.Graphics.DrawImage(img, new Rectangle(0,0, PanelWidth, PanelHeight));
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
