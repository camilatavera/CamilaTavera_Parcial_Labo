using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cama : Producto
    {
        bool conBase;
        ETamanoCama tamanio;

        public Cama(string nombre, int precio, int cantidad, Mascota paraMascota,
            bool conBase, ETamanoCama tamanio) : base(nombre, precio, cantidad, paraMascota)
        {
            this.ConBase = conBase;
            this.Tamanio = tamanio;
        }


        /// <summary>
        /// get y set del atributo conBase
        /// </summary>
        public bool ConBase
        {
            get { return conBase; }
            set { conBase = value; }
        }


        /// <summary>
        /// get y set del atributo tamanio
        /// </summary>
        public ETamanoCama Tamanio
        {
            get { return tamanio; }
            set { tamanio = value; }
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
                ((Cama)productoEdit).Tamanio = this.Tamanio;
                ((Cama)productoEdit).ConBase = this.ConBase;

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
            sb.AppendLine("PRODUCTO DEL SECTOR CAMA");
            sb.AppendLine(base.mostrarDetalleProducto());
            return sb.ToString();
        }
    }
}
