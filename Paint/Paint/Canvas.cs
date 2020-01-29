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
    public partial class Canvas : Form
    {
        private int oldX, oldY;
        private Bitmap bmp;
        public static string path = null;
        public static ImageFormat exp = null;

        public Canvas()
        {
            InitializeComponent();
            bmp = new Bitmap(ClientSize.Width, ClientSize.Height);
            pictureBox1.Image = bmp;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(bmp);
                g.DrawLine(new Pen(MainForm.CurColor, MainForm.CurWidth), oldX, oldY, e.X, e.Y);
                oldX = e.X;
                oldY = e.Y;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            oldX = e.X;
            oldY = e.Y;
        }
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
        public void SaveAs()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.AddExtension = true;
            dlg.Filter = "Windows Bitmap (*.bmp)|*.bmp| Файлы JPEG (*.jpg)|*.jpg";
            ImageFormat[] ff = { ImageFormat.Bmp, ImageFormat.Jpeg };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(dlg.FileName, ff[dlg.FilterIndex - 1]);
            }
        }

        public void Save()
        {
            if (path == null)
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.AddExtension = true;
                dlg.Filter = "Windows Bitmap (*.bmp)|*.bmp| Файлы JPEG (*.jpg)|*.jpg";
                ImageFormat[] ff = { ImageFormat.Bmp, ImageFormat.Jpeg };
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    bmp.Save(dlg.FileName, ff[dlg.FilterIndex - 1]);
                    path = dlg.FileName;
                    exp = ff[dlg.FilterIndex - 1];
                }
            }
            else
            {
                bmp.Save(path, exp);
            }
        }

       

    public Canvas(String FileName)
        {
            InitializeComponent();
            bmp = new Bitmap(FileName);
            Graphics g = Graphics.FromImage(bmp);
            pictureBox1.Height = bmp.Height;
            pictureBox1.Image = bmp;
        }
    }
}
