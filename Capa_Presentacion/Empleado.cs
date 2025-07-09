using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocios;

namespace Capa_Presentacion
{
    public partial class Empleado : Form
    {

        public Empleado()
        {
            InitializeComponent();


        }

        List<IEmpleado> empleados = new List<IEmpleado>();

        private void Empleados_Load(object sender, EventArgs e)
        {
            empleados.Add(new EmpleadoIA { Nombre = "KORVI:", Rol  = "Cajero Automático" });
            empleados.Add(new Administrador { Nombre = "Dubenny:", Rol = "Administrador Maestro" });

            foreach (var emp in empleados)
            {
                listBox1.Items.Add(emp.DescribirTrabajo());
            }
        }

        private void Empleado_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

public interface IEmpleado
{
    string Nombre { get; set; }
    string Rol { get; set; }
    string DescribirTrabajo();
}

public class EmpleadoIA : IEmpleado
{
    public string Nombre { get; set; }
    public string Rol { get; set; }

    public string DescribirTrabajo()
    {
        return $"{Nombre} trabaja como {Rol}.";
    }
}

public class Administrador : IEmpleado
{
    public string Nombre { get; set; }
    public string Rol { get; set; }

    public string DescribirTrabajo()
    {
        return $"{Nombre} es un {Rol}.";
    }
}

