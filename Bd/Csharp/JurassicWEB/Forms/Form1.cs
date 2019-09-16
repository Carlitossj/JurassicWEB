using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JurassicWEB;

namespace Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           Form2 frm2 = new Form2();
            Form1 frm1 = new Form1();
            
            frm2.Show();
            frm1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            Form1 frm1 = new Form1();
            frm1.Hide();
            frm3.Show();
        }

       
    }
}
