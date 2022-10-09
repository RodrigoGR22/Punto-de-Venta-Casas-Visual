using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinicio.Modelo
{
    public class Casa
    {
        private int idcasa;
        private string imgcasa;
        private string nombre_casa;
        private string desc_casa;
        private float precio;
        private int estado;

        public Casa() { }

        public Casa(int idcasa, string imgcasa, string nombre_casa, string desc_casa, float precio, int estado)
        {
            this.idcasa = idcasa;
            this.imgcasa = imgcasa;
            this.nombre_casa = nombre_casa;
            this.desc_casa = desc_casa;
            this.precio = precio;
            this.estado = estado;
        }

        //Setters
        public void setIdCasa(int idcasa)
        {
            this.idcasa = idcasa;
        }

        public void setImgCasa(string imgcasa)
        {
            this.imgcasa = imgcasa;
        }

        public void setNombreCasa(string nombre_casa)
        {
            this.nombre_casa = nombre_casa;
        }

        public void setDescCasa(string desc_casa)
        {
            this.desc_casa = desc_casa;
        }

        public void setPrecio(float precio)
        {
            this.precio = precio;
        }

        public void setEstado (int estado)
        {
            this.estado= estado;
        }
        
        //Getters
        public int getIdCasa()
        {
            return this.idcasa;
        }

        public string getImgCasa()
        {
            return this.imgcasa;
        }

        public string getNombreCasa()
        {
            return this.nombre_casa;
        }

        public string getDescCasa()
        {
            return this.desc_casa;
        }

        public float getPrecio()
        {
            return this.precio;
        }

        public int getEstado()
        {
            return this.estado;
        }


        //Metodo ToString

        public override string ToString()
        {
            return "ID: " + this.idcasa + "\n" +
                "Nombre: " + this.nombre_casa + "\n" +
                "Precio: " + this.precio + "\n" + 
                "Estado: " + (this.estado == 1 ? "En Venta" : "Vendida");
        }
    }
}
