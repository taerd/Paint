using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form2 : Form
    {
        Form1 frm1;
        public int res { get; private set; }
        public bool act { get; private set; }
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 f)
        {
            InitializeComponent();
            frm1 = f;
            act = false;
        }

        private void buttonStretch_Click(object sender, EventArgs e)
        { 
            this.Hide();
            act = true;
            res = 1;
            frm1.Show();
        }

        private void buttonCut_Click(object sender, EventArgs e)
        {
            this.Hide();
            act = true;
            res = 2;
            frm1.Show();
        }
    }
}
