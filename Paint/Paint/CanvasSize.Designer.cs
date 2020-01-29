namespace Paint
{
    partial class CanvasSize
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CanvasWidth = new System.Windows.Forms.TextBox();
            this.CanvasHeight = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ширина:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Высота:";
            // 
            // CanvasWidth
            // 
            this.CanvasWidth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CanvasWidth.Location = new System.Drawing.Point(88, 65);
            this.CanvasWidth.Name = "CanvasWidth";
            this.CanvasWidth.Size = new System.Drawing.Size(100, 20);
            this.CanvasWidth.TabIndex = 2;
            this.CanvasWidth.Text = "200";
            // 
            // CanvasHeight
            // 
            this.CanvasHeight.Location = new System.Drawing.Point(280, 64);
            this.CanvasHeight.Name = "CanvasHeight";
            this.CanvasHeight.Size = new System.Drawing.Size(100, 20);
            this.CanvasHeight.TabIndex = 3;
            this.CanvasHeight.Text = "100";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(231, 143);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(315, 143);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // CanvasSize
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 178);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.CanvasHeight);
            this.Controls.Add(this.CanvasWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CanvasSize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Размер холста";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox CanvasWidth;
        public System.Windows.Forms.TextBox CanvasHeight;
        private System.Windows.Forms.Button btnOK;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private new System.Windows.Forms.Button CancelButton;
    }
}