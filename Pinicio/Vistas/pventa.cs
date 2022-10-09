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
using Microsoft.VisualBasic;

namespace Pinicio
{
    public partial class pventa : Form
    {
        int idx = 0;
        List<Casa> listaCasas = new List<Casa>();
        public pventa()
        {
            InitializeComponent();
        }
        private void pventa_Load(object sender, EventArgs e)
        {
            cargarCasas();
            actualizarCasas(idx);
        }

        private void registroDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pregusuarios cambio = new pregusuarios();
            cambio.ShowDialog();
        }

        private void registroDeCasasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pregcasas cambio3 = new pregcasas();
            cambio3.ShowDialog();
            
        }

        public void actualizarCasas(int id)
        {
            casa_nombre.Text = listaCasas.ElementAt(id).getNombreCasa();
            casa_precio.Text = "PRECIO: $" + listaCasas.ElementAt(id).getPrecio();
            casa_descripcion.Text = listaCasas.ElementAt(id).getDescCasa();
            casa_imagen.ImageLocation = listaCasas.ElementAt(id).getImgCasa().ToString();
        }

        public void cargarCasas()
        {
            listaCasas.Clear();
            listaCasas = Conector.cargarCasas();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if(listaCasas.Count > 0 && idx <= listaCasas.Count)
            {
                idx++;
                actualizarCasas(idx);
                btnAnterior.Enabled = true;
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if(idx > 0)
            {
                idx--;
                actualizarCasas(idx);
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if(listaCasas.Count > 0)
            {
                if(listaCasas.ElementAt(idx).getEstado() == 1)
                {
                    string resultado = Interaction.InputBox("Ingrese el monto de pago", "Comprar Casa", "", 150, 150);
                    float precio = float.Parse(resultado);

                    if(precio >= listaCasas.ElementAt(idx).getPrecio())
                    {
                        listaCasas.ElementAt(idx).setEstado(0);
                        MessageBox.Show("Compra realizada con exito");
                    }
                    else
                    {
                        MessageBox.Show("El monto de pago es menor al precio de la casa");
                    }
                }
                else
                {
                    MessageBox.Show("La casa ya esta vendida");
                }
            }
            else
            {
                MessageBox.Show("No hay casas disponibles");
            }
        }
    }
}
