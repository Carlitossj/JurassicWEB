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
    public partial class JurassicWeb : Form
    {
        bool Saltando = false;
        int VelocidadSalto = 10;
        int fuerza = 12;
        int puntos = 0;
        int Velocidadobstaculo = 10;
        Random rnd = new Random();
        public JurassicWeb()
        {
            InitializeComponent();
            ResetJuego();
        }
        private void ResetJuego()
        {

        }
        private void EventoJuego(object sender, EventArgs e)
        {
         pctTrex.Top += VelocidadSalto;
        // scoretext.Text=" score :" + puntos;
         if(Saltando && fuerza <0)
         {
             Saltando=false;
         }
            if (Saltando)
            {
                VelocidadSalto = -12;
                fuerza -= 1;
            }
            else VelocidadSalto = 12;
         foreach(Control x in this.Controls)
         {

         }
        }

        private void keyisdown(object sender, EventArgs e)
        {
         if(e.KeyCode==Keys.Space && !Saltando )
         {
             Saltando=true;
         }
        }
        private void keyisup(object sender, EventArgs e)
        {
         if(e.KeyCode == Keys.R)
         {
             ResetJuego();
         }
         if(Saltando)
         {
             Saltando = false;
         }
        }
    }
}
