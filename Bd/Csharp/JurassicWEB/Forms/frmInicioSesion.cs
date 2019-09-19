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
    public partial class frmInicioSesion : Form
    {
        AdoMySQLEntityCore Ado = new AdoMySQLEntityCore();
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Ingresar();
           
            
           
        }
        private void Ingresar()
        {
            string nombre;
            string pass;
            string mensaje;
            try
            {
                
                pass = txtContraseña.Text;
                nombre = txtNameuser.Text;               
                Usuario usuario = Ado.buscarUsuario(nombre, pass);
                mensaje = usuario is null ? "no se encontro usario" : "inicio de sesion con exito";


            }
            catch (Exception e)
            {
                mensaje = e.Message;
            }
            MessageBox.Show(mensaje);
        }
        
       

    }
}
