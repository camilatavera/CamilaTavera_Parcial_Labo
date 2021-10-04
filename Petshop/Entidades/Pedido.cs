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


        /// <summary>
        /// get y set del atributo productoComprado
        /// </summary>
        public Producto ProductoComprado
        {
            set { productoComprado = value; }
            get { return productoComprado; }
        }


        /// <summary>
        /// get y set del atributo cantidad
        /// </summary>
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


        /// <summary>
        /// get y set del atributo precio
        /// </summary>
        public int Precio
        {
            set { precio = this.productoComprado.Precio * Cantidad; }
            get { return precio; }
        }


        /// <summary>
        /// Detalles del pedido
        /// </summary>
        /// <returns>string con los detalles</returns>
        public string detallePedido()
        {
            StringBuilder st = new StringBuilder();
            st.AppendLine($"Producto comprado: {this.ProductoComprado.Nombre}");
            st.AppendLine($"Precio por unidad: {this.ProductoComprado.Precio}");
            st.AppendLine($"Cantidad : {this.Cantidad} ---- Precio total: {this.Precio}");

            return st.ToString();
        }


        /// <summary>
        /// crea una cadena con el nombre, precio, cantidad, y precio total del producto
        /// </summary>
        /// <returns>string con los datos mencionados</returns>
        public string detallePedidoList()
        {
            string ret = $"\n {this.ProductoComprado.Nombre}  ${this.productoComprado.Precio}*{this.Cantidad} = {this.Precio}";
            return ret;
        }



        /// <summary>
        /// Muestra detalles del pedido
        /// </summary>
        /// <returns>string con los detalles</returns>
        public string mostrarDetallePedido()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.detallePedidoList());
            sb.AppendFormat("" +
                "-----------------------------------------------------------------" +
                "");
            sb.AppendLine(this.ProductoComprado.mostrarDetalleProducto());
           
            return sb.ToString();          
            
        }


    }
}
