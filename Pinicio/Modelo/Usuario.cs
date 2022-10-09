using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinicio.Modelo
{
    class Usuario
    {
        private int id_usuario; 
        private string usuario;
        private string password;
        

        public Usuario() { }

        public Usuario(int id_usuario, string nombre, string apellido, int rol, string usuario, string password, string image, string lastConn)
        {
            this.id_usuario = id_usuario;
            this.usuario = usuario;
            this.password = password;
        }

        //Setters
        public void setId_Usuario(int id_usuario)
        {
            this.id_usuario = id_usuario;
        }

        

        public void setUsuario(string usuario)
        {
            this.usuario = usuario;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }


        //Getters
        public int getidusuario(int id_usuario)
        {
            return this.id_usuario;
        }


        public string getusuario (string usuario)
        {
            return this.usuario;
        }

        public string getpassword(string password)
        {
            return this.password;
        }

        //Metodo ToString
        public override string ToString()
        {
            return "ID Usuario: " + id_usuario + "]\nUsuario: " + usuario + "\nPassword: " + password;
        }
    }
}

