using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingEdd
{
      class CProducto
    {
        protected string descripcion;
        protected double precioCompra;
        protected double precioVenta;

        public CProducto (string pDescripcion, double pPrecioCompra)
        {
            descripcion = pDescripcion;
            precioCompra = pPrecioCompra;
            precioVenta = 0.0;

        }
        public virtual void CalcularPrecio()
        {

            precioVenta = precioCompra * 1.3;

        }
        public override string ToString()
        {
            return string.Format($"{descripcion} cuesta {precioCompra} y se vende en {precioVenta}");
        }

    }
}
