using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class TipoUsuario
    {
        private int id_tipo;
        private string tipo_usr;

        public TipoUsuario()
        {
           
        }

        public int Id_tipo { get => id_tipo; set => id_tipo = value; }
        public string Tipo_usr { get => tipo_usr; set => tipo_usr = value; }
    }
}
