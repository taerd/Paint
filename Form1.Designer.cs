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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureEraser = new System.Windows.Forms.PictureBox();
            this.picturePen = new System.Windows.Forms.PictureBox();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.comboBoxPtt = new System.Windows.Forms.ComboBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBoxTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEraser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePen)).BeginInit();
            this.groupBoxColor.SuspendLayout();
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
            this.panelMain.Size = new System.Drawing.Size(707, 343);
            this.panelMain.TabIndex = 0;
            this.panelMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseDown);
            this.panelMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseMove);
            this.panelMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseUp);
            // 
            // groupBoxTools
            // 
            this.groupBoxTools.Controls.Add(this.pictureBox3);
            this.groupBoxTools.Controls.Add(this.pictureEraser);
            this.groupBoxTools.Controls.Add(this.picturePen);
            this.groupBoxTools.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTools.Name = "groupBoxTools";
            this.groupBoxTools.Size = new System.Drawing.Size(150, 75);
            this.groupBoxTools.TabIndex = 1;
            this.groupBoxTools.TabStop = false;
            this.groupBoxTools.Text = "Инструменты";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(108, 31);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
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
            this.pictureEraser.Click += new System.EventHandler(this.pictureEraser_Click);
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
            this.picturePen.Click += new System.EventHandler(this.picturePen_Click);
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.panelBlue);
            this.groupBoxColor.Controls.Add(this.panelRed);
            this.groupBoxColor.Controls.Add(this.panelBlack);
            this.groupBoxColor.Location = new System.Drawing.Point(170, 13);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(150, 75);
            this.groupBoxColor.TabIndex = 2;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Цвет";
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(27, 21);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(15, 15);
            this.panelBlue.TabIndex = 2;
            this.panelBlue.Click += new System.EventHandler(this.panelBlue_Click);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(6, 43);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(15, 15);
            this.panelRed.TabIndex = 1;
            this.panelRed.Click += new System.EventHandler(this.panelRed_Click);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(6, 21);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(15, 15);
            this.panelBlack.TabIndex = 0;
            this.panelBlack.Click += new System.EventHandler(this.panelBlack_Click);
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
            this.comboBoxPtt.Location = new System.Drawing.Point(326, 25);
            this.comboBoxPtt.Name = "comboBoxPtt";
            this.comboBoxPtt.Size = new System.Drawing.Size(35, 24);
            this.comboBoxPtt.TabIndex = 3;
            this.comboBoxPtt.SelectedIndexChanged += new System.EventHandler(this.comboBoxPtt_SelectedIndexChanged);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(327, 56);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 25);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 453);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.comboBoxPtt);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.groupBoxTools);
            this.Controls.Add(this.panelMain);
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "Form1";
            this.Text = "Paint";
            //this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTools.ResumeLayout(false);
            this.groupBoxTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEraser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePen)).EndInit();
            this.groupBoxColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.GroupBox groupBoxTools;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.PictureBox picturePen;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureEraser;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.ComboBox comboBoxPtt;
        private System.Windows.Forms.Button buttonClear;
    }
}

