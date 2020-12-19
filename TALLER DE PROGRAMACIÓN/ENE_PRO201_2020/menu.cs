using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENE_PRO201_2020
{
    public partial class From_menu : Form
    {
        public From_menu()
        {
            InitializeComponent();
        }

        private void ConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            From_lista_requerimientos FConsulta = new From_lista_requerimientos();
            FConsulta.MdiParent = this;
            FConsulta.Show();
        }

        private void RegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            From_registro_requerimiento FRegistro = new From_registro_requerimiento();
            FRegistro.MdiParent = this;
            FRegistro.Show();
        }

        private void From_menu_Load(object sender, EventArgs e)
        {

        }

        private void From_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
