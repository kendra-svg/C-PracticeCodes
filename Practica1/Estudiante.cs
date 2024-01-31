using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class Estudiante
    {
        public Estudiante() {
            Alumnos = new List<string>();
        }

   

        public string NombreUsuario { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }

        public int NumeroCarnet { get; set; }

        public List<string> Alumnos { get; set; }
    }
}
