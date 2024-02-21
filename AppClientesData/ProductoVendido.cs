using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClientesData
{
    public partial class ProductoVendido
    {
        public int Id { get; set; }
        public int Stock { get; set; }
        public int IdProducto { get; set; }
        public int IdVenta { get; set; }

        public virtual Producto IdProductoNvg { get; set; } = null!;
        public virtual Venta IdVentaNvg { get; set; } = null!;
    }
}
