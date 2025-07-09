using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios
{
    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public Empleado(string nombre)
        {
            Nombre = nombre;
        }

        public abstract string ObtenerRol();

        public virtual string Presentarse()
        {
            return $"{ObtenerRol()}: {Nombre}";
        }
    }

    public class Cajero : Empleado
    {
        public Cajero(string nombre) : base(nombre) { }

        public override string ObtenerRol()
        {
            return "Cajero";
        }
    }

    public class Administrador : Empleado
    {
        public Administrador(string nombre) : base(nombre) { }

        public override string ObtenerRol()
        {
            return "Administrador";
        }
    }
}
