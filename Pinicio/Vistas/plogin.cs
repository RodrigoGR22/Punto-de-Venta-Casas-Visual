using Pinicio.Controlador;
using Pinicio.Modelo;
using Pinicio.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;
namespace Pinicio
{
    public partial class plogin : Form
    {
        public plogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbusuario.Text.Trim().Length > 0 && tbcontra.Text.Trim().Length > 0)
                {
                    string query = string.Format("SELECT * FROM Usuarios WHERE usuario='{0}' AND password='{1}'",
                        tbusuario.Text.Trim(), tbcontra.Text.Trim());
                    DataSet info = Conector.consultar(query);

                    if(info.Tables[0].Rows.Count > 0)
                    {
                        this.Hide();
                        pventa cambio1 = new pventa();
                        cambio1.ShowDialog();
                        this.Show();
                    }

                    else
                    {
                        MessageBox.Show("No existe el usuario");
                    }
                }

                else
                {
                    MessageBox.Show("Falto algun campo");
                }
            }
            catch(Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }
    }
}
