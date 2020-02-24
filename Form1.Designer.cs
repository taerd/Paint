namespace Paint
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
            this.pictureBoxBrush = new System.Windows.Forms.PictureBox();
            this.pictureEraser = new System.Windows.Forms.PictureBox();
            this.picturePen = new System.Windows.Forms.PictureBox();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.panelPurple = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.comboBoxPtt = new System.Windows.Forms.ComboBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxLine = new System.Windows.Forms.PictureBox();
            this.pictureBoxRectangle = new System.Windows.Forms.PictureBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEraser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePen)).BeginInit();
            this.groupBoxColor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRectangle)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Location = new System.Drawing.Point(13, 97);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1507, 598);
            this.panelMain.TabIndex = 0;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            this.panelMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseDown);
            this.panelMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseMove);
            this.panelMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseUp);
            // 
            // groupBoxTools
            // 
            this.groupBoxTools.Controls.Add(this.pictureBoxBrush);
            this.groupBoxTools.Controls.Add(this.pictureEraser);
            this.groupBoxTools.Controls.Add(this.picturePen);
            this.groupBoxTools.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTools.Name = "groupBoxTools";
            this.groupBoxTools.Size = new System.Drawing.Size(150, 75);
            this.groupBoxTools.TabIndex = 1;
            this.groupBoxTools.TabStop = false;
            this.groupBoxTools.Text = "Инструменты";
            // 
            // pictureBoxBrush
            // 
            this.pictureBoxBrush.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBrush.Image")));
            this.pictureBoxBrush.Location = new System.Drawing.Point(108, 31);
            this.pictureBoxBrush.Name = "pictureBoxBrush";
            this.pictureBoxBrush.Size = new System.Drawing.Size(25, 23);
            this.pictureBoxBrush.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxBrush.TabIndex = 2;
            this.pictureBoxBrush.TabStop = false;
            this.pictureBoxBrush.Click += new System.EventHandler(this.ChangeItem);
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
            this.picturePen.Image = ((System.Drawing.Image)(resources.GetObject("picturePen.Image")));
            this.picturePen.InitialImage = null;
            this.picturePen.Location = new System.Drawing.Point(13, 31);
            this.picturePen.Margin = new System.Windows.Forms.Padding(0);
            this.picturePen.Name = "picturePen";
            this.picturePen.Size = new System.Drawing.Size(25, 23);
            this.picturePen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picturePen.TabIndex = 0;
            this.picturePen.TabStop = false;
            this.picturePen.WaitOnLoad = true;
            this.picturePen.Click += new System.EventHandler(this.ChangeItem);
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.panelPurple);
            this.groupBoxColor.Controls.Add(this.panelYellow);
            this.groupBoxColor.Controls.Add(this.panelGreen);
            this.groupBoxColor.Controls.Add(this.panelBlue);
            this.groupBoxColor.Controls.Add(this.panelRed);
            this.groupBoxColor.Controls.Add(this.panelBlack);
            this.groupBoxColor.Location = new System.Drawing.Point(170, 13);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(73, 75);
            this.groupBoxColor.TabIndex = 2;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Цвет";
            // 
            // panelPurple
            // 
            this.panelPurple.BackColor = System.Drawing.Color.Purple;
            this.panelPurple.Location = new System.Drawing.Point(50, 43);
            this.panelPurple.Name = "panelPurple";
            this.panelPurple.Size = new System.Drawing.Size(15, 15);
            this.panelPurple.TabIndex = 5;
            this.panelPurple.Click += new System.EventHandler(this.ChangeColor);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(49, 21);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(15, 15);
            this.panelYellow.TabIndex = 4;
            this.panelYellow.Click += new System.EventHandler(this.ChangeColor);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.Location = new System.Drawing.Point(28, 43);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(15, 15);
            this.panelGreen.TabIndex = 3;
            this.panelGreen.Click += new System.EventHandler(this.ChangeColor);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(27, 21);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(15, 15);
            this.panelBlue.TabIndex = 2;
            this.panelBlue.Click += new System.EventHandler(this.ChangeColor);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(6, 43);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(15, 15);
            this.panelRed.TabIndex = 1;
            this.panelRed.Click += new System.EventHandler(this.ChangeColor);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(6, 21);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(15, 15);
            this.panelBlack.TabIndex = 0;
            this.panelBlack.Click += new System.EventHandler(this.ChangeColor);
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
            this.comboBoxPtt.Location = new System.Drawing.Point(249, 25);
            this.comboBoxPtt.Name = "comboBoxPtt";
            this.comboBoxPtt.Size = new System.Drawing.Size(55, 24);
            this.comboBoxPtt.TabIndex = 3;
            this.comboBoxPtt.SelectedIndexChanged += new System.EventHandler(this.comboBoxPtt_SelectedIndexChanged);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(249, 55);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(55, 25);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxLine);
            this.groupBox1.Controls.Add(this.pictureBoxRectangle);
            this.groupBox1.Location = new System.Drawing.Point(310, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фигуры";
            // 
            // pictureBoxLine
            // 
            this.pictureBoxLine.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLine.Image")));
            this.pictureBoxLine.Location = new System.Drawing.Point(36, 21);
            this.pictureBoxLine.Name = "pictureBoxLine";
            this.pictureBoxLine.Size = new System.Drawing.Size(24, 20);
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
            this.buttonSave.Location = new System.Drawing.Point(477, 13);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1532, 708);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEraser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePen)).EndInit();
            this.groupBoxColor.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRectangle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.GroupBox groupBoxTools;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.PictureBox picturePen;
        private System.Windows.Forms.PictureBox pictureBoxBrush;
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
    }
}

