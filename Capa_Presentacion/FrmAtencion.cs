using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocios;

namespace Capa_Presentacion
{
    public partial class FrmAtencion : Form
    {
        private Cajero cajero;
        private Administrador administrador;

        public FrmAtencion()
        {
            InitializeComponent();
        }

        private void FrmAtencion_Load(object sender, EventArgs e)
        {
            // Instanciar empleados con nombres fijos
            cajero = new Cajero("KORVI\nSoy la IA Creada por Dubenny el Administrador\nSere el cajero que te atendera.");


            administrador = new Administrador("Dubenny\nSoy creador y Administrador de todo esto.");



            lblTitulo.Text = "Quiénes te están atendiendo";
            lblCajero.Text = cajero.Presentarse();
            lblAdministrador.Text = administrador.Presentarse();
        }

        private void iconoCerrarPeronal_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void iconoMinimizarPersonal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void lblCajero_Click(object sender, EventArgs e)
        {

        }
    }
}