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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            
        }
        private void OcultaryMostrar(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            frmRegistroUsuario registro = new frmRegistroUsuario();
            OcultaryMostrar(registro);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmInicioSesion InicioSesion = new frmInicioSesion();
            OcultaryMostrar(InicioSesion);
        }

        
    }
}
