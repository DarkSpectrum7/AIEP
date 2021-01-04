using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Logins
    {
        private int id_logins;
        private string cuenta;
        private string clave;
        private int id_tipo;

        public Logins()
        {
           
        }

        public int Id_logins { get => id_logins; set => id_logins = value; }
        public string Cuenta { get => cuenta; set => cuenta = value; }
        public string Clave { get => clave; set => clave = value; }
        public int Id_tipo { get => id_tipo; set => id_tipo = value; }
    }
}
