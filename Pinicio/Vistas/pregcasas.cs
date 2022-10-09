using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace Pinicio.Vistas
{
    public partial class pregcasas : Form
    {
        public pregcasas()
        {
            InitializeComponent();
        }

        private void pregcasas_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandText = " SELECT * FROM Casas";

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
