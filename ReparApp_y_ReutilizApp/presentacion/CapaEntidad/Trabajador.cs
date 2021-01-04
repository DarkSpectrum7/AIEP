using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Trabajador
    {
        private int id_tra;
        private string cuetipo_oficionta;
        private int estado;
        private int id_logins;

        public Trabajador()
        {
            
        }

        public int Id_tra { get => id_tra; set => id_tra = value; }
        public string Cuetipo_oficionta { get => cuetipo_oficionta; set => cuetipo_oficionta = value; }
        public int Estado { get => estado; set => estado = value; }
        public int Id_logins { get => id_logins; set => id_logins = value; }
    }
}
