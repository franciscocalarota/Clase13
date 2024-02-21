using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClientesData
{
    public partial class Venta
    {
        public Venta()
        {
            ProductoVendidos = new HashSet<ProductoVendido>();
        }

        public int Id { get; set; }
        public string? Comentarios { get; set; }
        public int IdUsuario { get; set; }

        public virtual Usuario IdUsuarioNvg { get; set; } = null!;
        public virtual ICollection<ProductoVendido> ProductoVendidos { get; set; }
    }
}
