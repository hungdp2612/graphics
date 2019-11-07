using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BodyMassIndex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.button1.Click += button1_Click;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Height = double.Parse(txtH.Text);
            double Weight = double.Parse(txtW.Text);
            double Result = Weight / ((Height / 100) * (Height / 100));
            Result = Math.Round(Result, 1);
            txtBMI.Text = Result.ToString();
            

        }
    }
}
