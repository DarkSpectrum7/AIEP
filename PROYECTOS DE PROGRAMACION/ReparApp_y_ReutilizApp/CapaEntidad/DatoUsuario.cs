using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DatoUsuario
    {
        private int id_usr;
        private string rut;
        private string nombre;
        private string direccion;
        private string correo_tra;
        private int telefono_tra;
        private int id_cli;
        private int id_tra;

        public DatoUsuario()
        {
          
        }

        public int Id_usr { get => id_usr; set => id_usr = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Correo_tra { get => correo_tra; set => correo_tra = value; }
        public int Telefono_tra { get => telefono_tra; set => telefono_tra = value; }
        public int Id_cli { get => id_cli; set => id_cli = value; }
        public int Id_tra { get => id_tra; set => id_tra = value; }
    }
}
