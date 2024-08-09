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
    public partial class cambieNombre : Form
    {
        public cambieNombre()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(" Bienvenidos a c#");

        }
  
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show(" chau, nos vamos de C#...." );

        }
    }
}
