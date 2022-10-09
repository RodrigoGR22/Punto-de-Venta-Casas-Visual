using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;
using Pinicio.Modelo;
using System.Windows.Forms;

namespace Pinicio.Controlador
{
    public class Conector
    {
        public static DataSet consultar(string str)
        {
            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-5935JSM;Initial Catalog=puntodeventa;Persist Security Info=True;User ID=sa;Password=usuario");
            conexion.Open();

            DataSet contenido = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter(str, conexion);

            adaptador.Fill(contenido);

            conexion.Close();
            return contenido;
        }
    
        public static List<Casa> cargarCasas()
        {
            List<Casa> casas = new List<Casa>();
            try
            {
                string sql = string.Format("SELECT * FROM Casas");
                DataSet res = consultar(sql);

                int id = 0, estado = 0;
                string nombre = "", descripcion = "", imagen = "";
                float precio = 0.0f;

                for(int i = 0; i < res.Tables[0].Rows.Count; i++)
                {
                    id = Convert.ToInt32(res.Tables[0].Rows[i]["idcasa"].ToString().Trim());
                    nombre = res.Tables[0].Rows[i]["nombre"].ToString().Trim();
                    descripcion = res.Tables[0].Rows[i]["descripcion"].ToString().Trim();
                    precio = float.Parse(res.Tables[0].Rows[i]["precio"].ToString().Trim());
                    imagen = res.Tables[0].Rows[i]["imagen"].ToString().Trim();
                    estado = Convert.ToInt32(res.Tables[0].Rows[i]["estado"].ToString().Trim());

                    casas.Add(new Casa(id, imagen, nombre, descripcion, precio, estado));
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("Error al cargar las casas");
            }

            return casas;
        }
    }
}