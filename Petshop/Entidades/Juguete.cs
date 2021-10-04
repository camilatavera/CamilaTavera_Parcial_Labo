using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Juguete : Producto
    {
        bool paraCachorro;
        EMaterial material;
        public Juguete(string nombre, int precio, int cantidad, Mascota paraMascota,
            bool paraCachorro, EMaterial material) : base(nombre, precio, cantidad, paraMascota)
        {
            this.ParaCachorro = paraCachorro;
            this.Material = material;
        }


        /// <summary>
        /// get y set del atributo paraCachorro
        /// </summary>
        public bool ParaCachorro
        {
            get { return paraCachorro; }
            set { paraCachorro = value; }
        }


        /// <summary>
        /// get y set del atributo material
        /// </summary>
        public EMaterial Material
        {
            get { return material; }
            set { material = value; }
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
                ((Juguete)productoEdit).Material = this.Material;
                ((Juguete)productoEdit).ParaCachorro = this.ParaCachorro;

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
            sb.AppendLine("PRODUCTO DEL SECTOR JUGUETES");
            sb.AppendLine(base.mostrarDetalleProducto());
            return sb.ToString();
        }
    }
}
