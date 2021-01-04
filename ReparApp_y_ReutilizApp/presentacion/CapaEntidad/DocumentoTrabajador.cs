using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DocumentoTrabajador
    {
        private int id_doc;
        private string documento;
        private DateTime fecha_carga;
        private DateTime fecha_caduca;
        private int id_tra;

        public DocumentoTrabajador()
        {

        }

        public int Id_doc { get => id_doc; set => id_doc = value; }
        public string Documento { get => documento; set => documento = value; }
        public DateTime Fecha_carga { get => fecha_carga; set => fecha_carga = value; }
        public DateTime Fecha_caduca { get => fecha_caduca; set => fecha_caduca = value; }
        public int Id_tra { get => id_tra; set => id_tra = value; }
    }
}
