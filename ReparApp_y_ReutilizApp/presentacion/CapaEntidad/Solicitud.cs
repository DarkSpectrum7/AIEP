using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Solicitud
    {
        private int id_sol;
        private string detalle;
        private int estado;
        private int id_cli;

        public Solicitud()
        {
          
        }

        public int Id_sol { get => id_sol; set => id_sol = value; }
        public string Detalle { get => detalle; set => detalle = value; }
        public int Estado { get => estado; set => estado = value; }
        public int Id_cli { get => id_cli; set => id_cli = value; }
    }
}
