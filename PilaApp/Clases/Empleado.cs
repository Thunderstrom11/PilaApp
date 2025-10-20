using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaApp.Clases
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido {  get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }

        public string NombreCompleto
        {
            get { return $"{Nombre} {Apellido}"; }
        }

    }
}
