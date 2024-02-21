using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClientesEntities
{
    public class Usuario
    {
        private string _nombreUsuario;
        private string _nombre;
        private string _mail;
        private string _apellido;
        private string _contraseña;
        private int _id;
        
        
        

        public Usuario(int id, string nombre, string apellido,
            string nombreUsuario, string contraseña, string mail)
        {
            this._mail = mail;
            this._nombre = nombre;
            this._nombreUsuario = nombreUsuario;
            this._apellido = apellido;
            this._contraseña = contraseña;           
            this._id = id;
        }

        
        public string Contraseña { get => _contraseña; set => _contraseña = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Mail { get => _mail; set => _mail = value; }
        public int Id { get => _id; set => _id = value; }

        public string MostrarDatos()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Usuario: {this.NombreUsuario} \n");
            sb.AppendLine($"Email: {this.Mail} \n");
            return sb.ToString();
        }
    }
}
