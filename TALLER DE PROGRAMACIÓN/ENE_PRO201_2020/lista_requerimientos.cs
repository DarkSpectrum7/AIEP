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
    public partial class From_lista_requerimientos : Form
    {
        public From_lista_requerimientos()
        {
            InitializeComponent();
        }

        private void Lista_requerimientos_Load(object sender, EventArgs e)
        {
            Load_From();
        }

        private void Button_buscar_Click(object sender, EventArgs e)
        {
            BuscarRequerimiento();
        }

        private void Button_Mresuelto_Click(object sender, EventArgs e)
        {
            ModificarRegistro();
        }

        private void Button_eliminar_Click(object sender, EventArgs e)
        {
            EliminarRegistro();
        }

        public void Load_From()
        {
            LlenarDataGridView();
            llenaComboboxTrequerimiento();
            llenaComboboxPrioridad();
            comboBox_prioridad.Text = "Seleccione una opcion";
            comboBox_Trequerimiento.Text = "Seleccione una opcion";
        }

        private void LlenarDataGridView()
        {

            string conexion = "server=.; database=AIEP_TPROGRMACION; integrated security = true;";
            SqlConnection con = new SqlConnection(conexion);


            try
            {
                SqlCommand comSQL = new SqlCommand("SP_CargaDT", con);
                comSQL.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SQLAdapter = new SqlDataAdapter(comSQL);

                DataTable Dtable = new DataTable();

                con.Open();


                SQLAdapter.Fill(Dtable);

                dataGrid_Mdatos.DataSource = Dtable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ModificarRegistro()
        {
            if (dataGrid_Mdatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Estimado usuario, debe seleccionar un requerimiento para poder modificar su estado.");
                return;
            }

            int id_req = Convert.ToInt32(dataGrid_Mdatos.SelectedRows[0].Cells[0].Value);

            string conexion = "server=.; database=AIEP_TPROGRMACION; integrated security = true;";
            SqlConnection con = new SqlConnection(conexion);
            con.Open();

            SqlCommand comSQL;

            comSQL = new SqlCommand("SP_Mresuelto", con);
            comSQL.CommandType = CommandType.StoredProcedure;
            comSQL.Parameters.AddWithValue("@id_req", id_req);


            SqlDataAdapter AdapSQL = new SqlDataAdapter(comSQL);
            DataTable DTable = new DataTable();
            AdapSQL.Fill(DTable);

            if (DTable.Rows.Count > 0)
            {
                MessageBox.Show(DTable.Rows[0]["MensajeRet"].ToString());
                if (Convert.ToInt32(DTable.Rows[0]["CodigoRet"]) == 0)
                {
                    Load_From();
                }
            }
        }
        public void llenaComboboxTrequerimiento()
        {
            string conexion = "server=.; database=AIEP_TPROGRMACION; integrated security = true;";
            SqlConnection con = new SqlConnection(conexion);
            con.Open();
            DataSet Dset = new DataSet();
            SqlDataAdapter AdapSQL = new SqlDataAdapter("select id_tipo, tipo_req from tipo_requerimiento", con);
            AdapSQL.Fill(Dset, "tipo_requerimiento");
            comboBox_Trequerimiento.DataSource = Dset.Tables[0].DefaultView;
            comboBox_Trequerimiento.ValueMember = "tipo_req";
        }

        public void llenaComboboxPrioridad()
        {
            string conexion = "server=.; database=AIEP_TPROGRMACION; integrated security = true;";
            SqlConnection con = new SqlConnection(conexion);
            con.Open();
            DataSet Dset = new DataSet();
            SqlDataAdapter AdapSQL = new SqlDataAdapter("select id_prioridad,prioridad,plazo from tipo_prioridad", con);
            AdapSQL.Fill(Dset, "tipo_prioridad");

            comboBox_prioridad.DataSource = Dset.Tables[0].DefaultView;
            comboBox_prioridad.ValueMember = "prioridad";
        }

        public void EliminarRegistro()
        {
            int id_req = Convert.ToInt32(dataGrid_Mdatos.SelectedRows[0].Cells[0].Value);

            string conexion = "server=.; database=AIEP_TPROGRMACION; integrated security = true;";
            SqlConnection con = new SqlConnection(conexion);
            con.Open();

            SqlCommand comSQL;

            comSQL = new SqlCommand("SP_ERequerimiento", con);
            comSQL.CommandType = CommandType.StoredProcedure;
            comSQL.Parameters.AddWithValue("@id_req", id_req);

            SqlDataAdapter sqlSda = new SqlDataAdapter(comSQL);
            DataTable dtData = new DataTable();
            sqlSda.Fill(dtData);

            if (dtData.Rows.Count > 0)
            {
                MessageBox.Show(dtData.Rows[0]["MensajeRet"].ToString());
                if (Convert.ToInt32(dtData.Rows[0]["CodigoRet"]) == 0)
                {
                    button_buscar.PerformClick();
                }
            }
        }

        public void BuscarRequerimiento()
        {
            if (checkBox_pendientes.Checked == false && checkBox_resueltos.Checked == false)
            {
                MessageBox.Show("Favor de seleccionar al menos un estado.");
                return;
            }

            string conexion = "server=.; database=AIEP_TPROGRMACION; integrated security = true;";
            SqlConnection con = new SqlConnection(conexion);


            try
            {
                string Trequerimiento, Tprioridad;
                Trequerimiento = Convert.ToString(comboBox_Trequerimiento.SelectedValue);
                Tprioridad = Convert.ToString(comboBox_prioridad.SelectedValue);

                string Estado = "";
                if (checkBox_pendientes.Checked == true)
                    Estado = "P";

                if (checkBox_resueltos.Checked == true)
                    Estado = "R";

                if (checkBox_pendientes.Checked == true && checkBox_resueltos.Checked == true)
                    Estado = "T";

                con.Open();

                string SQLquery = "select	r.id_req as 'Código'," +
                    "tr.tipo_req as 'Tipo Requerimiento'," +
                    "r.descripcion as 'Descripción'," +
                    "r.estado as 'Estado'," +
                    "p.prioridad as 'Prioridad'," +
                    "p.plazo as 'Plazo',u.nombre as 'Asignado' from requerimiento r inner join tipo_prioridad p on r.id_prioridad = p.id_prioridad inner join tipo_requerimiento tr on tr.id_tipo = r.id_tipo inner join usuario u on u.id_cuenta = r.id_cuenta " +
                    "where tr.tipo_req = @tRequerimiento and prioridad = @Prioridad and estado = @Estado or @Estado = 'T'";

                SqlCommand comSQL = new SqlCommand(SQLquery, con);
                comSQL.Parameters.AddWithValue("@tRequerimiento", Trequerimiento);
                comSQL.Parameters.AddWithValue("@Prioridad", Tprioridad);
                comSQL.Parameters.AddWithValue("@Estado", Estado);
                SqlDataAdapter adaptador = new SqlDataAdapter(comSQL);
                DataTable datos = new DataTable();
                adaptador.Fill(datos);
                dataGrid_Mdatos.AutoGenerateColumns = false;
                dataGrid_Mdatos.DataSource = datos;
                dataGrid_Mdatos.Columns[0].DataPropertyName = "Código";
                dataGrid_Mdatos.Columns[1].DataPropertyName = "Tipo Requerimiento";
                dataGrid_Mdatos.Columns[2].DataPropertyName = "Descripción";
                dataGrid_Mdatos.Columns[3].DataPropertyName = "Estado";
                dataGrid_Mdatos.Columns[4].DataPropertyName = "Prioridad";
                dataGrid_Mdatos.Columns[5].DataPropertyName = "Plazo";
                dataGrid_Mdatos.Columns[6].DataPropertyName = "Asignado";
                     
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}
