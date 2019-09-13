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
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            crearUsuario();
        }

        private void crearUsuario()
        {
            Usuario user = new Usuario()
            {
                nombre_usuario = txtNombreUsuario.Text,
                contrasenia = txtPass.Text
            };

        }
    }
}
