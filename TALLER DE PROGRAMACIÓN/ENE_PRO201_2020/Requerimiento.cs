using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENE_PRO201_2020
{
    class Requerimiento
    {
        public Requerimiento()
        {
            id_req = 0;
            descripcion = "nuevo requerimiento.";
            estado = "P";
            tipo_req = 1;
            prioridad = 3;
            plazo = DateTime.Now;
            id_cuenta = "";
        }

        public int id_req { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
        public int tipo_req { get; set; }
        public int prioridad { get; set; }
        public DateTime plazo { get; set; }
        public string id_cuenta { get; set; }

        public string GuardarRequerimiento()
        {

            string conexion = "server=.; database=AIEP_TPROGRMACION; integrated security = true;";
            SqlConnection con = new SqlConnection(conexion);
            con.Open();


            SqlCommand comSQl;

            comSQl = new SqlCommand("SP_InsertarReq", con);
            comSQl.CommandType = CommandType.StoredProcedure;
            comSQl.Parameters.AddWithValue("@tipoReq", tipo_req);
            comSQl.Parameters.AddWithValue("@usuario", id_cuenta);
            comSQl.Parameters.AddWithValue("@desc", descripcion);
            comSQl.Parameters.AddWithValue("@prioridad", prioridad);

            SqlDataAdapter sqlSda = new SqlDataAdapter(comSQl);
            DataTable dtData = new DataTable();
            sqlSda.Fill(dtData);

            if (dtData.Rows.Count > 0)
            {
                return dtData.Rows[0]["MensajeRet"].ToString();
            }
            else
            {
                return "No fue posible grabar el requerimiento.";
            }


            
        }

    }
}

