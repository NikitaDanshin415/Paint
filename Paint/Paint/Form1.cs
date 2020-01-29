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
    public partial class MainForm : Form
    {
        public static Color CurColor = Color.Black;
        public static int CurWidth = 3;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutPaint frmAbout = new AboutPaint();
            frmAbout.ShowDialog();
        }

        private void НовыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Canvas frmChild = new Canvas();
            frmChild.MdiParent = this;
            frmChild.Show();
        }

        private void рисунокToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            размерХолстаToolStripMenuItem.Enabled = !(ActiveMdiChild == null);
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            сохранитьToolStripMenuItem.Enabled = !(ActiveMdiChild == null);
            сохранитьКакToolStripMenuItem.Enabled = !(ActiveMdiChild == null);
        }

        private void размерХолстаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CanvasSize cs = new CanvasSize();
            cs.CanvasWidth.Text = ((Canvas)ActiveMdiChild).CanvasWidth.ToString();
            cs.CanvasHeight.Text = ((Canvas)ActiveMdiChild).CanvasHeight.ToString();
            if (cs.ShowDialog() == DialogResult.OK)
            {
                ((Canvas)ActiveMdiChild).CanvasWidth = Convert.ToInt32(cs.CanvasWidth.Text);
                ((Canvas)ActiveMdiChild).CanvasHeight = Convert.ToInt32(cs.CanvasHeight.Text);
            }
        }
        private void красныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurColor = Color.Red;
        }

        private void синийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurColor = Color.Blue;
        }

        private void зеленыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurColor = Color.Green;
        }

        private void другойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                CurColor = cd.Color;
        }

        private void txtBrushSize_TextChanged(object sender, EventArgs e)
        { 
            try
            {     
                CurWidth = int.Parse(txtBrushSize.Text);
            }
            catch
            {
                MessageBox.Show("Значение должн быть целым числом.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void открытьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Windows Bitmap (*.bmp)|*.bmp| Файлы JPEG (*.jpeg, *.jpg)|*.jpeg;*.jpg|Все файлы ()*.*|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Canvas frmChild = new Canvas(dlg.FileName);
                frmChild.MdiParent = this;
                frmChild.Show();
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ((Canvas)ActiveMdiChild).SaveAs();
            }
        }

        private void cохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ((Canvas)ActiveMdiChild).Save();
            }
        }

        private void КаскадомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
         
        }

        private void СлеваНаправоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void СверхуВнизToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void УпорядочитьЗначкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
