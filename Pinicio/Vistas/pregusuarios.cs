using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Pinicio.Vistas
{
    public partial class pregusuarios : Form
    {
        DataTable tabladata = new DataTable();
        public pregusuarios()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pregusuarios_Load(object sender, EventArgs e)
        {
            cargarcolumnas();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void registroDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void cargarcolumnas()
        {
            tabladata.Rows.Clear();
            tabladata.Columns.Clear();
            tabladata.Columns.Add("ID");
            tabladata.Columns.Add("Usuario");
            tabladata.Columns.Add("Password");
            cargarfilas();
            dataGridView1.DataSource = tabladata;
        }

        public void cargarfilas()
        {

        }

        public void cargarUsuarioa()
        {

        }


        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
