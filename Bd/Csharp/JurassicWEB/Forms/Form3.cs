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
    public partial class Form3 : Form
    {
        AdoMySQLEntityCore Ado;
        public Form3()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Ingresar();
           
            
           
        }
        private void Ingresar()
        {
            string mensaje;
            try
            {
                Usuario user = searchUsuario();
                Ado.buscarUsuario(user);

                mensaje = "ingreso con exito";
            }
            catch (Exception e)
            {
                mensaje = e.Message;
            }
            MessageBox.Show(mensaje);
        }
        private void  searchUsuario(Usuario usuario)
        {
            usuario.nombre_usuario = txtNameuser.Text;
            usuario.contrasenia = txtContraseña.Text;
        }

    }
}
