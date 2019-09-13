using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JurassicWEB.Forms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Registrarse frm2 = new Registrarse();

            frm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IniciarSesion frm3 = new IniciarSesion();
            frm3.Show();
        }
    }
}
