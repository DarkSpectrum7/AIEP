using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cliente
    {
        private int id_cli;
        private int id_logins;

        public Cliente()
        {
            
        }

        public int Id_cli { get => id_cli; set => id_cli = value; }
        public string Id_logins { get => id_logins; set => id_logins = value; }
    }


}
