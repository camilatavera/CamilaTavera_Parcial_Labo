using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alimento : Producto
    {
        bool esBalanceado;
        TipoAlimento tipoDeAlimento;

        public Alimento(string nombre, int precio, int cantidad, Mascota paraMascota,
            bool esBalanceado, TipoAlimento tipoDeAlimento) : base(nombre, precio, cantidad, paraMascota)
        {
            this.EsBalanceado = esBalanceado;
            this.TipoDeAlimento = tipoDeAlimento;
        }


        /// <summary>
        /// get y set del atributo esBalanceado
        /// </summary>
        public bool EsBalanceado
        {
            get { return esBalanceado; }
            set { esBalanceado = value; }
        }

        /// <summary>
        /// get y set del atributo tipoDeAlimento
        /// </summary>
        public TipoAlimento TipoDeAlimento
        {
            get { return tipoDeAlimento; }
            set { tipoDeAlimento = value; }
        }


        /// <summary>
        /// Busca el producto por el id pasado por parametro y si lo encuentra lo edita con los 
        /// valores del producto con el que se llamo al metodo
        /// <param name="idAEditar"></param>
        /// <returns>el producto editado o null si no se pudo editar</returns>
        public override Producto editarProducto(int idAEditar)
        {
            Producto productoEdit = Negocio.buscarProducto(idAEditar);
            if(productoEdit!=null)
            {
                productoEdit.Nombre = this.Nombre;
                productoEdit.Precio = this.Precio;
                productoEdit.Cantidad = this.Cantidad;
                productoEdit.ParaMascota = this.ParaMascota;
                ((Alimento)productoEdit).TipoDeAlimento = this.tipoDeAlimento;
                ((Alimento)productoEdit).EsBalanceado = this.EsBalanceado;
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
            sb.AppendLine("PRODUCTO DEL SECTOR ALIMENTO");
            sb.AppendLine(base.mostrarDetalleProducto());
            return sb.ToString();
        }
    }
}
