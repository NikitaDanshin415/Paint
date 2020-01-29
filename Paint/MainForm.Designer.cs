namespace Paint
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисунокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерХолстаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.окноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.каскадомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.слеваНаправоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сверхуВнизToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.упорядочитьЗначкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.красныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.синийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зеленыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.другойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtBrushSize = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.кистьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.линияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кругToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.звездаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ластикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.рисунокToolStripMenuItem,
            this.окноToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.фильтрыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.окноToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.toolStripMenuItem1,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.toolStripMenuItem2,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // новыйToolStripMenuItem
            // 
            this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.новыйToolStripMenuItem.Text = "Новый";
            this.новыйToolStripMenuItem.Click += new System.EventHandler(this.НовыйToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem2_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 6);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.cохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(150, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ВыходToolStripMenuItem_Click);
            // 
            // рисунокToolStripMenuItem
            // 
            this.рисунокToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размерХолстаToolStripMenuItem});
            this.рисунокToolStripMenuItem.Name = "рисунокToolStripMenuItem";
            this.рисунокToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.рисунокToolStripMenuItem.Text = "Рисунок";
            this.рисунокToolStripMenuItem.DropDownOpened += new System.EventHandler(this.рисунокToolStripMenuItem_DropDownOpening);
            // 
            // размерХолстаToolStripMenuItem
            // 
            this.размерХолстаToolStripMenuItem.Name = "размерХолстаToolStripMenuItem";
            this.размерХолстаToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.размерХолстаToolStripMenuItem.Text = "Размер холста";
            this.размерХолстаToolStripMenuItem.Click += new System.EventHandler(this.размерХолстаToolStripMenuItem_Click);
            // 
            // окноToolStripMenuItem
            // 
            this.окноToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.каскадомToolStripMenuItem,
            this.слеваНаправоToolStripMenuItem,
            this.сверхуВнизToolStripMenuItem,
            this.упорядочитьЗначкиToolStripMenuItem});
            this.окноToolStripMenuItem.Name = "окноToolStripMenuItem";
            this.окноToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.окноToolStripMenuItem.Text = "Окно";
            // 
            // каскадомToolStripMenuItem
            // 
            this.каскадомToolStripMenuItem.Name = "каскадомToolStripMenuItem";
            this.каскадомToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.каскадомToolStripMenuItem.Text = "Каскадом";
            this.каскадомToolStripMenuItem.Click += new System.EventHandler(this.КаскадомToolStripMenuItem_Click);
            // 
            // слеваНаправоToolStripMenuItem
            // 
            this.слеваНаправоToolStripMenuItem.Name = "слеваНаправоToolStripMenuItem";
            this.слеваНаправоToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.слеваНаправоToolStripMenuItem.Text = "Слева направо";
            this.слеваНаправоToolStripMenuItem.Click += new System.EventHandler(this.СлеваНаправоToolStripMenuItem_Click);
            // 
            // сверхуВнизToolStripMenuItem
            // 
            this.сверхуВнизToolStripMenuItem.Name = "сверхуВнизToolStripMenuItem";
            this.сверхуВнизToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.сверхуВнизToolStripMenuItem.Text = "Сверху вниз";
            this.сверхуВнизToolStripMenuItem.Click += new System.EventHandler(this.СверхуВнизToolStripMenuItem_Click);
            // 
            // упорядочитьЗначкиToolStripMenuItem
            // 
            this.упорядочитьЗначкиToolStripMenuItem.Name = "упорядочитьЗначкиToolStripMenuItem";
            this.упорядочитьЗначкиToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.упорядочитьЗначкиToolStripMenuItem.Text = "Упорядочить значки";
            this.упорядочитьЗначкиToolStripMenuItem.Click += new System.EventHandler(this.УпорядочитьЗначкиToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.ОПрограммеToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.txtBrushSize,
            this.toolStripSeparator2,
            this.toolStripSplitButton1,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.красныйToolStripMenuItem,
            this.синийToolStripMenuItem,
            this.зеленыйToolStripMenuItem,
            this.другойToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::Paint.Properties.Resources.Paint_Palette_80_icon_icons_com_57294;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // красныйToolStripMenuItem
            // 
            this.красныйToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("красныйToolStripMenuItem.Image")));
            this.красныйToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Red;
            this.красныйToolStripMenuItem.Name = "красныйToolStripMenuItem";
            this.красныйToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.красныйToolStripMenuItem.Text = "Красный";
            this.красныйToolStripMenuItem.Click += new System.EventHandler(this.красныйToolStripMenuItem_Click);
            // 
            // синийToolStripMenuItem
            // 
            this.синийToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("синийToolStripMenuItem.Image")));
            this.синийToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Blue;
            this.синийToolStripMenuItem.Name = "синийToolStripMenuItem";
            this.синийToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.синийToolStripMenuItem.Text = "Синий";
            this.синийToolStripMenuItem.Click += new System.EventHandler(this.синийToolStripMenuItem_Click);
            // 
            // зеленыйToolStripMenuItem
            // 
            this.зеленыйToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("зеленыйToolStripMenuItem.Image")));
            this.зеленыйToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.зеленыйToolStripMenuItem.Name = "зеленыйToolStripMenuItem";
            this.зеленыйToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.зеленыйToolStripMenuItem.Text = "Зеленый";
            this.зеленыйToolStripMenuItem.Click += new System.EventHandler(this.зеленыйToolStripMenuItem_Click);
            // 
            // другойToolStripMenuItem
            // 
            this.другойToolStripMenuItem.Name = "другойToolStripMenuItem";
            this.другойToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.другойToolStripMenuItem.Text = "Другой...";
            this.другойToolStripMenuItem.Click += new System.EventHandler(this.ДругойToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(38, 22);
            this.toolStripLabel1.Text = "Кисть";
            // 
            // txtBrushSize
            // 
            this.txtBrushSize.Name = "txtBrushSize";
            this.txtBrushSize.Size = new System.Drawing.Size(100, 25);
            this.txtBrushSize.TextChanged += new System.EventHandler(this.txtBrushSize_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кистьToolStripMenuItem,
            this.линияToolStripMenuItem,
            this.кругToolStripMenuItem,
            this.звездаToolStripMenuItem,
            this.ластикToolStripMenuItem});
            this.toolStripSplitButton1.Image = global::Paint.Properties.Resources.geometricshapesoutlinedsymbol_79963;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // кистьToolStripMenuItem
            // 
            this.кистьToolStripMenuItem.Name = "кистьToolStripMenuItem";
            this.кистьToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.кистьToolStripMenuItem.Text = "Кисть";
            this.кистьToolStripMenuItem.Click += new System.EventHandler(this.КистьToolStripMenuItem_Click);
            // 
            // линияToolStripMenuItem
            // 
            this.линияToolStripMenuItem.Name = "линияToolStripMenuItem";
            this.линияToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.линияToolStripMenuItem.Text = "Линия";
            this.линияToolStripMenuItem.Click += new System.EventHandler(this.линияToolStripMenuItem_Click);
            // 
            // кругToolStripMenuItem
            // 
            this.кругToolStripMenuItem.Name = "кругToolStripMenuItem";
            this.кругToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.кругToolStripMenuItem.Text = "Круг";
            this.кругToolStripMenuItem.Click += new System.EventHandler(this.КругToolStripMenuItem_Click);
            // 
            // звездаToolStripMenuItem
            // 
            this.звездаToolStripMenuItem.Name = "звездаToolStripMenuItem";
            this.звездаToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.звездаToolStripMenuItem.Text = "Звезда";
            this.звездаToolStripMenuItem.Click += new System.EventHandler(this.ЗвездаToolStripMenuItem_Click);
            // 
            // ластикToolStripMenuItem
            // 
            this.ластикToolStripMenuItem.Name = "ластикToolStripMenuItem";
            this.ластикToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.ластикToolStripMenuItem.Text = "Ластик";
            this.ластикToolStripMenuItem.Click += new System.EventHandler(this.ЛастикToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Paint.Properties.Resources.zoom_plus1;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.масштабToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Paint.Properties.Resources.zoom_minus;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.масштабToolStripMenuItem1_Click);
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MyPaint";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рисунокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерХолстаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem окноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem каскадомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem слеваНаправоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сверхуВнизToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem упорядочитьЗначкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem красныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem синийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зеленыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem другойToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtBrushSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem кистьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кругToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem звездаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ластикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem линияToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
    }
}

