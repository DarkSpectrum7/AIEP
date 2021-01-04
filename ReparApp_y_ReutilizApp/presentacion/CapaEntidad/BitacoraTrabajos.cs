using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
   public class BitacoraTrabajos
    {
        private int id_bit;
        private int id_cli;
        private int id_tra;
        private int id_sol;

        public  BitacoraTrabajos()
        {

        }



        public int Id_bit { get => id_bit; set => id_bit = value; }
        public int Id_cli { get => id_cli; set => id_cli = value; }
        public int Id_tra { get => id_tra; set => id_tra = value; }
        public int Id_sol { get => id_sol; set => id_sol = value; }
    }
}
