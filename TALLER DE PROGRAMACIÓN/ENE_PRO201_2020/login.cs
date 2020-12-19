using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENE_PRO201_2020
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Button_Entrar_Click(object sender, EventArgs e)
        {
            Login();
        }

        public void Login()
        {
            string Usuario, Clave;

            Usuario = textBox_Usuario.Text;
            Clave = textBox_Password.Text;

            string conexion = "server=.; database=AIEP_TPROGRMACION; integrated security = true;";
            SqlConnection con = new SqlConnection(conexion);
            con.Open();

            SqlCommand comSQl;

            comSQl = new SqlCommand("SP_ValidaUsuario", con);
            comSQl.CommandType = CommandType.StoredProcedure;
            comSQl.Parameters.AddWithValue("@usuario", Usuario);
            comSQl.Parameters.AddWithValue("@clave", Clave);

            SqlDataAdapter AdapSQL = new SqlDataAdapter(comSQl);
            DataTable dt = new DataTable();
            AdapSQL.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show(Convert.ToString(dt.Rows[0]["MensajeRet"]));
            }
            else
            {
                From_menu Fmenu = new From_menu();
                Fmenu.Show();
                this.Hide();
            }

            con.Close();
        }
    }
    
}
