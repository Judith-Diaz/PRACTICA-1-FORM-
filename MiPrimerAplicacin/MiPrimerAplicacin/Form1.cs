using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerAplicacin
{
    public partial class btn_SN : Form
    {
        public btn_SN()//desapárece el mmaximizar y minimizar
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }
  
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show(" chau, nos vamos de C#...." );
       
        }

     

        private void Form1_Click(object sender, EventArgs e)
        {
       
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(" se disparo el eventp", "atencion");
            this.BackColor = Color.Aqua;
        }

        private void btn_SN_Load(object sender, EventArgs e)
        {
            MessageBox.Show(" Bienvenidos a c#");
        }

        private void btn_SN_MouseClick(object sender, MouseEventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;

            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el botón Izquierdo", "Atención");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el Botón Derecho", "Atención");
            else if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el botón del Medio", "Atención");
        }

        private void lbl_IngreseAlgo_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ingreseAlgo_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_ingreseAlgo.BackColor = Color.Aquamarine;
        }
    }
}

