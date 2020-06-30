using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxOp1.Text);
            var y = int.Parse(this.textBoxOp2.Text);
            var z = x + y;
            this.labelResult1.Text = z.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxOp1.Text);
            var y = int.Parse(this.textBoxOp2.Text);
            var z = x - y;
            this.labelResult1.Text = z.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxOp1.Text);
            var y = int.Parse(this.textBoxOp2.Text);
            var z = x * y;
            this.labelResult1.Text = z.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxOp1.Text);
            var y = int.Parse(this.textBoxOp2.Text);
            if (y != 0)
            {
                var z = x / y;
                this.labelResult1.Text = z.ToString();
            }
            else {
                this.labelResult1.Text = "0不能作为除数";
            }
            
        }
    }
}
