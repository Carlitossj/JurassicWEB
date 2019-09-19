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
    public partial class frmRegistroUsuario : Form
    {
        AdoMySQLEntityCore Ado;
        public frmRegistroUsuario()
        {
            InitializeComponent();
            Ado = new AdoMySQLEntityCore();
        }
        public bool vacio ;
        private void validar(Form formulario)
        {
            if(string.IsNullOrEmpty(txtNombreUsuario.Text))
            {
                MessageBox.Show("Favor de llenar todos los campos.");
                return;
            }

            if (string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Favor de llenar todos los campos.");
                return;
            }

            altaUsuario();
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            validar(this);
           
               
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
