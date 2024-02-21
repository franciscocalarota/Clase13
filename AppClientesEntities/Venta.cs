using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClientesEntities
{
    public class Venta
    {
        private int  _id;
        private string  _comentarios;
        private int  _idUsuario;

        public Venta(int idUsuario, int id, string comentarios)
        {
           _id = id;
           _comentarios = comentarios;
           _idUsuario = idUsuario;
        }

        public int Id { get => _id; set => _id = value; }
        public string Comentarios { get => _comentarios; set => _comentarios = value; }
        public int IdUsuario { get => _idUsuario; set => _idUsuario = value; }
    }
}
