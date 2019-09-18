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
            string nombre;
            string pass;
            string mensaje;
            try
            {
                
                pass = txtContraseña.Text;
                nombre = txtNameuser.Text;
                Ado.buscarUsuario(nombre,pass);
                mensaje = "inicio de sesion con exito";
            }
            catch (Exception e)
            {
                mensaje = e.Message;
            }
            MessageBox.Show(mensaje);
        }
        
       

    }
}
