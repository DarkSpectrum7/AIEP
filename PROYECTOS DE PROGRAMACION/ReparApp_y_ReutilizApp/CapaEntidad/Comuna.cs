using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Comuna
    {
        private int id_comuna;
        private int comunas;
        private int id_usr;

        public Comuna()
        {
           
        }

        public int Id_comuna { get => id_comuna; set => id_comuna = value; }
        public int Comunas { get => comunas; set => comunas = value; }
        public int Id_usr { get => id_usr; set => id_usr = value; }
    }
}
