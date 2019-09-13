using JurassicWEB;
using JurassicWEB.ADO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form2 : Form
    {
        AdoMySQLEntityCore Ado;
        public Form2()
        {
            InitializeComponent();
            Ado = new AdoMySQLEntityCore();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            altaUsuario();
        }
        private void altaUsuario()
        {
            string mensaje;
            try
            {
                Usuario user = crearUsuario();
                Ado.agregarUsuario(user);
                mensaje = "Dado de alta con exito";
            }
            catch (Exception e)
            {
                mensaje = e.Message;
            }
            MessageBox.Show(mensaje);
        }
        private Usuario crearUsuario()
        {
            return new Usuario()
            {
                nombre_usuario = txtNombreUsuario.Text,
                contrasenia = txtPass.Text
            };
        }
    }
}
