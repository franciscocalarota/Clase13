using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClientesData
{
    public partial class Producto
    {
        public Producto()
        {
            ProductoVendidos = new HashSet<ProductoVendido>();
        }

        public int Id { get; set; }
        public string Descripciones { get; set; } = null!;
        public double? Costo { get; set; }
        public double PrecioVenta { get; set; }
        public int Stock { get; set; }
        public int IdUsuario { get; set; }

        public virtual Usuario IdUsuarioNvg { get; set; } = null!;
        public virtual ICollection<ProductoVendido> ProductoVendidos { get; set; }
    }
}
