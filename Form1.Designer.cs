﻿namespace Paint
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMain = new System.Windows.Forms.Panel();
            this.groupBoxTools = new System.Windows.Forms.GroupBox();
            this.pictureEraser = new System.Windows.Forms.PictureBox();
            this.picturePen = new System.Windows.Forms.PictureBox();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPurple = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.comboBoxPtt = new System.Windows.Forms.ComboBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxArrow = new System.Windows.Forms.PictureBox();
            this.pictureBoxStar = new System.Windows.Forms.PictureBox();
            this.pictureBoxEllipse = new System.Windows.Forms.PictureBox();
            this.pictureBoxLine = new System.Windows.Forms.PictureBox();
            this.pictureBoxRectangle = new System.Windows.Forms.PictureBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelCol2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCol1 = new System.Windows.Forms.Panel();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEraser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePen)).BeginInit();
            this.groupBoxColor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEllipse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRectangle)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Location = new System.Drawing.Point(13, 93);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(890, 443);
            this.panelMain.TabIndex = 0;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            this.panelMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseDown);
            this.panelMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseMove);
            this.panelMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseUp);
            this.panelMain.Resize += new System.EventHandler(this.panelMain_Resize);
            // 
            // groupBoxTools
            // 
            this.groupBoxTools.Controls.Add(this.pictureEraser);
            this.groupBoxTools.Controls.Add(this.picturePen);
            this.groupBoxTools.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTools.Name = "groupBoxTools";
            this.groupBoxTools.Size = new System.Drawing.Size(114, 75);
            this.groupBoxTools.TabIndex = 1;
            this.groupBoxTools.TabStop = false;
            this.groupBoxTools.Text = "Инструменты";
            // 
            // pictureEraser
            // 
            this.pictureEraser.Image = ((System.Drawing.Image)(resources.GetObject("pictureEraser.Image")));
            this.pictureEraser.Location = new System.Drawing.Point(60, 32);
            this.pictureEraser.Name = "pictureEraser";
            this.pictureEraser.Size = new System.Drawing.Size(24, 22);
            this.pictureEraser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureEraser.TabIndex = 1;
            this.pictureEraser.TabStop = false;
            this.pictureEraser.Click += new System.EventHandler(this.ChangeItem);
            // 
            // picturePen
            // 
            this.picturePen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picturePen.Image = ((System.Drawing.Image)(resources.GetObject("picturePen.Image")));
            this.picturePen.InitialImage = null;
            this.picturePen.Location = new System.Drawing.Point(13, 31);
            this.picturePen.Margin = new System.Windows.Forms.Padding(0);
            this.picturePen.Name = "picturePen";
            this.picturePen.Size = new System.Drawing.Size(29, 27);
            this.picturePen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picturePen.TabIndex = 0;
            this.picturePen.TabStop = false;
            this.picturePen.WaitOnLoad = true;
            this.picturePen.Click += new System.EventHandler(this.ChangeItem);
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.panel1);
            this.groupBoxColor.Controls.Add(this.panelPurple);
            this.groupBoxColor.Controls.Add(this.panelYellow);
            this.groupBoxColor.Controls.Add(this.panelGreen);
            this.groupBoxColor.Controls.Add(this.panelBlue);
            this.groupBoxColor.Controls.Add(this.panelRed);
            this.groupBoxColor.Controls.Add(this.panelBlack);
            this.groupBoxColor.Location = new System.Drawing.Point(132, 12);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(96, 75);
            this.groupBoxColor.TabIndex = 2;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Цвет";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(70, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(15, 15);
            this.panel1.TabIndex = 6;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChangeColor);
            // 
            // panelPurple
            // 
            this.panelPurple.BackColor = System.Drawing.Color.Purple;
            this.panelPurple.Location = new System.Drawing.Point(50, 43);
            this.panelPurple.Name = "panelPurple";
            this.panelPurple.Size = new System.Drawing.Size(15, 15);
            this.panelPurple.TabIndex = 5;
            this.panelPurple.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChangeColor);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(49, 21);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(15, 15);
            this.panelYellow.TabIndex = 4;
            this.panelYellow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChangeColor);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.Location = new System.Drawing.Point(28, 43);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(15, 15);
            this.panelGreen.TabIndex = 3;
            this.panelGreen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChangeColor);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(27, 21);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(15, 15);
            this.panelBlue.TabIndex = 2;
            this.panelBlue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChangeColor);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(6, 43);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(15, 15);
            this.panelRed.TabIndex = 1;
            this.panelRed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChangeColor);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(6, 21);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(15, 15);
            this.panelBlack.TabIndex = 0;
            this.panelBlack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChangeColor);
            // 
            // comboBoxPtt
            // 
            this.comboBoxPtt.FormattingEnabled = true;
            this.comboBoxPtt.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBoxPtt.Location = new System.Drawing.Point(556, 12);
            this.comboBoxPtt.Name = "comboBoxPtt";
            this.comboBoxPtt.Size = new System.Drawing.Size(55, 24);
            this.comboBoxPtt.TabIndex = 3;
            this.comboBoxPtt.SelectedIndexChanged += new System.EventHandler(this.comboBoxPtt_SelectedIndexChanged);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(495, 12);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(55, 23);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxArrow);
            this.groupBox1.Controls.Add(this.pictureBoxStar);
            this.groupBox1.Controls.Add(this.pictureBoxEllipse);
            this.groupBox1.Controls.Add(this.pictureBoxLine);
            this.groupBox1.Controls.Add(this.pictureBoxRectangle);
            this.groupBox1.Location = new System.Drawing.Point(388, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фигуры";
            // 
            // pictureBoxArrow
            // 
            this.pictureBoxArrow.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxArrow.Image")));
            this.pictureBoxArrow.Location = new System.Drawing.Point(49, 48);
            this.pictureBoxArrow.Name = "pictureBoxArrow";
            this.pictureBoxArrow.Size = new System.Drawing.Size(22, 21);
            this.pictureBoxArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxArrow.TabIndex = 4;
            this.pictureBoxArrow.TabStop = false;
            this.pictureBoxArrow.Click += new System.EventHandler(this.ChangeFigure);
            // 
            // pictureBoxStar
            // 
            this.pictureBoxStar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStar.Image")));
            this.pictureBoxStar.Location = new System.Drawing.Point(23, 48);
            this.pictureBoxStar.Name = "pictureBoxStar";
            this.pictureBoxStar.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxStar.TabIndex = 3;
            this.pictureBoxStar.TabStop = false;
            this.pictureBoxStar.Click += new System.EventHandler(this.ChangeFigure);
            // 
            // pictureBoxEllipse
            // 
            this.pictureBoxEllipse.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEllipse.Image")));
            this.pictureBoxEllipse.Location = new System.Drawing.Point(66, 20);
            this.pictureBoxEllipse.Name = "pictureBoxEllipse";
            this.pictureBoxEllipse.Size = new System.Drawing.Size(24, 21);
            this.pictureBoxEllipse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxEllipse.TabIndex = 2;
            this.pictureBoxEllipse.TabStop = false;
            this.pictureBoxEllipse.Click += new System.EventHandler(this.ChangeFigure);
            // 
            // pictureBoxLine
            // 
            this.pictureBoxLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxLine.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLine.Image")));
            this.pictureBoxLine.Location = new System.Drawing.Point(36, 21);
            this.pictureBoxLine.Name = "pictureBoxLine";
            this.pictureBoxLine.Size = new System.Drawing.Size(28, 24);
            this.pictureBoxLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLine.TabIndex = 1;
            this.pictureBoxLine.TabStop = false;
            this.pictureBoxLine.Click += new System.EventHandler(this.ChangeFigure);
            // 
            // pictureBoxRectangle
            // 
            this.pictureBoxRectangle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRectangle.Image")));
            this.pictureBoxRectangle.Location = new System.Drawing.Point(6, 21);
            this.pictureBoxRectangle.Name = "pictureBoxRectangle";
            this.pictureBoxRectangle.Size = new System.Drawing.Size(24, 20);
            this.pictureBoxRectangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxRectangle.TabIndex = 0;
            this.pictureBoxRectangle.TabStop = false;
            this.pictureBoxRectangle.Click += new System.EventHandler(this.ChangeFigure);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(495, 41);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(55, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelCol2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.panelCol1);
            this.groupBox2.Location = new System.Drawing.Point(234, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 75);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Основные цвета";
            // 
            // panelCol2
            // 
            this.panelCol2.Location = new System.Drawing.Point(87, 24);
            this.panelCol2.Name = "panelCol2";
            this.panelCol2.Size = new System.Drawing.Size(30, 30);
            this.panelCol2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Цвет 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Цвет 1";
            // 
            // panelCol1
            // 
            this.panelCol1.BackColor = System.Drawing.Color.Black;
            this.panelCol1.Location = new System.Drawing.Point(23, 24);
            this.panelCol1.Name = "panelCol1";
            this.panelCol1.Size = new System.Drawing.Size(30, 30);
            this.panelCol1.TabIndex = 0;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(495, 67);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(55, 23);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(915, 548);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.comboBoxPtt);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.groupBoxTools);
            this.Controls.Add(this.panelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTools.ResumeLayout(false);
            this.groupBoxTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEraser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePen)).EndInit();
            this.groupBoxColor.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEllipse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRectangle)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.GroupBox groupBoxTools;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.PictureBox picturePen;
        private System.Windows.Forms.PictureBox pictureEraser;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.ComboBox comboBoxPtt;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelPurple;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxLine;
        private System.Windows.Forms.PictureBox pictureBoxRectangle;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBoxEllipse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelCol2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelCol1;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBoxArrow;
        private System.Windows.Forms.PictureBox pictureBoxStar;
    }
}

