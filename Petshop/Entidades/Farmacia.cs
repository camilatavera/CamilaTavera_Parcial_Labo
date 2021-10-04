using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Farmacia : Producto
    {
        bool bajoReceta;
        TipoRemedio formaRemedio;

        public Farmacia(string nombre, int precio, int cantidad, Mascota paraMascota,
            bool bajoReceta, TipoRemedio formaRemedio) : base(nombre, precio, cantidad, paraMascota)
        {
            this.BajoReceta = bajoReceta;
            this.FormaRemedio = formaRemedio;
        }


        /// <summary>
        /// get y set del atributo bajoReceta
        /// </summary>
        public bool BajoReceta
        {
            get { return bajoReceta; }
            set { bajoReceta = value; }
        }


        /// <summary>
        /// get y set del atributo formaRemedio
        /// </summary>
        public TipoRemedio FormaRemedio
        {
            get { return formaRemedio; }
            set { formaRemedio = value; }
        }


        /// <summary>
        /// Busca el producto por el id pasado por parametro y si lo encuentra lo edita con los 
        /// valores del producto con el que se llamo al metodo
        /// <param name="idAEditar"></param>
        /// <returns>el producto editado o null si no se pudo editar</returns>
        public override Producto editarProducto(int idAEditar)
        {
            
            Producto productoEdit = Negocio.buscarProducto(idAEditar);

            if (productoEdit != null)
            {
                productoEdit.Nombre = this.Nombre;
                productoEdit.Precio = this.Precio;
                productoEdit.Cantidad = this.Cantidad;
                productoEdit.ParaMascota = this.ParaMascota;
                ((Farmacia)productoEdit).BajoReceta = this.BajoReceta;
                ((Farmacia)productoEdit).BajoReceta = this.BajoReceta;

                return (Producto)productoEdit;
            }

            return null;
        }


        /// <summary>
        /// muestra los detalles del producto
        /// </summary>
        /// <returns> string con los detalles del producto</returns>
        public override string mostrarDetalleProducto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("PRODUCTO DEL SECTOR FARMACIA");

            if (bajoReceta == true)
            {
                sb.AppendLine($"VENTA BAJO RECETA");
            }
            else
            {
                sb.AppendLine($"SIN RECETA");
            }

            sb.AppendLine(base.mostrarDetalleProducto());
                      
            return sb.ToString();
        }

    }
}
