using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {
        Producto productoComprado;
        int cantidad;
        int precio;

        public Pedido(Producto productoComprado, int cantidad)
        {
            this.productoComprado = productoComprado;
            this.cantidad = cantidad;
            this.precio = productoComprado.Precio * cantidad;
        }

        public Producto ProductoComprado
        {
            set { productoComprado = value; }
            get { return productoComprado; }
        }

        public int Cantidad
        {
            set
            {
                if (value > 0)
                {
                    cantidad = value;
                }
            }
            get { return cantidad; }
        }

        public int Precio
        {
            set { precio = this.productoComprado.Precio * Cantidad; }
            get { return precio; }
        }

        public string detallePedido()
        {
            StringBuilder st = new StringBuilder();
            st.AppendLine($"Producto comprado: {this.ProductoComprado.Nombre}");
            st.AppendLine($"Precio por unidad: {this.ProductoComprado.Precio}");
            st.AppendLine($"Cantidad : {this.Cantidad} ---- Precio total: {this.Precio}");

            return st.ToString();
        }



        public string detallePedidoList()
        {
            string ret = $"{this.ProductoComprado.Nombre}  ${this.productoComprado.Precio}*{this.Cantidad} = {this.Precio}";
            return ret;
        }


    }
}
