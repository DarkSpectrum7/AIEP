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
    public partial class From_registro_requerimiento : Form
    {
        public From_registro_requerimiento()
        {
            InitializeComponent();
        }

        private void From_registro_requerimiento_Load(object sender, EventArgs e)
        {
            Load_From();
        }

        private void Button_Lcampos_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void Button_Guardar_Click(object sender, EventArgs e)
        {
            GuardarReq();
            limpiar();
        }

        private void Button_Lrequerimientos_Click(object sender, EventArgs e)
        {
            From_lista_requerimientos FConsulta = new From_lista_requerimientos();
            FConsulta.MdiParent = this.ParentForm;
            FConsulta.Show();
        }

        public void Load_From()
        {
        
            comboBox_TRequerimiento.DisplayMember = "Text";
            comboBox_TRequerimiento.ValueMember = "Value";
            var itemsReq = new[] {
                new {Text ="Base de Datos",Value = "1" },
                new {Text ="Sistemas",Value = "2" },
                new {Text ="Instalacion de Software",Value = "3" },
            };
            comboBox_TRequerimiento.DataSource = itemsReq;

            comboBox_Asignado.DisplayMember = "Text";
            comboBox_Asignado.ValueMember = "Value";
            var itemsUsuario = new[]
            {
            new {Text = "Administrador" , Value = "admin"},
            new {Text = "Juan Perez" , Value = "usr1"},
            new {Text = "Patricio Vasquez" , Value = "usr2"},
            new {Text = "Alejandro Martinez" , Value = "usr3"}
            };
            comboBox_Asignado.DataSource = itemsUsuario;

            comboBox_Prioridad.DisplayMember = "Text";
            comboBox_Prioridad.ValueMember = "Value";
            var itemsReq1 = new[]
            {
            new {Text = "Alta" , Value = "1"},
            new {Text = "Media" , Value = "2"},
            new {Text = "Baja" , Value = "3"},
            };

            comboBox_Prioridad.DataSource = itemsReq1;

            comboBox_TRequerimiento.SelectedIndex = -1;
            comboBox_Asignado.SelectedIndex = -1;
            comboBox_Prioridad.SelectedIndex = -1;

            comboBox_Asignado.Text = "Seleccione una opcion";
            comboBox_Prioridad.Text = "Seleccione una opcion";
            comboBox_TRequerimiento.Text = "Seleccione una opcion";

        }


        public void limpiar()
        {
            comboBox_Asignado.Text = "Seleccionar una opcion";
            comboBox_Prioridad.Text = "Seleccionar una opcion";
            comboBox_TRequerimiento.Text = "Seleccionar una opcion";
            textBox_Descripcion.Text = "";
            comboBox_TRequerimiento.Show();
        }

        public void GuardarReq()
        {
            if (comboBox_Asignado.SelectedIndex == -1)
            {
                MessageBox.Show("Estimado usuario, debe seleccionar el usuario responsable antes de Grabar");
                return;
            }

            if (textBox_Descripcion.TextLength == 0)
            {
                MessageBox.Show("Estimado usuario, debe ingresar la descripcion del requerimientos antes de Grabar");
                return;
            }

            if (comboBox_TRequerimiento.SelectedIndex == -1)
            {
                MessageBox.Show("Estimado usuario, debe seleccionar el tipo de requerimientos antes de Grabar");
                return;
            }

            if (comboBox_Prioridad.SelectedIndex == -1)
            {
                MessageBox.Show("Estimado usuario, debe seleccionar el tipo prioridad antes de Grabar");
                return;
            }

            Requerimiento req = new Requerimiento();

            req.descripcion = textBox_Descripcion.Text;
            req.id_cuenta = comboBox_Asignado.SelectedValue.ToString();
            req.id_req = Convert.ToInt32(comboBox_TRequerimiento.SelectedValue);
            req.prioridad = Convert.ToInt32(comboBox_Prioridad.SelectedValue);

            string MensajeRetorno;
            MensajeRetorno = req.GuardarRequerimiento();

            MessageBox.Show(MensajeRetorno);
        }
    }
}
