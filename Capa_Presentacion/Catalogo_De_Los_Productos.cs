using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Interfas
{
    public partial class Catalogo_De_Los_Productos : Form
    {
        public Catalogo_De_Los_Productos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconoCerrarCat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void iconoMaximizarCat_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconoMaximizarCat.Visible = false;
            iconoRestaurarCat.Visible = true;
        }

        private void iconoRestaurarCat_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.iconoRestaurarCat.Visible = false;
            this.iconoMaximizarCat.Visible = true;
        }

        private void iconoMinimizarCat_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
