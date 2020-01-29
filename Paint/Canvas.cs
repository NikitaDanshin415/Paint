using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Canvas : Form
    {
        private int oldX, oldY;
        private int startX, startY;
        private Bitmap bmp;
        private Bitmap bmp2;
        private Point start;
        private Image orig;

        public static string path = null;
        public static ImageFormat exp = null;
        public bool isChanged = false;



        //----------------------------------------Конструкторы-----------------------------------------------------------------------
        public Canvas()
        {         
            InitializeComponent();
            bmp = new Bitmap(ClientSize.Width, ClientSize.Height);
            Name = MainForm.windows.Count.ToString();
            pictureBox1.Image = bmp;
        }

        public Canvas(String FileName)
        {
            InitializeComponent();
            
            var f = new FileStream(FileName, FileMode.Open);
            bmp = new Bitmap(f);
            Graphics g = Graphics.FromImage(bmp);
           
            pictureBox1.Image = bmp;
            pictureBox1.Width = bmp.Width;
            pictureBox1.Height = bmp.Height;
            path = FileName;
            f.Close();

        }

        //----------------------------------------События мышки-----------------------------------------------------------------------
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isChanged = true;
            if (MainForm.Brush == "Линия" && e.Button == MouseButtons.Left)
            {
                start = new Point(e.X, e.Y);
                orig = bmp;
            }
            else if (MainForm.Brush == "Круг" && e.Button == MouseButtons.Left)
            {
                startX = e.X;
                startY = e.Y;
                orig = bmp;
            }
            else
            {
                oldX = e.X;
                oldY = e.Y;
            }


        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            var pen = new Pen(MainForm.CurColor, MainForm.CurWidth);
            if (MainForm.Brush == "Кисть" && e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(bmp);
                bmp2 = new Bitmap(bmp);
                pictureBox1.Image = bmp2;
                g.DrawLine(pen, oldX, oldY, e.X, e.Y);
                oldX = e.X;
                oldY = e.Y;
                pictureBox1.Invalidate();
            }
            else if (MainForm.Brush == "Линия" && e.Button == MouseButtons.Left)
            {
                var finish = new Point(e.X, e.Y);
                bmp2 = new Bitmap(bmp);
                pictureBox1.Image = bmp2;
                var g = Graphics.FromImage(bmp2);
                g.DrawLine(pen, start, finish);
                g.Dispose();
                pictureBox1.Invalidate();
            }
            else if (MainForm.Brush == "Круг" && e.Button == MouseButtons.Left)
            {
                var finish = new Point(e.X, e.Y);
                bmp2 = new Bitmap(bmp);
                pictureBox1.Image = bmp2;
                var g = Graphics.FromImage(bmp2);
                g.DrawEllipse(pen, startX, startY, e.X - startX, e.Y - startY);
                oldX = e.X;
                oldY = e.Y;
                g.Dispose();
                pictureBox1.Invalidate();
            }
            else if (MainForm.Brush == "Звезда" && e.Button == MouseButtons.Left)
            {
                bmp2 = new Bitmap(bmp);
                pictureBox1.Image = bmp2;
                var g = Graphics.FromImage(bmp2);

                int n = 5; // число вершин
                double R = (e.X + e.Y) - (oldX + oldY), r = R * 2;   // Внешний и внутренний радиусы
                double alpha = 73;        // поворот
                double x0 = oldX, y0 = oldY; // центр


                PointF[] points = new PointF[2 * n + 1];
                double a = alpha, da = Math.PI / n, l;
                for (int k = 0; k < 2 * n + 1; k++)
                {
                    l = k % 2 == 0 ? r : R;
                    points[k] = new PointF((float)(x0 + l * Math.Cos(a)), (float)(y0 + l * Math.Sin(a)));
                    a += da;
                }

                g.DrawPolygon(pen, points);
                g.Dispose();
                pictureBox1.Invalidate();
            }
            else if (MainForm.Brush == "Ластик" && e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(bmp);
                bmp2 = new Bitmap(bmp);
                pictureBox1.Image = bmp2;
                g.DrawLine(new Pen(Color.White, MainForm.CurWidth), oldX, oldY, e.X, e.Y);
                oldX = e.X;
                oldY = e.Y;
                pictureBox1.Invalidate();
            }
        }
     

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            var pen = new Pen(MainForm.CurColor, MainForm.CurWidth);
            var g = Graphics.FromImage(bmp);
            if (MainForm.Brush == "Линия" && e.Button == MouseButtons.Left)
            {
                var finish = new Point(e.X, e.Y);                
                g.DrawLine(pen, start, finish);
                g.Save();
                g.Dispose();
                pictureBox1.Invalidate();
            }else if (MainForm.Brush == "Круг" && e.Button == MouseButtons.Left)
            {                   
                g.DrawEllipse(pen, startX, startY, e.X - startX, e.Y - startY);
                g.Save();
                g.Dispose();
                pictureBox1.Invalidate();
            }else if (MainForm.Brush == "Звезда" && e.Button == MouseButtons.Left)
            {
                int n = 5;               // число вершин            
                double R = (e.X + e.Y) - (oldX + oldY), r = R * 2;   // Внешний и внутренний радиусы
                double alpha = 73;        // поворот
                double x0 = oldX, y0 = oldY; // центр

                PointF[] points = new PointF[2 * n + 1];
                double a = alpha, da = Math.PI / n, l;
                for (int k = 0; k < 2 * n + 1; k++)
                {
                    l = k % 2 == 0 ? r : R;
                    points[k] = new PointF((float)(x0 + l * Math.Cos(a)), (float)(y0 + l * Math.Sin(a)));
                    a += da;
                }
                g.DrawPolygon(pen, points);
                g.Save();
                g.Dispose();
                pictureBox1.Invalidate();
            }
        }

        //----------------------------------------Высота и ширина picture box-----------------------------------------------------------------------
        public int CanvasWidth
        {
            get
            {
                return pictureBox1.Width;
            }
            set
            {
                pictureBox1.Width = value;
                Bitmap tbmp = new Bitmap(value, pictureBox1.Width);
                Graphics g = Graphics.FromImage(tbmp);
                g.Clear(Color.White);
                g.DrawImage(bmp, new Point(0, 0));
                bmp = tbmp;
                pictureBox1.Image = bmp;
            }
        }
        public int CanvasHeight
        {
            get
            {
                return pictureBox1.Height;
            }
            set
            {
                pictureBox1.Height = value;
                Bitmap tbmp = new Bitmap(pictureBox1.Width, value);
                Graphics g = Graphics.FromImage(tbmp);
                g.Clear(Color.White);
                g.DrawImage(bmp, new Point(0, 0));
                bmp = tbmp;
                pictureBox1.Image = bmp;
            }
        }

        //----------------------------------------Функции сохранения-----------------------------------------------------------------------
        public void SaveAs()
        {
            if (isChanged)
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.AddExtension = true;
                dlg.Title = "Сохранить в файл...";
                dlg.OverwritePrompt = true;
                dlg.CheckPathExists = true;
                dlg.ShowHelp = true;
                dlg.Filter = "Windows Bitmap (*.bmp)|*.bmp| Файлы JPEG (*.jpg)|*.jpg";
                ImageFormat[] ff = { ImageFormat.Bmp, ImageFormat.Jpeg };

                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox1.Image.Save(dlg.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void Save()
        {
            if (isChanged)
            {
                if (path == null)
                {
                    this.SaveAs();
                }
                else
                {
                    pictureBox1.Image.Save(path);
                }
            }        
        }
        //----------------------------------------Зум-----------------------------------------------------------------------
        public void ZoomIn()
        {
            Size newSize = new Size(bmp.Width * 2, bmp.Height * 2);
            bmp = new Bitmap(bmp, newSize);
            pictureBox1.Image = bmp;
        }

        public void ZoomOut()
        {
            Size newSize = new Size(bmp.Width / 2, bmp.Height / 2);
            bmp = new Bitmap(bmp, newSize);
            pictureBox1.Image = bmp;
        }


    }


}
